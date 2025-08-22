# BLIP-2: Bootstrapping Language-Image Pre-training

## 1. Vấn đề của các mô hình thị giác-ngôn ngữ hiện tại

### 1.1 Chi phí huấn luyện khổng lồ

Các mô hình vision-language truyền thống thường được huấn luyện **end-to-end** từ đầu, tương tự như việc xây một tòa nhà từ nền móng. Cách tiếp cận này:
- Yêu cầu lượng dữ liệu và tài nguyên tính toán khổng lồ
- Tốn kém và mất rất nhiều thời gian
- Tạo ra rào cản lớn cho các nghiên cứu và ứng dụng

### 1.2 Thiếu tính linh hoạt

Các nhà nghiên cứu đã có sẵn nhiều mô hình mạnh trong từng lĩnh vực:
- **Bộ mã hóa hình ảnh** (Vision Encoders): chuyên về xử lý thị giác
- **Mô hình ngôn ngữ lớn** (LLMs): chuyên về xử lý ngôn ngữ

Tuy nhiên, khi muốn kết hợp chúng, đa số phương pháp buộc phải huấn luyện lại toàn bộ, khiến những kiến thức tích lũy từ trước khó được tận dụng tối đa.

### 1.3 Hạn chế của các phương pháp hiện có

#### Frozen và Flamingo
- **Ý tưởng**: "Đóng băng" LLM, chỉ huấn luyện phần kết nối với hình ảnh
- **Vấn đề**: 
  - Flamingo cần số tham số lớn gấp hàng chục lần BLIP-2 để đạt hiệu suất tương tự
  - Chỉ dựa vào **language modeling loss** (dự đoán từ tiếp theo)
  - Không đủ để LLM học cách liên kết hình ảnh với ngôn ngữ khi bị đóng băng

#### Catastrophic Forgetting
Khi mô hình học thêm khả năng thị giác, nó có thể đánh mất phần nào năng lực ngôn ngữ vốn có - giống như một người học ngoại ngữ nhưng quên cách sử dụng tiếng mẹ đẻ.

## 2. Giải pháp của BLIP-2

### 2.1 Triết lý thiết kế

BLIP-2 **tận dụng các thành phần có sẵn** thay vì xây mới từ đầu:
- Giữ nguyên (frozen) bộ mã hóa hình ảnh mạnh đã được huấn luyện
- Giữ nguyên (frozen) LLM đã được huấn luyện
- Thêm một thành phần nhẹ nhưng quan trọng: **Q-Former**

### 2.2 Vai trò của Q-Former

Q-Former hoạt động như một **"người phiên dịch"** giữa mắt và não:
- Trích xuất các đặc trưng hình ảnh cần thiết
- Chuyển đổi thông tin theo cách LLM có thể hiểu
- Chỉ có ~188 triệu tham số (nhỏ hơn nhiều so với các giải pháp khác)
- Giúp BLIP-2 đạt hiệu quả vượt trội

![Q-Former model](https://github.com/Luc1dddM/DemoPrnSlot5/blob/main/Screenshot%20From%202025-08-22%2010-44-01.png)

## 3. Kiến trúc BLIP-2

### 3.1 Ba thành phần chính

```
[Hình ảnh] → [Image Encoder] → [Q-Former] → [LLM] → [Văn bản]
    ↓            (Frozen)        (Trainable)   (Frozen)      ↓
Patch Embeddings              Query Embeddings           Generated Text
```

#### 1. Image Encoder (Frozen)
- **Loại**: Thường là Vision Transformer (ViT)
- **Pre-training**: CLIP, MAE, hoặc BEiT-3
- **Đầu ra**: Patch embeddings (mỗi patch = một vector)
- **Trạng thái**: Đóng băng (không cập nhật trọng số)

#### 2. Q-Former (Trainable)
- **Cấu trúc**: Transformer nhỏ gọn
- **Input**: 
  - Query Tokens (tham số học được)
  - Image features từ Image Encoder
- **Cơ chế Attention đặc biệt**:
  - ✅ Query tokens **attend** đến image embeddings
  - ❌ Image embeddings **KHÔNG attend ngược** vào queries
- **Đầu ra**: Query embeddings (thông tin ảnh đã được nén)

#### 3. Text Encoder/LLM (Frozen)
- **Stage 1**: BERT (cho representation learning)
- **Stage 2**: LLM như OPT, T5, Vicuna (cho generation)
- **Trạng thái**: Đóng băng (không cập nhật trọng số)

![Q-Former model](https://github.com/Luc1dddM/DemoPrnSlot5/blob/main/Screenshot%20From%202025-08-22%2009-57-51.png)

## 4. Pipeline Huấn luyện Hai Giai đoạn

### Stage 1: Vision-Language Representation Learning

**Mục tiêu**: Dạy Q-Former cách trích xuất thông tin ảnh và liên kết với văn bản

**Text Encoder**: BERT (frozen)

**Ba nhiệm vụ song song**:

#### 4.1 Image-Text Contrastive Learning (ITC)

**Mục đích**: Học cách đối chiếu ảnh và văn bản

**Pipeline**:
```
Ảnh → Image Encoder → Patch Embeddings
                           ↓
Query Tokens → Q-Former → Query Embeddings → Image Representation
                           
Văn bản → BERT → [CLS] Embedding → Text Representation

Cosine Similarity(Image_Repr, Text_Repr) → InfoNCE Loss
```

**Cơ chế Attention**:
- ✅ Queries attend vào image embeddings (cross-attention)
- ❌ Image embeddings không attend ngược (bảo vệ image encoder)

**Loss Function**: InfoNCE (contrastive loss)
- Ảnh khớp văn bản → similarity cao
- Ảnh không khớp văn bản → similarity thấp

#### 4.2 Image-grounded Text Generation (ITG)

**Mục đích**: Sinh mô tả văn bản từ hình ảnh

**Pipeline**:
```
Ảnh → Image Encoder → Q-Former → Query Embeddings (context)
                                      ↓
Văn bản (shifted right) → BERT Decoder → Generated Caption
```

**Cơ chế Masking**:
- Query embeddings làm **encoder hidden states**
- Văn bản dùng **causal mask**: token hiện tại chỉ nhìn thấy các token trước đó
- BERT đóng vai trò text decoder

**Loss Function**: Cross-entropy loss giữa output và ground truth caption

#### 4.3 Image-Text Matching (ITM)

**Mục đích**: Phân loại cặp ảnh-văn bản có khớp nhau không

**Pipeline**:
```
Query Embeddings + Text Embeddings → Concatenate
                    ↓
             Transformer → [CLS] Token
                    ↓
           Classification Head → Binary Label
```

**Loss Function**: Binary cross-entropy
- Label 1: Ảnh và văn bản khớp
- Label 0: Ảnh và văn bản không khớp

![Objectives mask](https://github.com/Luc1dddM/DemoPrnSlot5/blob/main/Screenshot%20From%202025-08-22%2009-58-25.png)

Stage 2: Vision-to-Language Generative Learning
Mục tiêu: Kết nối Q-Former với LLM để sinh văn bản từ ảnh
Thay đổi quan trọng: Không dùng BERT nữa, chuyển sang LLM
Sau khi Stage 1 huấn luyện Q-Former để sinh ra visual queries có khả năng align với text space, Stage 2 kết nối Q-Former với Large Language Model (LLM). Tùy kiến trúc LLM, pipeline chia làm 2 hướng chính:
4.4 Case A: Decoder-only LLM (OPT, GPT, LLaMA)
Pipeline:
Image → Image Encoder (frozen) → Q-Former → Query Embeddings
                                    ↓
                            Linear Projection
                                    ↓
[Query Embeddings + Prompt Tokens (optional)] → LLM Decoder
                                    ↓
                              Generated Text
Cơ chế hoạt động:

LLM chỉ có decoder → không có encoder riêng biệt
Query Embeddings được chèn trực tiếp vào đầu chuỗi input như soft prompts
Prompt text (ví dụ: "Question: What is in the image?") được nối ngay sau queries
LLM Decoder dùng causal self-attention, nên mọi text token đều có thể "nhìn thấy" các query embeddings

Ví dụ Input Sequence:
[Q1] [Q2] [Q3] ... [Q32] [Question:] [What] [is] [in] [the] [image] [?]
 ↑____Query Embeddings____↑      ↑_________Text Tokens_________↑
Attention Pattern:

Query embeddings có thể attend vào nhau
Text tokens có thể attend vào tất cả query embeddings và các text token trước đó
Causal masking được áp dụng cho text tokens (không nhìn thấy token tương lai)

Loss Function: Cross-entropy loss giữa output sinh ra và ground truth
4.5 Case B: Encoder-Decoder LLM (FlanT5, BART-like)
Pipeline:
Image → Image Encoder (frozen) → Q-Former → Query Embeddings
                                    ↓
                            Linear Projection
                                    ↓
[Query Embeddings + Prefix Text (optional)] → LLM Encoder
                                 ↓
                           LLM Decoder → Generated Text
Cơ chế hoạt động:

Query Embeddings sau khi chiếu sang dimension của LLM được concatenate với prefix text tokens
Prefix text thường là instruction (ví dụ: "Describe this image:")
Toàn bộ sequence này đi qua LLM Encoder để tạo contextual representations
LLM Decoder sử dụng cross-attention với encoder outputs để sinh caption hoặc answer

Ví dụ Encoder Input:
[Q1] [Q2] [Q3] ... [Q32] [Describe] [this] [image] [:]
 ↑____Query Embeddings____↑    ↑___Prefix Text___↑
Attention trong Encoder:

Bidirectional attention cho toàn bộ sequence (query embeddings + prefix text)
Không có causal masking trong encoder

Loss Function: Cross-entropy loss giữa decoder output và ground truth

![BLIP-2’s second-stage](https://github.com/Luc1dddM/DemoPrnSlot5/blob/main/Screenshot%20From%202025-08-22%2009-59-09.png)

5. Ưu điểm của BLIP-2
5.1 Hiệu quả tính toán

Tham số học: Chỉ ~188M (Q-Former) thay vì toàn bộ model
Tái sử dụng: Tận dụng các model pretrained mạnh
Linh hoạt: Có thể thay đổi Image Encoder hoặc LLM mà không cần huấn luyện lại từ đầu

5.2 Hiệu suất vượt trội

So với Flamingo: Đạt kết quả tương tự với ít tham số hơn hàng chục lần
Đa nhiệm: Xử lý tốt nhiều task khác nhau (VQA, captioning, reasoning)
Tránh catastrophic forgetting: Giữ nguyên năng lực của các component gốc

5.3 Thiết kế thông minh

Two-stage training: Tách biệt việc học representation và generation
Attention mechanism: Bảo vệ frozen components khỏi bị ảnh hưởng
Query-based approach: Trích xuất thông tin ảnh hiệu quả

[Cần hình minh họa: Biểu đồ so sánh hiệu suất vs số tham số của các phương pháp]
6. Kết luận
BLIP-2 đại diện cho một bước tiến quan trọng trong lĩnh vực vision-language modeling bằng cách:

Giải quyết vấn đề chi phí: Giảm drastically tài nguyên cần thiết cho huấn luyện
Tận dụng tri thức có sẵn: Kết hợp các model pretrained mạnh một cách thông minh
Thiết kế linh hoạt: Cho phép swap các component mà không ảnh hưởng đến toàn bộ hệ thống
Hiệu suất cao: Đạt kết quả SOTA trên nhiều benchmark quan trọng

Phương pháp này mở ra hướng nghiên cứu mới cho việc xây dựng các hệ thống AI đa phương thức hiệu quả và tiết kiệm tài nguyên.

Tài liệu tham khảo:

BLIP-2: Bootstrapping Language-Image Pre-training with Frozen Image Encoders and Large Language Models
Salesforce Research, 2023

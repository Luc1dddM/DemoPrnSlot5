# ERD và Database Normalization - Hướng Dẫn Chi Tiết

## I. ERD (Entity-Relationship Diagram)

**ERD (Entity-Relationship Diagram)** là một công cụ trực quan giúp mô tả các thực thể trong hệ thống và các mối quan hệ giữa chúng. ERD thường được sử dụng để thiết kế và mô hình hóa cơ sở dữ liệu quan hệ, giúp hình dung cấu trúc logic của hệ thống dữ liệu.

### Các Ký Hiệu Phổ Biến

Có nhiều cách ký hiệu để vẽ ERD, phổ biến nhất là:

- **Chen's Notation**: Sử dụng hình chữ nhật cho thực thể, hình oval cho thuộc tính, hình thoi cho mối quan hệ.
- **Crow's Foot Notation** (Ký hiệu chân chim): Thường được dùng trong công cụ hiện đại (như MySQL Workbench, Lucidchart...), sử dụng biểu tượng rõ ràng để biểu diễn số lượng và loại quan hệ (1:1, 1:N, M:N).

📌 *Hình minh họa Chen's Notation (chèn hình tại đây)*  
📌 *Hình minh họa Crow's Foot Notation (chèn hình tại đây)*

### Các Thành Phần Chính của ERD

#### 1. Thực Thể (Entity)
- Biểu diễn bằng hình chữ nhật (trong cả hai ký hiệu)
- Là đối tượng có thể xác định được trong hệ thống
- Tên thường là danh từ số ít, ví dụ: `Customer`, `Order`, `Product`

#### 2. Thực Thể Yếu (Weak Entity)
- Không có khóa riêng biệt, phụ thuộc vào thực thể khác để tồn tại
- Ví dụ: `OrderItem` phụ thuộc vào `Order`

#### 3. Thực Thể Kết Hợp (Associative Entity)
- Xuất hiện trong mối quan hệ nhiều-nhiều
- Ví dụ: `Enrollment` giữa `Student` và `Course`

#### 4. Thuộc Tính (Attribute)
Biểu diễn bằng hình oval (Chen) hoặc nằm trong thực thể (Crow's Foot). Gồm:

- **Thuộc tính khóa (Key Attribute)**: Dùng để định danh thực thể duy nhất (gạch chân trong Chen)
- **Thuộc tính tổng hợp (Composite)**: Có thể chia nhỏ, ví dụ: địa chỉ
- **Thuộc tính đa trị (Multivalued)**: Có nhiều giá trị, ví dụ: số điện thoại
- **Thuộc tính dẫn xuất (Derived)**: Tính toán từ dữ liệu khác, ví dụ: tuổi từ ngày sinh

#### 5. Mối Quan Hệ (Relationship)
- Chen dùng **hình thoi** mô tả, có ghi rõ loại quan hệ: 1:1, 1:N, M:N
- Crow's Foot dùng **các ký hiệu "chân chim"** để trực quan hóa bội số

#### 6. Ràng Buộc Tham Gia (Participation Constraints)
- **Toàn phần (Total Participation)**: Tất cả thực thể đều tham gia vào mối quan hệ
- **Một phần (Partial Participation)**: Không bắt buộc mọi thực thể đều tham gia

### Các Bước Vẽ ERD

1. **Xác định thực thể chính**: Vẽ hình chữ nhật (Chen) hoặc hộp (Crow's Foot), không trùng lặp
2. **Xác định mối quan hệ**: Kết nối thực thể bằng đường và hình thoi (Chen) hoặc các nhánh quan hệ (Crow's Foot)
3. **Thêm thuộc tính**: Dễ hiểu, đúng ngữ nghĩa và phân biệt được các loại thuộc tính

**Ví dụ**: Mối quan hệ giữa `Customer` và `Product` thông qua `Order` và `OrderDetail` là cách điển hình để xử lý mối quan hệ nhiều-nhiều.

---

## II. Database Normalization – Chuẩn Hóa Dữ Liệu

**Normalization** là kỹ thuật tổ chức dữ liệu trong cơ sở dữ liệu để **loại bỏ dư thừa** và **tránh lỗi (anomalies)**.

### Các Loại Dị Thường

- **Chèn (Insertion anomalies)**: Không thể thêm dữ liệu nếu thiếu thông tin liên quan
- **Cập nhật (Update anomalies)**: Dữ liệu bị lặp, khó cập nhật đồng bộ
- **Xóa (Delete anomalies)**: Xóa một thông tin có thể làm mất những dữ liệu khác

### Các Dạng Chuẩn Hóa (Normal Forms)

#### 1NF – First Normal Form
- Mỗi ô chỉ chứa giá trị đơn
- Không có thuộc tính lặp

#### 2NF – Second Normal Form
- Đã ở 1NF
- Mọi thuộc tính không khóa **phụ thuộc đầy đủ** vào toàn bộ khóa chính

#### 3NF – Third Normal Form
- Đã ở 2NF
- Không có **phụ thuộc bắc cầu** giữa các thuộc tính không khóa

#### BCNF – Boyce-Codd Normal Form
- Mạnh hơn 3NF
- **Mọi phụ thuộc hàm X → Y**, X phải là **siêu khóa**

#### 4NF – Fourth Normal Form
- Không có phụ thuộc đa trị

#### 5NF – Fifth Normal Form
- Bảng có thể phân rã mà không bị **mất dữ liệu** khi nối lại

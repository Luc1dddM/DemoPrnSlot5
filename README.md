# Recap Kiến Thức Tuần [X] - [Tháng/Ngày]

🔖 **Mục lục nhanh**:
- [1. Kiến thức cơ bản](#1-kiến-thức-cơ-bản)
  - [1.1. Kiểu dữ liệu](#11-kiểu-dữ-liệu)
  - [1.2. Danh sách trong Python](#12-danh-sách-trong-python)
- [2. Kiến thức mở rộng](#2-kiến-thức-mở-rộng)
  - [2.1. Chủ đề nâng cao 1](#21-chủ-đề-nâng-cao-1)
  - [2.2. Chủ đề nâng cao 2](#22-chủ-đề-nâng-cao-2)
- [3. Tổng kết](#3-tổng-kết)

---

## 1. Kiến Thức Cơ Bản

### 1.1. Kiểu dữ liệu
Các kiểu dữ liệu là nền tảng trong lập trình. Chúng xác định loại giá trị mà một biến có thể chứa.
Trong Python, các kiểu dữ liệu cơ bản được sử dụng để lưu trữ số, văn bản và giá trị logic.

| **Kiểu Dữ liệu** | **Mô tả** | **Ví dụ** |
|------------------|-----------|-----------|
| `Integer` | Số nguyên | `1`, `-5`, `100` |
| `Float` | Số thập phân | `3.14`, `-0.01` |
| `String` | Chuỗi ký tự | `"Xin chào"`, `'Python'` |
| `Boolean` | Giá trị logic: đúng hoặc sai | `True`, `False` |

### 1.2. Danh sách trong Python
- **Danh sách** là một tập hợp được sử dụng để lưu trữ nhiều mục trong một biến duy nhất.
- Có thể chứa các phần tử thuộc bất kỳ kiểu dữ liệu nào
- Các phần tử được **sắp xếp và có thể thay đổi**

**Cú pháp:**
```python
tên_danh_sách = [phần_tử1, phần_tử2, ..., phần_tửN]
```
**Ví dụ:**
```python
# Tạo danh sách trái cây
fruits = ["apple", "banana", "cherry"]
print(fruits[0])  # Output: apple
```

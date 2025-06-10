# Recap Kiến Thức Tuần [X] - [Tháng/Ngày]

🔖 **Mục lục nhanh**:
- [1. Kiến thức cơ bản](#1-kiến-thức-cơ-bản)
  - [1.1. Kiểu dữ liệu](#11-kiểu-dữ-liệu)
  - [1.2. Danh sách trong Python](#12-danh-trong-python)
  - [1.3. Từ điển trong python](#13-từ-điển-trong-python)
  - [1.4. Hàm trong python](#14-hàm-trong-python)
  - [1.5. Rẽ nhánh trong python](#15-rẽ-nhánh-trong-python)
- [2. Kiến thức mở rộng](#2-kiến-thức-mở-rộng)
  - [2.1. Chủ đề nâng cao 1](#21-chủ-đề-nâng-cao-1)
  - [2.2. Chủ đề nâng cao 2](#22-chủ-đề-nâng-cao-2)
- [3. Tổng kết](#3-tổng-kết)

---

## 1. Kiến Thức Cơ Bản

### 1.1. Kiểu dữ liệu
- Các kiểu dữ liệu là nền tảng trong lập trình. Chúng xác định loại giá trị mà một biến có thể chứa.
- Trong Python, các kiểu dữ liệu cơ bản được sử dụng để lưu trữ số, văn bản và giá trị logic.

| **Kiểu Dữ liệu** | **Mô tả** | **Ví dụ** |
|------------------|-----------|-----------|
| `Integer` | Số nguyên | `1`, `-5`, `100` |
| `Float` | Số thập phân | `3.14`, `-0.01` |
| `String` | Chuỗi ký tự | `"Xin chào"`, `'Python'` |
| `Boolean` | Giá trị logic: đúng hoặc sai | `True`, `False` |

### 1.2. Danh sách trong Python
- **Danh sách (list)** là một tập hợp được sử dụng để lưu trữ nhiều mục trong một biến duy nhất.
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
### 1.3. Từ điển trong Python
- **Từ điển (dictionary)** là một tập hợp các cặp khóa-giá trị.
- Mỗi mục trong từ điển có một khóa và một giá trị, và khóa được sử dụng để truy cập giá trị.
- Từ điển là không có thứ tự, có thể thay đổi, và không cho phép các khóa trùng lặp.

**Cú pháp:**
```python
tên_từ_điển = {khóa1: giá_trị1, khóa2: giá_trị2, ..., khóaN: giá_trịN}
```
**Ví dụ:**
```python
# Tạo từ điển chứa thông tin học sinh
student = {
    "name": "Alice",
    "age": 20,
    "major": "Computer Science"
}

# Truy cập giá trị bằng khóa (key)
print(student["name"])  # Output: Alice
```
### 1.4. Hàm trong python
- **Hàm (function)** là một khối mã có thể tái sử dụng để thực hiện một nhiệm vụ cụ thể.
- Hàm giúp code của bạn được tổ chức, dễ đọc và tránh lặp lại.

**Cú pháp:**
```python
def tên_hàm(tham_số1, tham_số2, ..., tham_sốN):
    # Khối mã thực thi
    return giá_trị  # Tùy chọn
```

**Ví dụ:**
```python
# Định nghĩa 1 hàm đơn giản
def greet():
    print("Hello!")

# Gọi lại hàm để thực thi
greet()  # Output: Hello!
```

Hàm cũng có thể nhận **tham số (parameters)** và **trả về (return)** giá trị bằng từ khóa return:
# Hàm với tham số và giá trị trả về
```python
def sum(a, b):
    return a + b

result = sum(3, 5)
print(result)  # Output: 8
```
### 1.5. Rẽ nhánh trong python
- Rẽ nhánh cho phép chương trình đưa ra quyết định dựa trên các điều kiện.
- Điều này thường được thực hiện bằng các câu lệnh **if**, **elif**, và **else**.
#### 1.5.1. Toán tử so sánh
Toán tử so sánh được sử dụng để so sánh hai giá trị. Trả về giá trị Boolean: True hoặc False

| **Toán tử** | **Mô tả** |
|-------------|---------------|
| `==` | Bằng |
| `!=` | Không bằng |
| `>`  | Lớn hơn |
| `<`  | Nhỏ hơn |
| `>=` | Lớn hơn hoặc bằng |
| `<=` | Nhỏ hơn hoặc bằng |

#### 1.5.2. Sử dụng câu lệnh if
Câu lệnh if cho phép bạn thực thi mã chỉ khi một điều kiện nào đó là **True**.
```python
age = 18
if age >= 18:
    print("You are an adult.")
```
#### 1.5.3. Sử dụng câu lệnh if-else
Bạn có thể sử dụng else để định nghĩa một khối mã thay thế khi điều kiện không được đáp ứng.
```python
age = 16
if age >= 18: #False
    print("You are an adult.")
else:
    print("You are a minor.")
```

#### 1.5.4. Sử dụng câu lệnh elif
Sử dụng elif (else if) để kiểm tra nhiều điều kiện.
```python
score = 75
if score >= 90:
    print("Grade A")
elif score >= 80:
    print("Grade B")
elif score >= 70:
    print("Grade C")
else:
    print("Grade D or lower")
```


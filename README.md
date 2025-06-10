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
### 1.6. Vòng lặp trong python
#### Đặt vấn đề
Ví dụ, chúng ta được giao nhiệm vụ in dòng chữ "Hello World!" 5 lần. Ta có thể viết:

```python
print("Hello World!")
print("Hello World!")
print("Hello World!")
print("Hello World!")
print("Hello World!")
```

Nhưng nếu phải in 1000 hay 100000 lần thì sao? Việc copy-paste như trên không còn hiệu quả. Giải pháp tối ưu là **sử dụng vòng lặp** để thực hiện thao tác lặp lại một cách hiệu quả hơn.
---

### Định nghĩa vòng lặp

**Vòng lặp** cho phép chúng ta **lặp lại một khối mã** dựa trên một điều kiện hoặc dựa trên các phần tử của một tập hợp.

---
#### 1.6.1. Vòng lặp for
Vòng lặp `for` được dùng để lặp qua các phần tử của một **đối tượng lặp** (`iterable`) như chuỗi (string), danh sách (list), tuple, dictionary, v.v.

<div class="row mt-3">
    <div class="col-full mt-3 mt-md-0">
        {% include figure.liquid loading="eager" path="assets/img/Blog/Week1/ForLoop.png" class="img-fluid rounded z-depth-1" %}
    </div>
</div>
<div class="caption">
    Hình n: Cú pháp và luồng thực thi của vòng lặp `for`.
</div>

### Cú pháp

```python
# code trước for
for i in iterable:
    # khối mã cần thực thi
# code sau for
```

* `for`, `in`: là các **từ khóa (keywords)** của Python.
* `:` (dấu hai chấm): **bắt buộc** sau phần điều kiện của vòng lặp.
* **Thụt lề (indentation)**: xác định khối mã thuộc vòng lặp.

### Luồng thực thi

1. **Code trước for** (nếu có) được thực thi đầu tiên.
2. Mỗi lần lặp:

   * Gán phần tử hiện tại cho biến lặp `i`.
   * Thực thi **code bên trong vòng lặp**.
3. Sau khi kết thúc, **code sau for** (nếu có) sẽ được thực thi.

### Sử dụng `range()`

`range(n)` tạo ra một dãy số từ `0` đến `n - 1`. Ví dụ:

```python
for i in range(5):
    print(i)
```

Kết quả:

```
0
1
2
3
4
```

---
#### 1.6.2. Vòng lặp while
Vòng lặp `while` lặp lại **miễn là điều kiện vẫn đúng (`True`)**.

<div class="row mt-3">
    <div class="col-full mt-3 mt-md-0">
        {% include figure.liquid loading="eager" path="assets/img/Blog/Week1/WhileLoop.png" class="img-fluid rounded z-depth-1" %}
    </div>
</div>
<div class="caption">
    Hình n: Cú pháp và luồng thực thi của vòng lặp `while`.
</div>

### Cú pháp

```python
# code trước while
while condition:
    # khối mã cần thực thi
# code sau while
```

### Luồng thực thi

1. **Code trước while** được thực thi trước (nếu có).
2. Trong mỗi lần lặp:

   * Nếu điều kiện đúng, **code trong while** được chạy.
   * Sau đó kiểm tra lại điều kiện.
3. Khi điều kiện trở thành **False**, vòng lặp kết thúc và **code sau while** (nếu có) sẽ được thực thi.

### Ví dụ

```python
i = 0
while i < 5:
    print(i)
    i += 1
print("done")
```

Kết quả:

```
0
1
2
3
4
done
```

---

## `break` và `continue` trong vòng lặp

### `break`

`break` được dùng để **thoát hoàn toàn khỏi vòng lặp**, ngay cả khi điều kiện hoặc danh sách chưa kết thúc.

#### Ví dụ

Tìm vị trí đầu tiên của phần tử có giá trị là 5:

```python
numbers = [1, 3, 5, 7, 5, 9]
for i in range(len(numbers)):
    if numbers[i] == 5:
        print(f"Found 5 at index {i}")
        break
```

**Giải thích:** Khi tìm thấy phần tử đầu tiên bằng 5, vòng lặp dừng ngay lập tức nhờ `break`.

---

### `continue`

`continue` được dùng để **bỏ qua phần còn lại của khối mã trong lần lặp hiện tại** và **chuyển sang lần lặp tiếp theo**.

#### Ví dụ

In các số từ 1 đến 10, **bỏ qua các số chẵn**, dùng `while`:

```python
i = 0
while i < 10:
    i += 1
    if i % 2 == 0:
        continue
    print(i)
```

**Giải thích:** Khi gặp số chẵn, `continue` khiến vòng lặp bỏ qua lệnh `print(i)` và quay lại đầu vòng lặp.

Kết quả:

```
1
3
5
7
9
```

---



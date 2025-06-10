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
#### Hàm với tham số và giá trị trả về
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

## 2. Kiến Thức Mở Rộng
### 2.1 SQL
#### Database là gì?
Hãy tưởng tượng một database như một thư viện khổng lồ được tổ chức cực kỳ khoa học. Thay vì sách, chúng ta có dữ liệu. Và thay vì kệ sách, chúng ta có các **bảng (tables)**. Mỗi bảng chứa một loại thông tin cụ thể, ví dụ: một bảng lưu trữ thông tin khách hàng, một bảng khác lưu trữ thông tin sản phẩm, và một bảng nữa là lịch sử đơn hàng.

Trong mỗi bảng, dữ liệu được sắp xếp theo **hàng (rows)** và **cột (columns)**. Mỗi hàng là một bản ghi duy nhất (ví dụ: thông tin của một khách hàng cụ thể), và mỗi cột là một thuộc tính của bản ghi đó (ví dụ: tên, địa chỉ, số điện thoại của khách hàng).

Hầu hết các database mà chúng ta làm việc ngày nay là **cơ sở dữ liệu quan hệ (relational databases)**. Điều này có nghĩa là các bảng có thể được liên kết với nhau thông qua các mối quan hệ logic, giúp chúng ta dễ dàng kết hợp thông tin từ nhiều nguồn khác nhau.

---

#### SQL: Ngôn ngữ giao tiếp với dữ Liệu

SQL là ngôn ngữ tiêu chuẩn để giao tiếp với cơ sở dữ liệu quan hệ, chuyên biệt cho các tác vụ như:

* **Truy vấn dữ liệu:** Lấy thông tin.
* **Thao tác dữ liệu:** Thêm, sửa, xóa dữ liệu.
* **Định nghĩa dữ liệu:** Xây dựng cấu trúc database.

SQL được sử dụng rộng rãi nhờ tính hiệu quả và khả năng tương thích với nhiều hệ quản trị cơ sở dữ liệu (MySQL, PostgreSQL, SQL Server, Oracle...).

---

#### SQL trong phân tích dữ liệu

Dựa trên các kỹ năng cần thiết cho Data Analysis, SQL được chia thành 4 cấp độ chính:

##### 2.1.1. Basics (Cơ bản)

Đây là những câu lệnh nền tảng để trích xuất và sắp xếp dữ liệu.

* **`SELECT`**: Chọn cột dữ liệu.
    ```sql
    SELECT customer_name, email
    FROM customers;
    ```
* **`FROM`**: Chỉ định bảng nguồn.
    ```sql
    SELECT *
    FROM products;
    ```
* **`WHERE`**: Lọc hàng theo điều kiện.
    ```sql
    SELECT product_name, price
    FROM products
    WHERE price > 50;
    ```
* **`GROUP BY`**: Nhóm các hàng để tổng hợp.
    ```sql
    SELECT category, COUNT(product_id) AS num_products
    FROM products
    GROUP BY category;
    ```
* **`ORDER BY`**: Sắp xếp kết quả.
    ```sql
    SELECT customer_name, total_orders
    FROM customers
    ORDER BY total_orders DESC;
    ```
* **`HAVING`**: Lọc các nhóm đã được tổng hợp.
    ```sql
    SELECT category, AVG(price) AS avg_price
    FROM products
    GROUP BY category
    HAVING AVG(price) > 100;
    ```

##### 2.1.2. Intermediate (Trung cấp)

Nâng cao khả năng lọc và xử lý dữ liệu với các toán tử và hàm.

* **`BETWEEN`**: Lọc giá trị trong phạm vi.
    ```sql
    SELECT order_id, order_date
    FROM orders
    WHERE order_date BETWEEN '2025-01-01' AND '2025-01-31';
    ```
* **`LIKE`**: Tìm kiếm mẫu chuỗi.
    ```sql
    SELECT customer_name, email
    FROM customers
    WHERE customer_name LIKE 'Nguyen%';
    ```
* **`NULL`**: Kiểm tra giá trị rỗng.
    ```sql
    SELECT product_name
    FROM products
    WHERE description IS NULL;
    ```
* **`IN`**: Kiểm tra giá trị trong danh sách.
    ```sql
    SELECT product_name, category
    FROM products
    WHERE category IN ('Electronics', 'Books');
    ```
* **`OFFSET` / `LIMIT`**: Phân trang kết quả.
    ```sql
    SELECT customer_name
    FROM customers
    ORDER BY customer_id
    LIMIT 10 OFFSET 20;
    ```
* **`COALESCE`**: Trả về giá trị không `NULL` đầu tiên.
    ```sql
    SELECT product_name, COALESCE(description, 'No description available') AS product_description
    FROM products;
    ```

##### 2.1.3. Joins (Kết Nối Bảng)

Kỹ năng thiết yếu để kết hợp dữ liệu từ nhiều bảng.

* **`INNER JOIN`**: Trả về hàng trùng khớp ở cả hai bảng.
    ```sql
    SELECT o.order_id, c.customer_name
    FROM orders o
    INNER JOIN customers c ON o.customer_id = c.customer_id;
    ```
* **`LEFT JOIN`**: Trả về tất cả hàng từ bảng trái và các hàng trùng khớp từ bảng phải.
    ```sql
    SELECT c.customer_name, o.order_id
    FROM customers c
    LEFT JOIN orders o ON c.customer_id = o.customer_id;
    ```
* **`RIGHT JOIN`**: Tương tự `LEFT JOIN`, ưu tiên bảng phải.
    ```sql
    SELECT p.product_name, oi.quantity
    FROM order_items oi
    RIGHT JOIN products p ON oi.product_id = p.product_id;
    ```
* **`SELF JOIN`**: Kết nối một bảng với chính nó.
    ```sql
    SELECT e1.employee_name AS employee, e2.employee_name AS manager
    FROM employees e1
    JOIN employees e2 ON e1.manager_id = e2.employee_id;
    ```

##### 2.1.4. Advanced (Nâng cao)

Các kỹ thuật mạnh mẽ cho phân tích dữ liệu phức tạp.

* **`WINDOW FUNCTIONS`**: Thực hiện tính toán trên một tập hợp con các hàng liên quan.
    ```sql
    SELECT
        order_id,
        total_amount,
        AVG(total_amount) OVER (PARTITION BY DATE_TRUNC('month', order_date)) AS monthly_avg_amount
    FROM
        orders;
    ```
* **`RANK()` / `DENSE_RANK()` / `ROW_NUMBER()`**: Xếp hạng các hàng.
    ```sql
    SELECT
        product_name,
        category,
        price,
        RANK() OVER (PARTITION BY category ORDER BY price DESC) AS price_rank_in_category
    FROM
        products;
    ```
* **`PIVOT`**: Chuyển đổi hàng thành cột để tổng hợp. (Cú pháp tùy DBMS)
    ```sql
    SELECT
        ProductName,
        [2023] AS Sales_2023, 
        [2024] AS Sales_2024  
    FROM
        (
            SELECT
                p.ProductName,
                YEAR(s.SaleDate) AS SaleYear,
                s.Quantity AS SoldQuantity
            FROM
                Products p
            JOIN
                Sales s ON p.ProductID = s.ProductID
            WHERE
                YEAR(s.SaleDate) IN (2023, 2024) 
        ) AS SourceData
    PIVOT
    (
        SUM(SoldQuantity) 
        FOR SaleYear IN ([2023], [2024])
    ) AS PivotedSalesByYear;
    ```
* **`CTE` (Common Table Expressions)**: Định nghĩa các tập kết quả tạm thời để dễ đọc và quản lý.
    ```sql
    WITH MonthlySales AS (
        SELECT
            DATE_TRUNC('month', order_date) AS sales_month,
            SUM(quantity * price) AS total_monthly_sales
        FROM
            orders
        GROUP BY
            sales_month
    )
    SELECT
        sales_month,
        total_monthly_sales
    FROM
        MonthlySales
    WHERE
        total_monthly_sales > 10000;
    ```



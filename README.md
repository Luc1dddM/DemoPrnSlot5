# NumPy Recap - Xử lý dữ liệu đa chiều cho người mới bắt đầu

## 📚 Giới thiệu NumPy

NumPy (Numerical Python) là một thư viện Python mạnh mẽ dành cho tính toán khoa học. Nó cung cấp:

- **Mảng đa chiều hiệu quả**: Cấu trúc dữ liệu cơ bản cho machine learning
- **Tính toán vectorized**: Xử lý toàn bộ mảng cùng lúc thay vì từng phần tử
- **Tích hợp tốt**: Là nền tảng cho pandas, scikit-learn, TensorFlow...

### 🎯 Tại sao cần NumPy?

```python
# Cách Python thuần túy - chậm
python_list = [1, 2, 3, 4]
result = []
for i in python_list:
    result.append(i * 2)

# Cách NumPy - nhanh và ngắn gọn
import numpy as np
arr = np.array([1, 2, 3, 4])
result = arr * 2  # Tự động nhân tất cả phần tử
```

## 📊 Cấu trúc dữ liệu: Mảng đa chiều

### 1D Array (Mảng 1 chiều)
```python
# Giống như danh sách điểm số của một học sinh
scores = np.array([8, 9, 7, 10])
print(scores.shape)  # (4,) - 4 phần tử
```

### 2D Array (Mảng 2 chiều - Ma trận)
```python
# Giống như bảng điểm của cả lớp
class_scores = np.array([
    [8, 9, 7, 10],    # Học sinh 1
    [6, 8, 9, 7],     # Học sinh 2
    [9, 10, 8, 9]     # Học sinh 3
])
print(class_scores.shape)  # (3, 4) - 3 học sinh, 4 môn
```

### 3D Array (Mảng 3 chiều)
```python
# Giống như điểm của nhiều lớp trong nhiều học kỳ
school_scores = np.array([
    [[8, 9, 7], [6, 8, 9]],    # Học kỳ 1
    [[9, 8, 10], [7, 9, 8]]    # Học kỳ 2
])
print(school_scores.shape)  # (2, 2, 3) - 2 học kỳ, 2 lớp, 3 môn
```

## 🔧 Các hàm tạo mảng cơ bản

### Tạo mảng đặc biệt
```python
# Mảng toàn số 0 - hữu ích để khởi tạo
zeros_arr = np.zeros((3, 4))
print(zeros_arr)
# [[0. 0. 0. 0.]
#  [0. 0. 0. 0.]
#  [0. 0. 0. 0.]]

# Mảng toàn số 1 - hữu ích để tạo mask
ones_arr = np.ones((2, 3))
print(ones_arr)
# [[1. 1. 1.]
#  [1. 1. 1.]]

# Dãy số liên tiếp - giống range() nhưng mạnh hơn
sequence = np.arange(0, 10, 2)  # từ 0 đến 10, bước nhảy 2
print(sequence)  # [0 2 4 6 8]
```

### Reshape - Thay đổi hình dạng
```python
# Ví dụ: Chuyển dữ liệu 1D thành bảng 2D
data = np.arange(12)  # [0, 1, 2, ..., 11]
table = data.reshape(3, 4)  # Chuyển thành bảng 3x4
print(table)
# [[ 0  1  2  3]
#  [ 4  5  6  7]
#  [ 8  9 10 11]]

# Flatten - Chuyển về 1D
flat_data = table.flatten()
print(flat_data)  # [0 1 2 3 4 5 6 7 8 9 10 11]
```

## 🔍 Indexing và Slicing

### Slicing cơ bản
```python
# Ví dụ: Bảng điểm học sinh
grades = np.array([
    [8, 9, 7, 10],  # Toán, Lý, Hóa, Sinh
    [6, 8, 9, 7],
    [9, 10, 8, 9]
])

# Lấy điểm Toán của tất cả học sinh
math_scores = grades[:, 0]  # [8, 6, 9]

# Lấy điểm của học sinh đầu tiên
first_student = grades[0, :]  # [8, 9, 7, 10]

# Lấy điểm Lý và Hóa của 2 học sinh đầu
physics_chemistry = grades[0:2, 1:3]
# [[9, 7],
#  [8, 9]]
```

### Boolean Indexing
```python
# Tìm học sinh có điểm Toán >= 8
high_math_students = grades[grades[:, 0] >= 8]
print(high_math_students)

# Tìm tất cả điểm >= 9
excellent_grades = grades[grades >= 9]
print(excellent_grades)  # [9, 10, 9, 10, 9]
```

## 📈 Các phép toán thống kê

```python
# Dữ liệu doanh thu theo tháng của các cửa hàng
revenue = np.array([
    [100, 120, 110, 130],  # Cửa hàng 1
    [90, 100, 95, 105],    # Cửa hàng 2
    [110, 130, 125, 140]   # Cửa hàng 3
])

# Tổng doanh thu tất cả
total_revenue = np.sum(revenue)
print(f"Tổng doanh thu: {total_revenue}")

# Doanh thu trung bình theo tháng (axis=0)
monthly_avg = np.mean(revenue, axis=0)
print(f"Doanh thu TB theo tháng: {monthly_avg}")

# Doanh thu trung bình của từng cửa hàng (axis=1)
store_avg = np.mean(revenue, axis=1)
print(f"Doanh thu TB từng cửa hàng: {store_avg}")

# Cửa hàng có doanh thu cao nhất
best_store = np.argmax(np.sum(revenue, axis=1))
print(f"Cửa hàng tốt nhất: {best_store}")
```

## 🔄 Broadcasting - Phép toán thông minh

Broadcasting cho phép thực hiện phép toán giữa các mảng có kích thước khác nhau:

```python
# Ví dụ: Tăng lương cho nhân viên
salaries = np.array([
    [3000, 3500, 4000],  # Phòng A
    [2800, 3200, 3800],  # Phòng B
    [3200, 3600, 4200]   # Phòng C
])

# Tăng lương đồng loạt 500k cho tất cả
new_salaries = salaries + 500
print("Lương sau khi tăng:")
print(new_salaries)

# Tăng lương theo % khác nhau cho từng phòng
bonus_rate = np.array([0.1, 0.15, 0.12])  # 10%, 15%, 12%
bonus_salaries = salaries * (1 + bonus_rate.reshape(-1, 1))
print("Lương sau khi tăng theo %:")
print(bonus_salaries)
```

## 🖼️ Ứng dụng vào Machine Learning/Deep Learning
### 1. Softmax Function
```python
def softmax(x):
    """
    Chuyển đổi điểm số thành xác suất
    Ví dụ: [2, 1, 0] -> [0.67, 0.24, 0.09]
    """
    # Trừ max để tránh overflow
    x_stable = x - np.max(x)
    exp_x = np.exp(x_stable)
    return exp_x / np.sum(exp_x)
```

### 2. Tạo dữ liệu ngẫu nhiên
```python
# Seed để reproducible
np.random.seed(42)

# Dữ liệu phân phối chuẩn
normal_data = np.random.randn(1000)  # mean=0, std=1

# Dữ liệu uniform
uniform_data = np.random.uniform(0, 1, 1000)

# Chọn ngẫu nhiên
choices = np.random.choice(['A', 'B', 'C'], size=100, p=[0.5, 0.3, 0.2])
```

### 3.  Tiền xử lý ảnh (image preprocessing) trước khi huấn luyện mô hình bằng pytorch
> Pytorch yêu cầu định dạng ảnh là CHW (Channels, Height, Width) vì vậy cần chuyển đổi kênh màu.
```python
# Hàm chuẩn hóa ảnh
def transform(img, img_size=(224, 224)):
    img = img.resize(img_size)
    img = np.array(img)[..., :3]  # Đảm bảo lấy 3 kênh RGB
    img = torch.tensor(img).permute(2, 0, 1).float()  # Đổi thành (C, H, W)
    normalized_img = img / 255.0  # Chuẩn hóa về [0, 1]

    return normalized_img

# Định nghĩa bộ dataset
class CIFARDataset(Dataset):
    def __init__(
        self,
        X, y,
        transform=None
    ):
        self.transform = transform
        self.img_paths = X
        self.labels = y

    def __len__(self):
        return len(self.img_paths)

    def __getitem__(self, idx):
        img_path = self.img_paths[idx]
        img = Image.open(img_path).convert("RGB")

        if self.transform:
            img = self.transform(img) # Áp dụng hàm chuẩn hóa vào bộ dataset

        return img, self.labels[idx]
```
## 🚀 Lời khuyên cho người mới bắt đầu

1. **Luôn kiểm tra shape**: `print(arr.shape)` trước khi thực hiện phép toán
2. **Sử dụng axis**: Hiểu rõ axis=0 (theo hàng) và axis=1 (theo cột)
3. **Vectorization**: Tránh vòng lặp, dùng phép toán trên toàn mảng
4. **Broadcasting**: Tận dụng để viết code ngắn gọn
5. **Copy vs View**: Cẩn thận với `.copy()` và slicing

## 🎓 Tổng kết

NumPy là nền tảng của data science và machine learning trong Python. Với các khái niệm cơ bản như:

- **Mảng đa chiều**: Cấu trúc dữ liệu linh hoạt
- **Indexing/Slicing**: Truy cập dữ liệu hiệu quả
- **Broadcasting**: Phép toán thông minh
- **Vectorization**: Tính toán nhanh chóng

Bạn đã có đủ kiến thức để bắt đầu các dự án data science thực tế!

---

*Happy coding! 🐍✨*

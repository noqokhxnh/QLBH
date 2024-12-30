# QuanLyBanHangOnline

## Hướng dẫn sử dụng

1. Tải GIT bằng` https://git-scm.com/downloads` 

2. Mở CMD
3. Nhập ``[git clone git@github.com:noqokhxnh/QLBH.git](https://github.com/noqokhxnh/QLBH.git)``


4. Khôi phục dữ liệu


Bước 1: Mở SQL Server  chọn File > Open > File…

![1](https://github.com/user-attachments/assets/22205684-4d3b-4f21-b7ec-f21b8686743d)



Bước 2: Chọn file script.sql để mở trong SQL Server

![image](https://github.com/user-attachments/assets/db073bba-d5b5-4346-8dfa-e4efa4aa4279)

Chọn file .sql đã lưu về trước đó

Bước 3: Chúng ta cần tạo 1 Database giống với tên của Database cũ để chứa dữ liệu sắp nhập vào.

VD: Trong trường hợp này chúng ta phải tạo Database tên `QuanLyBanHang`
![image](https://github.com/user-attachments/assets/f7e808d1-3673-48af-b1fd-ef5ddf22f13f)



Đặt tên cho Database

Bước 4: Chọn tất cả câu lệnh và nhấn Execute. Kết quả thành công sẽ hiện thông báo: Command(s) completed successfully. Mở Datbase `QuanLyBanHang` ra sẽ thấy tất cả các bảng và dữ liệu chúng ta cần.

![image](https://github.com/user-attachments/assets/905291cf-03f1-4f03-a41a-bbc69eb70481)


Chạy lệnh để hoàn tất quá trình khôi phục

5. Mở dự án trong Visual Studio.
6. Cập nhật chuỗi kết nối trong mã nguồn nếu cần:
   - Mở `.env` và thay đổi chuỗi kết nối:
     ```env
     DB_SERVER=LAPTOP-B6DMUJM1 thành tên SQL của bạn
     ```
7. Chạy ứng dụng và đăng nhập bằng tài khoản mẫu:
   - ADMIN: admin, 123
   - USER: user, 123


	

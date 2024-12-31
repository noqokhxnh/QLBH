# QuanLyBanHangOnline

## Hướng dẫn sử dụng

1. Cài đặt Git
Tải Git tại `https://git-scm.com/downloads` và cài đặt.
2. Clone mã nguồn
	Mở CMD hoặc Terminal, sau đó nhập:
`
git clone https://github.com/noqokhxnh/QLBH.git
cd QLBH
`


3. Khôi phục dữ liệu SQL


Bước 1: Mở SQL Server  chọn File > Open > File…

![1](https://github.com/user-attachments/assets/22205684-4d3b-4f21-b7ec-f21b8686743d)



Bước 2: Chọn file script.sql để mở trong SQL Server

![image](https://github.com/user-attachments/assets/db073bba-d5b5-4346-8dfa-e4efa4aa4279)

Chọn file .sql đã lưu về trước đó

Bước 3: Chúng ta cần tạo 1 Database giống với tên của Database cũ để chứa dữ liệu sắp nhập vào.

VD: Trong trường hợp này chúng ta phải tạo Database tên `QuanLyBanHang`
![image](https://github.com/user-attachments/assets/f7e808d1-3673-48af-b1fd-ef5ddf22f13f)





Bước 4: Chọn tất cả câu lệnh và nhấn Execute. Kết quả thành công sẽ hiện thông báo: Command(s) completed successfully. Mở Datbase `QuanLyBanHang` ra sẽ thấy tất cả các bảng và dữ liệu chúng ta cần.

![image](https://github.com/user-attachments/assets/905291cf-03f1-4f03-a41a-bbc69eb70481)


Chạy lệnh để hoàn tất quá trình khôi phục

4. Mở dự án trong Visual Studio.
5. Cập nhật chuỗi kết nối trong mã nguồn nếu cần:
   - Mở `.env` và thay đổi chuỗi kết nối:
     ```env
     DB_SERVER=LAPTOP-B6DMUJM1 thành tên SQL của bạn
     ```
6. Chạy ứng dụng và đăng nhập bằng tài khoản mẫu:
   - ADMIN: admin, 123
   - USER: user, 123

7. Xử Lí Lỗi
	![image](https://github.com/user-attachments/assets/fdd52e0d-e720-42df-af76-0c4b86eec454)

	`
dotnet add package dotenv.net
`

8. Hỗ trợ
    Nếu vẫn gặp lỗi hoặc cần trợ giúp, hãy cầu trời khấn phật vì thằng code không biết fix

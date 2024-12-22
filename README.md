# QuanLyBanHangOnline

## Hướng dẫn sử dụng

1. Clone dự án về máy của bạn.
2. Phục hồi cơ sở dữ liệu `QuanLyBanHang` từ file sao lưu `QuanLyBanHang.bak`.
	   Link cách để phục hồi ở đây :
    https://stackoverflow.com/questions/20837673/how-to-import-a-bak-file-into-sql-server-express

4. Mở dự án trong Visual Studio.
5. Cập nhật chuỗi kết nối trong mã nguồn nếu cần:
   - Mở `frmLogin.cs` và thay đổi chuỗi kết nối:
     ```csharp
     string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuanLyBanHang;Integrated Security=True;";
     ```
6. Chạy ứng dụng và đăng nhập bằng tài khoản mẫu:
   - ADMIN: admin, 123
   - USER: user, 123


	

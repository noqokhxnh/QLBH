# QuanLyBanHangOnline

## Hướng dẫn sử dụng

1. Clone dự án về máy của bạn.
2. Phục hồi cơ sở dữ liệu `QuanLyBanHang` từ file sao lưu `QuanLyBanHang.bak`.




 Hướng dẫn phục hồi ở đây :
	
![OURYV](https://github.com/user-attachments/assets/549b7c03-600a-41bb-82b4-e178eb83b68a)



![FGOpz](https://github.com/user-attachments/assets/ed5f068e-9978-4873-a3d9-b6b6357ab67f)

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


	

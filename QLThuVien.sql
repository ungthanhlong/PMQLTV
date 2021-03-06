CREATE DATABASE QLThuVien
GO
USE QLThuVien
GO
CREATE TABLE DangNhap
(
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(100) NOT NULL,
	Type INT NOT NULL,
)
GO
CREATE TABLE NhanVien
(
	ID INT PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	NgaySinh DATE  NULL,
	GioiTinh NVARCHAR(10) NULL,
	DiaChi NVARCHAR(1000) NULL,
	CMND INT NULL,
	SDT TEXT NULL,
)
GO
CREATE TABLE DocGia
(
	ID INT PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	NgaySinh DATE NULL,
	GioiTinh NVARCHAR(10) NULL,
	DiaChi NVARCHAR(1000) NULL,
	CMND INT NULL,
	SDT TEXT NULL,
)
GO
CREATE TABLE Sach
(
	ID INT PRIMARY KEY,
	TenSach NVARCHAR(100) NOT NULL,
	TenTacGia NVARCHAR(100) NULL,
	NXB NVARCHAR(100) NULL,
)

GO
CREATE TABLE ViTri
(
	ID INT IDENTITY PRIMARY KEY,
	IDSach INT  NOT NULL,
	ViTri NVARCHAR(50)  NULL,
	SoLuong INT  NULL,
	FOREIGN KEY (IDSach) REFERENCES dbo.Sach(ID)
)
GO
CREATE TABLE Bill
(
	IDBill INT ,
	IDDocGia INT NULL,
	IDSach INT  NOT NULL,
	TenSach NVARCHAR(100) NOT NULL,
	SoLuong INT  NULL,
	NgayMuon DATE NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY (IDDocGia) REFERENCES dbo.DocGia(ID),
	FOREIGN KEY (IDSach) REFERENCES dbo.Sach(ID),
)
CREATE TABLE Temp
(
	ID int,
	IDSach int,
	IDDocGia int,
	TenSach NVARCHAR(100),
	SoLuong int,
	
	FOREIGN KEY (IDSach) REFERENCES dbo.Sach(ID),
	FOREIGN KEY (IDDocGia) REFERENCES dbo.DocGia(ID)
)
CREATE VIEW ThuVien
AS
	SELECT s.*,v.ViTri,v.SoLuong FROM dbo.Sach s,dbo.ViTri v
	WHERE s.ID = v.IDSach
GO


CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
CREATE PROC Tinh
(
	@ID int,
	@soluong int,
	@tensach NVARCHAR(100)
)
AS
BEGIN
	IF EXISTS ( SELECT IDSach FROM dbo.Bill WHERE IDSach = @ID)
		BEGIN
			UPDATE dbo.Bill SET SoLuong = SoLuong + 1 WHERE IDSach = @ID
		END
	ELSE
		BEGIN
			INSERT INTO dbo.Bill(IDSach,TenSach,SoLuong) VALUES (@ID,@tensach,@soluong)
		END
END
CREATE PROC UpdateDS
(
	@ID int
)
AS
	UPDATE dbo.ViTri SET SoLuong = SoLuong - 1 WHERE ID = @ID
GO
CREATE PROC UpdateTemp
(
	@ID int
)
AS
	UPDATE dbo.Temp SET SoLuong = SoLuong - 1 WHERE IDSach = @ID
GO
CREATE PROC B_UpdateDS
(
	@ID int
)
AS
BEGIN
	IF EXISTS ( SELECT IDSach FROM dbo.ViTri WHERE IDSach = @ID)
		BEGIN
			UPDATE dbo.ViTri SET SoLuong = SoLuong + 1 WHERE IDSach = @ID
		END
END
CREATE PROC ThemSach
(
	@ID int,
	@soluong int,
	@tensach NVARCHAR(100)
)
AS
BEGIN
	IF EXISTS ( SELECT IDSach FROM dbo.Temp WHERE IDSach = @ID)
		BEGIN
			UPDATE dbo.Temp SET SoLuong = SoLuong + 1 WHERE IDSach = @ID
		END
	ELSE
		BEGIN
			INSERT INTO dbo.Temp(IDSach,TenSach,SoLuong) VALUES (@ID,@tensach,@soluong)
		END
END
CREATE VIEW DSM
AS
	SELECT DISTINCT dg.ID,dg.HoTen,b.IDBill,b.NgayMuon  FROM dbo.DocGia dg,dbo.Bill b WHERE b.IDDocGia = dg.ID
GO
INSERT INTO dbo.NhanVien
(
	ID,
	HoTen,
	NgaySinh,
	GioiTinh,
	DiaChi,
	CMND,
	SDT
)
VALUES
(
	'1',
	N'Nguyễn Thị Nghĩa',
	'2/12/1998',
	N'Nữ',
	N'35 Trường Chinh,P3,Q.Tân Bình',
	'231256299',
	'01629235595' 
)
INSERT INTO dbo.NhanVien
(
	ID,
	HoTen,
	NgaySinh,
	GioiTinh,
	DiaChi,
	CMND,
	SDT
)
VALUES
(
	'2',
	N'Phan Văn Hải',
	'4/6/1998',
	N'Nam',
	N'65 Nguyễn Oanh,P17,Q.Gò Vấp',
	'162235548',
	'0165598894' 
)
INSERT INTO dbo.NhanVien
(
	ID,
	HoTen,
	NgaySinh,
	GioiTinh,
	DiaChi,
	CMND,
	SDT
)
VALUES
(
	'3',
	N'Phạm Công Tuấn',
	'6/11/1998',
	N'Nam',
	N'27 Lý Thường Kiệt,P11,Q.11',
	'265548874',
	'0982655487' 
)
INSERT INTO dbo.NhanVien
(
	ID,
	HoTen,
	NgaySinh,
	GioiTinh,
	DiaChi,
	CMND,
	SDT
)
VALUES
(
	'4',
	N'Nguyễn Văn Sĩ',
	'3/12/1998',
	N'Nam',
	N'99 Quang Trung,P8,Q.Gò Vấp',
	'165569987',
	'0126659987' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '1',
	 N'Trịnh Thế Chuyển',
	 '11/12/1998',
	 N'Nam',
	 N'43 Phan Văn Trị,P.3,Q.Gò Vấp',
	 '32665487',
	 '0985644124' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '2',
	 N'Bùi Thu Vân',
	 '06/11/1995',
	 N'Nữ',
	 N'20 Đoàn Văn Bơ,P.9,Quận 4',
	 '32467482',
	 '0931324124' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '3',
	 N'Nguyễn Hoàng Nam',
	 '02/22/1994',
	 N'Nam',
	 N'72 Lê Thánh Tôn,P.Bến Nghé,Quận 1',
	 '32995431',
	 '0913664198' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '4',
	 N'Nguyễn Khánh Tường',
	 '01/24/1996',
	 N'Nam',
	 N'64 Nguyễn Oanh,P.7,Q.Gò Vấp',
	 '32785231',
	 '0972327245' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '5',
	 N'Tô Thị Ánh Huyền',
	 '04/07/1989',
	 N'Nữ',
	 N'141 Xô Viết Nghệ Tĩnh,P.17,Q.Bình Thạnh',
	 '32865413',
	 '0916205584' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '6',
	 N'Nguyễn Đình Phương Vy',
	 '03/27/1999',
	 N'Nữ',
	 N'171 Đào Duy Từ,P.6,Quận 10',
	 '331821127',
	 '0911069916' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '7',
	 N'Phạm Thế Hiển',
	 '07/30/1991',
	 N'Nam',
	 N'81 Trần Bình Trọng,P.1,Quận 5',
	 '32450182',
	 '0973660128' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '8',
	 N'Phan Thế Hải Đăng',
	 '06/11/1994',
	 N'Nam',
	 N'37 Phạm Văn Đồng,P.3,Q.Gò Vấp',
	 '32901432',
	 '0932007118' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '9',
	 N'Ngô Tuấn Khải',
	 '10/22/1993',
	 N'Nam',
	 N'09 Hoa Sứ,P.7,Phú Nhuận',
	 '32736891',
	 '0912236573'
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '10',
	 N'Ủa Thanh Thanh',
	 '02/19/1997',
	 N'Nữ',
	 N'166 Lê Lợi,P.3,Q.Gò Vấp',
	 '33172016',
	 '0969781633' 
)
INSERT INTO dbo.DocGia 
( 
	ID,
	 HoTen,
	 NgaySinh,
	 GioiTinh,
	 DiaChi,
	 CMND,
	 SDT
 ) 
VALUES 
(
	 '11',
	 N'Tôn Nữ Uyển Nhi',
	 '09/23/1995',
	 N'Nữ',
	 N'566 Nguyễn Thái Sơn,P.5,Q.Gò Vấp',
	 '32610897',
	 '0937286729' 

) 
INSERT INTO dbo.Sach 
VALUES 
( 
	'1',
	 N'Trên Đường Băng',
	 N'Tony Buổi Sáng',
	 N'Nhà Xuất Bản Trẻ' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'2',
	 N'Đời Ngăn Đừng Ngủ Dài',
	 N'Robin Sharma',
	 N'Nhà Xuất Bản Trẻ' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'3',
	 N'Khéo Ăn Nói Sẽ Có Được Thiên Hạ',
	 N'Trác Nhã',
	 N'Nhà Xuất Bản Văn Học' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'4',
	 N'Dám Bị Ghét',
	 N'Koga Fumitake - Kishimi Ichiro',
	 N'Nhà Xuất Lao Động' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'5',
	 N'Những Ngày Thơ Ấu',
	 N'Nguyên Hồng',
	 N'Nhà Xuất Văn Hóa Thông Tin' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'6',
	 N'Nuôi Dạy Con Kiểu Nhật Bản',
	 N'Akehashi Dạii',
	 N'Nhà Xuất Bản Phụ Nữ' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'7',
	 N'Bảy Bước Tới Mùa Hè',
	 N'Nguyễn Nhật Ánh',
	 N'Nhà Xuất Bản Trẻ' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'8',
	 N'Thược Dược Đen',
	 N'James Ellroy',
	 N'Nhà Xuất Bản Văn Hóa Thông Tin' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'9',
	 N'Ai Che Lưng Cho Bạn',
	 N'Keith Ferrazzi',
	 N'Nhà Xuất Bản Trẻ' 
)
INSERT INTO dbo.Sach 
VALUES 
( 
	'10',
	 N'Người Của Giang Hồ',
	 N'Nguyễn Hồng Lam',
	 N'Nhà Xuất Bản Công An Nhân Dân' 
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	1,
	N'Kệ số 2',
	4
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	2,
	N'Kệ số 5',
	7
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	3,
	N'Kệ số 7',
	6
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	4,
	N'Kệ số 8',
	5
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	5,
	N'Kệ số 7',
	8
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	6,
	N'Kệ số 1',
	4
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	7,
	N'Kệ số 9',
	5
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	8,
	N'Kệ số 2',
	10
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	9,
	N'Kệ số 2',
	4
)
INSERT INTO dbo.ViTri
(
	IDSach,
	ViTri,
	SoLuong
)
VALUES
(
	10,
	N'Kệ số 8',
	9
)





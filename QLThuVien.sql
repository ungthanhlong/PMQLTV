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

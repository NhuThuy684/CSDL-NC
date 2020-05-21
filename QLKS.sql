USE master
GO

IF DB_ID('QL_Khach_san') IS NOT NULL
	DROP DATABASE QL_Khach_san
GO
CREATE DATABASE QL_Khach_san
GO
USE QL_Khach_san
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--tạo mã khách hàng tự động tăng
CREATE 
--alter
FUNCTION UF_AUTO_maKH()
RETURNS VARCHAR(9)
AS
BEGIN
	DECLARE @maKH VARCHAR(9)
	IF EXISTS (SELECT maKH
				FROM dbo.KhachHang
				WHERE maKH='KH0000000')
	BEGIN
		SELECT @maKH = MAX(RIGHT(maKH, 7))
		FROM dbo.KhachHang
		SELECT @maKH = CASE
			WHEN @maKH >= 0 and @maKH < 9 THEN 'KH000000' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
			WHEN @maKH >= 9 and @maKH < 99 THEN 'KH00000' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
			WHEN @maKH >= 99 and @maKH < 999 THEN 'KH0000' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
			WHEN @maKH >= 999 and @maKH < 9999 THEN 'KH000' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
			WHEN @maKH >= 9999 and @maKH < 99999 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
			WHEN @maKH >= 99999 and @maKH < 999999 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
			WHEN @maKH >= 999999 THEN 'KH' + CONVERT(CHAR, CONVERT(INT, @maKH) + 1)
		END
	END
	ELSE
		SET @maKH='KH0000000'
	RETURN @maKH
END
GO

CREATE TABLE KhachHang
(maKH VARCHAR(9) DEFAULT dbo.UF_AUTO_maKH(),
hoTen NVARCHAR(35) NOT NULL,
tenDangNhap VARCHAR(35) UNIQUE NOT NULL,
matKhau VARCHAR(15) NOT NULL,
soCMND VARCHAR(12) UNIQUE NOT NULL,
diaChi NVARCHAR(70) NOT NULL,
dienThoai VARCHAR(11) UNIQUE NOT NULL,
moTa NVARCHAR(100),
email VARCHAR(40) UNIQUE,
CONSTRAINT PK_KH PRIMARY KEY(maKH))
GO

CREATE TABLE NhanVien
(maNV INT IDENTITY(1,1),
hoTen NVARCHAR(35) NOT NULL,
tenDangNhap VARCHAR(35) UNIQUE NOT NULL,
matKhau VARCHAR(15) NOT NULL,
MaKS INT NOT NULL,
CONSTRAINT PK_NV PRIMARY KEY(maNV))
GO

CREATE TABLE KhachSan
(maKS INT IDENTITY(1,1),
tenKS NVARCHAR(50) NOT NULL,
soSao INTEGER NOT NULL CONSTRAINT CK_SoSao CHECK(soSao>=1 AND soSao<=5),
soNha VARCHAR(10) NOT NULL,
duong NVARCHAR(20) NOT NULL,
quan NVARCHAR(20) NOT NULL,
thanhPho NVARCHAR(20) NOT NULL,
giaTB INT CHECK (giaTB>=0),
moTa NVARCHAR(100),
CONSTRAINT PK_KS PRIMARY KEY(maKS))
GO

CREATE TABLE LoaiPhong
(maLoaiPhong INT IDENTITY(1,1),
tenLoaiPhong NVARCHAR(20) NOT NULL,
maKS INT NOT NULL,
donGia INTEGER NOT NULL CHECK (donGia>=0),
moTa NVARCHAR(300),
slTrong INTEGER CHECK(slTrong>=0),
CONSTRAINT PK_LP PRIMARY KEY (maLoaiPhong))
GO

CREATE TABLE Phong
(maPhong INT IDENTITY(1,1),
loaiPhong INT NOT NULL,
soPhong VARCHAR(4) NOT NULL,
CONSTRAINT PK_P PRIMARY KEY (maPhong))
GO

CREATE TABLE TrangThaiPhong
(maPhong INT,
ngay DATETIME,--de datetime thay vi date de lay gio neu can
tinhTrang NVARCHAR(12) NOT NULL CONSTRAINT CK_TTTTP CHECK(tinhTrang IN(N'Đang sử dụng', N'Đang bảo trì', N'Còn trống')),
CONSTRAINT PK_TTP PRIMARY KEY (maPhong, ngay))
GO

CREATE TABLE DatPhong
(maDP INT IDENTITY(1,1),
maLoaiPhong INT NOT NULL,
maKH VARCHAR(9) NOT NULL,
ngayBatDau DATETIME NOT NULL,
ngayTraPhong DATETIME NOT NULL,
ngayDat DATETIME NOT NULL,
donGia INTEGER NOT NULL CHECK (donGia>=0),
moTa NVARCHAR(100),
tinhTrang NVARCHAR(13) NOT NULL CONSTRAINT CK_TTDP CHECK(tinhTrang IN(N'Đã xác nhận', N'Chưa xác nhận')),
maPhong INT,
CONSTRAINT CK_NgayBD CHECK (ngayBatDau<=ngayTraPhong),
CONSTRAINT CK_NgayDat CHECK (ngayDat<=ngayBatDau),
CONSTRAINT PK_DP PRIMARY KEY (maDP))
GO

--tạo mã hóa đơn tự động tăng
CREATE --alter
FUNCTION UF_AUTO_maHD()
RETURNS VARCHAR(11)
AS
BEGIN
	DECLARE @maHD VARCHAR(11)
	DECLARE @temp VARCHAR(6)
	SET @temp = CONVERT(varchar,GETDATE(),12)
	IF(SELECT COUNT(*)
		FROM dbo.HoaDon
		WHERE maHD LIKE @temp +'%')=0
		SET @maHD = @temp + '00000'
	ELSE
		BEGIN
		SELECT @maHD = MAX(RIGHT(maHD, 5))
		FROM dbo.HoaDon
		WHERE maHD LIKE @temp + '%'
		SELECT @maHD = CASE
			WHEN @maHD = NULL THEN @temp + '00000'
			WHEN @maHD >= 0 and @maHD < 9 THEN @temp + '0000' + CONVERT(CHAR, CONVERT(INT, @maHD) + 1)
			WHEN @maHD >= 9 and @maHD < 99 THEN @temp + '000' + CONVERT(CHAR, CONVERT(INT, @maHD) + 1)
			WHEN @maHD >= 99 and @maHD < 999 THEN @temp + '00' + CONVERT(CHAR, CONVERT(INT, @maHD) + 1)
			WHEN @maHD >= 999 and @maHD < 9999 THEN @temp + '0' + CONVERT(CHAR, CONVERT(INT, @maHD) + 1)
			WHEN @maHD >= 9999 THEN @temp + CONVERT(CHAR, CONVERT(INT, @maHD) + 1)
		END
	END
	RETURN @maHD
END
GO

CREATE TABLE HoaDon
(maHD VARCHAR(11) DEFAULT dbo.UF_AUTO_maHD(),--18102400567 (hóa đơn lập ngày 24 tháng 10, 2018)
ngayThanhToan DATETIME NOT NULL,
tongTien INT NOT NULL,
maDP INT UNIQUE NOT NULL,
maKS INT NOT NULL,
CONSTRAINT PK_HD PRIMARY KEY (maHD))
GO

ALTER TABLE dbo.Phong
ADD
	CONSTRAINT FK_P_LP
	FOREIGN KEY (loaiPhong)
	REFERENCES dbo.LoaiPhong
GO

ALTER TABLE dbo.TrangThaiPhong
ADD
	CONSTRAINT FK_TTP_P
	FOREIGN KEY (maPhong)
	REFERENCES dbo.Phong
GO

ALTER TABLE dbo.DatPhong
ADD
	CONSTRAINT FK_DP_LP
	FOREIGN KEY (maLoaiPhong)
	REFERENCES dbo.LoaiPhong
GO

ALTER TABLE dbo.DatPhong
ADD
	CONSTRAINT FK_DP_KH
	FOREIGN KEY (maKH)
	REFERENCES dbo.KhachHang
GO

ALTER TABLE dbo.DatPhong
ADD
	CONSTRAINT FK_DP_P
	FOREIGN KEY (maPhong)
	REFERENCES dbo.Phong
GO

ALTER TABLE dbo.HoaDon
ADD
	CONSTRAINT FK_HD_KS
	FOREIGN KEY (maKS)
	REFERENCES dbo.KhachSan
GO

ALTER TABLE dbo.HoaDon
ADD
	CONSTRAINT FK_HD_DP
	FOREIGN KEY (maDP)
	REFERENCES dbo.DatPhong
GO

ALTER TABLE dbo.NhanVien
ADD
	CONSTRAINT FK_NV_KS
	FOREIGN KEY (MaKS)
	REFERENCES dbo.KhachSan
GO

ALTER TABLE dbo.LoaiPhong
ADD
	CONSTRAINT FK_LP_KS
	FOREIGN KEY (maKS)
	REFERENCES dbo.KhachSan
GO


CREATE TRIGGER UTR_HD_IUngayThanhToan
ON dbo.HoaDon
FOR INSERT, UPDATE
AS
BEGIN
	IF UPDATE(ngayThanhToan)
		IF EXISTS (SELECT *
					FROM dbo.DatPhong DP, Inserted I
					WHERE DP.maDP=I.maDP
					AND (I.ngayThanhToan<=DP.ngayTraPhong
						OR I.ngayThanhToan>=DP.ngayDat))
		BEGIN
			RAISERROR('Error: ngayThanhToan',16,1)
			ROLLBACK
		END
END
GO

CREATE TRIGGER UTR_HD_maDP_TinhTrang
ON dbo.HoaDon
FOR INSERT, UPDATE
AS
BEGIN
	IF UPDATE(maDP)
		IF EXISTS(SELECT*
					FROM dbo.DatPhong DP, Inserted I
					WHERE DP.maDP=I.maDP
					AND DP.tinhTrang=N'chưa xác nhận')
		BEGIN
			RAISERROR('Error: Tinh trang dat phong',16,1)
			ROLLBACK
		END
END
GO


--CÂU 1: ĐĂNG KÝ TÀI KHOẢN KHÁCH HÀNG
CREATE 
--alter
PROC USP_DangKy_TaiKhoan_KhachHang
	@hoTen NVARCHAR(35),
	@tenDangNhap VARCHAR(35),
	@matKhau VARCHAR(15),
	@soCMND VARCHAR(12),
	@diaChi NVARCHAR(60),
	@dienThoai VARCHAR(11),
	@moTa NVARCHAR(100),
	@email VARCHAR(40)
AS
BEGIN TRAN
	BEGIN TRY
		IF EXISTS (SELECT *
					FROM dbo.KhachHang
					WHERE dienThoai=@dienThoai)
		BEGIN
			PRINT N'Số điện thoại đã tồn tại'
			ROLLBACK TRAN
		END
		IF EXISTS (SELECT*
					FROM dbo.KhachHang
					WHERE soCMND=@soCMND)
		BEGIN
			PRINT N'CMND đã tồn tại'
			ROLLBACK TRAN
		END
		IF EXISTS (SELECT*
					FROM dbo.KhachHang
					WHERE tenDangNhap=@tenDangNhap)
		BEGIN
			PRINT N'Tên đăng nhập đã tồn tại'
			ROLLBACK TRAN
		END
		IF EXISTS (SELECT*
					FROM dbo.KhachHang
					WHERE email=@email)
		BEGIN
			PRINT N'email đã tồn tại'
			ROLLBACK TRAN
		END
		INSERT INTO dbo.KhachHang
				(-- maKH ,
				  hoTen ,
				  tenDangNhap ,
				  matKhau ,
				  soCMND ,
				  diaChi ,
				  dienThoai ,
				  moTa ,
				  email
				)
		VALUES  ( --@maKH , -- maKH - varchar(9)
				  @hoTen , -- hoTen - nvarchar(35)
				  @tenDangNhap , -- tenDangNhap - varchar(35)
				  @matKhau , -- matKhau - varchar(9)
				  @soCMND , -- soCMND - varchar(12)
				  @diaChi , -- diaChi - nvarchar(60)
				  @dienThoai , -- dienThoai - varchar(11)
				  @moTa , -- moTa - nvarchar(100)
				  @email  -- email - varchar(40)
				)
		SELECT maKH
		FROM dbo.KhachHang
		WHERE soCMND=@soCMND
	END TRY
	BEGIN CATCH
		RAISERROR ('Lỗi hệ thống',16,1)
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

--CÂU 2: TÌM KIẾM THÔNG TIN KHÁCH SẠN

CREATE 
--alter
PROCEDURE TimKiemKhachSan(@ThanhPho NVARCHAR(35), @GiaLon INT, @GiaBe INT, @HangSao INT)
AS
BEGIN TRAN
	DECLARE @v_Error_Number INTEGER
	BEGIN TRY
		IF (@ThanhPho = '')
			PRINT N'Không được để trống thành phố!'
		ELSE
		BEGIN
			IF (@GiaLon='0' AND  @HangSao = '0' AND @GiaBe = '0')
			SELECT ks.maKS, ks.tenKS,sonha +', '+ duong +', '+ quan +', '+  thanhPho AS 'diaChi', ks.soSao, ks.giaTB, ks.moTa
			FROM dbo.KhachSan ks
			WHERE thanhPho LIKE '%' + @ThanhPho + '%'
			ELSE 
			BEGIN
				IF (@GiaLon !='0' AND @HangSao !='0')
					SELECT ks.maKS, ks.tenKS,sonha +', '+ duong +', '+ quan +', '+  thanhPho AS 'diaChi', ks.soSao, ks.giaTB, ks.moTa
					FROM dbo.KhachSan ks
					WHERE thanhPho LIKE '%' + @ThanhPho + '%'
					AND giaTB BETWEEN @GiaBe AND @GiaLon
					AND @HangSao LIKE soSao
				ELSE 
				BEGIN
					IF(@GiaLon !='0')
						SELECT ks.maKS, ks.tenKS,sonha +', '+ duong +', '+ quan +', '+  thanhPho AS 'diaChi', ks.soSao, ks.giaTB, ks.moTa
						FROM dbo.KhachSan ks
						WHERE thanhPho LIKE '%' + @ThanhPho + '%'
						AND giaTB BETWEEN @GiaBe AND @GiaLon
					ELSE 
						SELECT ks.maKS, ks.tenKS,sonha +', '+ duong +', '+ quan +', '+  thanhPho AS 'diaChi', ks.soSao, ks.giaTB, ks.moTa
						FROM dbo.KhachSan ks
						WHERE thanhPho LIKE '%' + @ThanhPho + '%'
						AND @HangSao LIKE soSao
				END
			END 
		END
		IF @@TRANCOUNT>0 
			PRINT 'Commit Transaction'
	END TRY
	BEGIN CATCH
		  -- Mã lỗi.
		  SET @v_Error_Number = ERROR_NUMBER();
		  -- In ra mã lỗi:
		  PRINT 'Error Number: ' + CAST(@v_Error_Number AS varchar(15));
		  -- Nguyên nhân lỗi:
		  PRINT 'Error Message: ' + ERROR_MESSAGE();
		  --  Mức độ nghiêm trọng của lỗi:
		  PRINT 'Error Severity: ' + CAST(ERROR_SEVERITY() AS varchar(15));
		  -- Mã trạng thái:
		  PRINT 'Error State: ' + CAST(ERROR_STATE() AS varchar(15));
		  -- Dòng bị lỗi:
		  PRINT 'Error Line: ' + CAST(ERROR_LINE() AS varchar(15));
		  -- Tên của thủ tục (hoặc function) hoặc trigger, có code gây ra lỗi này.
		  PRINT 'Error Procedure: ' + ERROR_PROCEDURE();
		 PRINT 'Error --> Rollback Transaction';
		 IF @@Trancount > 0
		   ROLLBACK TRAN;
	END CATCH
COMMIT TRAN
GO


--CÂU 3: ĐĂNG NHẬP
CREATE
--ALTER
PROC USP_DangNhap_KhachHang
	@tenDangNhap VARCHAR(35),
	@matKhau VARCHAR(15)
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT *
						FROM dbo.KhachHang
						WHERE tenDangNhap=@tenDangNhap)
		BEGIN
			PRINT N'Tên đăng nhập không tồn tại'
			ROLLBACK TRAN
			RETURN    
		END
		IF NOT EXISTS (SELECT*
						FROM dbo.KhachHang
						WHERE tenDangNhap=@tenDangNhap
						AND matKhau=@matKhau)
		BEGIN
			PRINT N'Tên đăng nhập hoặc mật khẩu sai'
			ROLLBACK TRAN
			RETURN
		END
		ELSE
		BEGIN
			SELECT maKH, hoTen
			FROM dbo.KhachHang
			WHERE tenDangNhap=@tenDangNhap
		END
	END TRY
	BEGIN CATCH
		RAISERROR (N'Lỗi hệ thống',16,1)
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

CREATE 
--alter
PROC USP_DangNhap_NhanVien
	@tenDangNhap VARCHAR(35),
	@matKhau VARCHAR(9)
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT *
						FROM dbo.NhanVien
						WHERE tenDangNhap=@tenDangNhap)
		BEGIN
			PRINT N'Tên đăng nhập không tồn tại'
			ROLLBACK TRAN 
			RETURN          
		END
		IF NOT EXISTS (SELECT*
						FROM dbo.NhanVien
						WHERE tenDangNhap=@tenDangNhap
						AND matKhau=@matKhau)
		BEGIN
			PRINT N'Tên đăng nhập hoặc mật khẩu sai'
			ROLLBACK TRAN
			RETURN            
		END
		ELSE
		BEGIN
			SELECT maNV, hoTen, maKS
			FROM dbo.NhanVien
			WHERE tenDangNhap=@tenDangNhap
		END
	END TRY
	BEGIN CATCH
		RAISERROR(N'Lỗi hệ thống',16,1)
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

--CÂU 4: ĐẶT PHÒNG
--Vì trong cách lưu dữ liêu thì mỗi loại phòng đối với mỗi khách sạn đều có mã loại phòng khác nhau -> từ mã loại Pjongf có thể suy ra được mã khách sạn
-- không cần bảng khách sạn
CREATE 
--alter
PROC USP_LoaiPhongCoTheDat
	@maKS int,
	@ngayBatDau DATETIME,
	@ngayTraPhong DATETIME
AS
BEGIN TRAN
	BEGIN TRY	
	SELECT DISTINCT MaP.tenLoaiPhong, MaP.donGia, MaP.moTa, MaP.maLoaiPhong
	FROM dbo.TrangThaiPhong TTP join (SELECT P.maPhong, LP.tenLoaiPhong, LP.donGia, LP.moTa, LP.maLoaiPhong
									FROM dbo.LoaiPhong LP, dbo.Phong P
									WHERE @maKS = LP.maKS
									AND LP.maLoaiPhong=P.loaiPhong) AS MaP ON MaP.maPhong = TTP.maPhong
	WHERE TTP.tinhTrang=N'còn trống'
	AND TTP.ngay<=@ngayTraPhong
	AND @ngayBatDau >= (SELECT MAX(TTP1.ngay)
					FROM dbo.TrangThaiPhong TTP1
					WHERE TTP1.maPhong=TTP.maPhong
					--AND TTP1.ngay=TTP.ngay
					AND @ngayTraPhong >= TTP1.ngay)
    END TRY
	BEGIN CATCH
		RAISERROR(N'Lỗi hệ thống',16,1)
		ROLLBACK TRAN
	END CATCH

COMMIT TRAN
GO

CREATE 
--alter
PROCEDURE USP_DatPhong (@malphong VARCHAR(6) , @makh VARCHAR(9), @ngayBD DATETIME, @ngayT DATETIME  )
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE @phongTrong INT
		DECLARE @gia INT 
		SET @phongTrong = (SELECT lp.slTrong FROM dbo.LoaiPhong lp WHERE @malphong =maLoaiPhong  )
		IF (@phongTrong='0') BEGIN 
			PRINT N'Phòng đã được đặc hết! Xin quý khách vui lòng chọn lại!'	
			 ROLLBACK TRAN
			END
		ELSE
		BEGIN 
		SET @gia = (SELECT donGia FROM dbo.LoaiPhong WHERE maLoaiPhong LIKE @malphong )
        UPDATE dbo.LoaiPhong SET slTrong-=1 WHERE maLoaiPhong=@malphong
		
		--Dùng con trỏ để chỉ đến phòng trống đầu tiên
		--chọn phòng còn trống đầu tiên cho khách lấy dữ liệu mã phòng để update bảng tình trạng phòng và insert bảng đặt phòng
		DECLARE @maP INT 
		DECLARE cs_temp CURSOR SCROLL
		FOR SELECT p.maPhong FROM dbo.Phong p WHERE p.loaiPhong LIKE @malphong
		OPEN cs_temp
		FETCH FIRST FROM cs_temp INTO @maP
		UPDATE dbo.TrangThaiPhong SET tinhTrang = N'Đang sử dụng' WHERE maPhong=@maP
		INSERT dbo.DatPhong
		(
		    maLoaiPhong,
		    maKH,
		    ngayBatDau,
		    ngayTraPhong,
		    ngayDat,
		    donGia,
		    moTa,
		    tinhTrang,
		    maPhong
		)
		VALUES
		(   @malphong,         -- maLoaiPhong - int
		    ''+@makh+'',        -- maKH - varchar(9)
		    @ngayBD, -- ngayBatDau - datetime
		    @ngayT, -- ngayTraPhong - datetime
		    GETDATE(), -- ngayDat - datetime
		    0,         -- donGia - int
		    N'',       -- moTa - nvarchar(100)
		    N'Chưa xác nhận',       -- tinhTrang - nvarchar(13) khi nào khách hàng tới nhận phòng thì mới là đã xác nhận
		    @maP          -- maPhong - int
		    )

		CLOSE cs_temp
		DEALLOCATE cs_temp
		PRINT N'Đặt phòng thành công'
		END 
    END TRY
    BEGIN CATCH
		DECLARE @v_Error_Number INTEGER
		  -- Mã lỗi.
		  SET @v_Error_Number = ERROR_NUMBER();
		  -- In ra mã lỗi:
		  PRINT 'Error Number: ' + CAST(@v_Error_Number AS varchar(15));
		  -- Nguyên nhân lỗi:
		  PRINT 'Error Message: ' + ERROR_MESSAGE();
		  --  Mức độ nghiêm trọng của lỗi:
		  PRINT 'Error Severity: ' + CAST(ERROR_SEVERITY() AS varchar(15));
		  -- Mã trạng thái:
		  PRINT 'Error State: ' + CAST(ERROR_STATE() AS varchar(15));
		  -- Dòng bị lỗi:
		  PRINT 'Error Line: ' + CAST(ERROR_LINE() AS varchar(15));
		  -- Tên của thủ tục (hoặc function) hoặc trigger, có code gây ra lỗi này.
		  PRINT 'Error Procedure: ' + ERROR_PROCEDURE();
		 PRINT 'Error --> Rollback Transaction';
		 IF @@Trancount > 0
		   ROLLBACK TRAN;
	END CATCH
COMMIT TRAN
GO

--CÂU 5: LẬP HÓA ĐƠN
--tinh tong tien
CREATE FUNCTION UF_TinhTongTien
(@maDP INT)
RETURNS INT
AS
BEGIN
	DECLARE @tongTien INT
	SET @tongTien=(SELECT DATEDIFF(DAY, DP.ngayBatDau, DP.ngayTraPhong)*DP.donGia
					FROM dbo.DatPhong DP
					where @maDP=DP.MaDP)
	RETURN @tongTien
END
GO

--Lap hoa don
CREATE 
--alter
PROC USP_LapHoaDon
	@maDP int
AS
BEGIN TRAN
	BEGIN TRY
		if (not exists (select * from DatPhong where madp=@maDP))
			print N'Mã đặt phòng không đúng!'
		else if(not exists (select * from HoaDon where @maDP=maDP)) begin
		UPDATE dbo.DatPhong
		SET tinhTrang = N'Đã xác nhận'
		WHERE @maDP = maDP

		DECLARE @tongTien INT
		SET @tongTien = (SELECT dbo.UF_TinhTongTien(@maDP))
		INSERT INTO dbo.HoaDon
		        (ngayThanhToan, tongTien, maDP )
		VALUES  ( GETDATE(), -- ngayThanhToan - datetime
		          @tongTien, -- tongTien - int
		          @maDP  -- maDP - int
		          )
		
		DECLARE @maPhong INT
		SET @maPhong = (SELECT maPhong
						FROM dbo.DatPhong
						WHERE maDP=@maDP)
		INSERT dbo.TrangThaiPhong
		        ( maPhong, ngay, tinhTrang )
		VALUES  ( @maPhong, -- maPhong - int
		          GETDATE(), -- ngay - datetime
		          N'Còn trống'  -- tinhTrang - nvarchar(12)
		          )
		DECLARE @maLoaiPhong INT
		SET @maLoaiPhong = (SELECT P.loaiPhong
							FROM dbo.DatPhong DP, dbo.Phong P
							WHERE DP.maPhong=P.maPhong
							AND DP.maDP=@maDP)
		UPDATE dbo.LoaiPhong
		SET slTrong += 1
		WHERE maLoaiPhong=@maLoaiPhong
		SELECT HD.*, A.*
		FROM dbo.HoaDon HD join (SELECT KH.maKH, KH.hoTen, DP.maDP, DP.ngayBatDau, DP.ngayTraPhong, DP.donGia
								FROM dbo.DatPhong DP JOIN dbo.KhachHang KH ON KH.maKH = DP.maKH
								WHERE DP.maDP=@maDP) AS A ON A.maDP = HD.maDP
		end
		else begin
		print N'Hóa đơn đã được thanh toán'
		SELECT HD.*, A.*
		FROM dbo.HoaDon HD join (SELECT KH.maKH, KH.hoTen, DP.maDP, DP.ngayBatDau, DP.ngayTraPhong, DP.donGia
								FROM dbo.DatPhong DP JOIN dbo.KhachHang KH ON KH.maKH = DP.maKH
								WHERE DP.maDP=@maDP) AS A ON A.maDP = HD.maDP
		end
    END TRY
    BEGIN CATCH
		RAISERROR(N'Lỗi hệ thống',16,1)
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

--CÂU 6: KIỂM TRA TÌNH TRẠNG PHÒNG
--Loại phòng của khách sạn
CREATE 
--alter
PROC USP_LP_KS
	@maKS INT
AS
BEGIN
	SELECT DISTINCT tenLoaiPhong
    FROM dbo.LoaiPhong
	WHERE maKS=@maKS
END
GO

--kiem tra tinh trang phong
CREATE 
--alter
PROC USP_KiemTra_TinhTrangPhong
	@tenLoaiPhong NVARCHAR(20),
	@maKS INT,
	@ngay DATETIME
AS
BEGIN
	SELECT MaP.soPhong, TTP.tinhTrang, MaP.tenLoaiPhong, MaP.donGia, MaP.moTa
    FROM dbo.TrangThaiPhong TTP, (SELECT P.soPhong, P.maPhong, LP.tenLoaiPhong, LP.donGia, LP.moTa
									FROM dbo.LoaiPhong LP, dbo.Phong P
									WHERE @tenLoaiPhong=LP.tenLoaiPhong
									AND @maKS=LP.maKS
									AND LP.maLoaiPhong=P.loaiPhong) AS MaP
	WHERE MaP.maPhong=TTP.maPhong
	AND CONVERT(DATE, TTP.ngay) = (SELECT CONVERT(DATE,MAX(TTP1.ngay))
									FROM dbo.TrangThaiPhong TTP1
									WHERE CONVERT(DATE, TTP1.ngay) <= CONVERT(DATE, @ngay)
									AND TTP1.maPhong=MaP.maPhong)
END
GO



---CÂU 7
--Tim kiem hoa don
CREATE 
--alter
PROC USP_TIMKIEMTHONGTINHOADON
	@MaKH varchar(9),
	@NgayLapHD datetime,
	@TongTien INT,
	@maKS INT
AS
BEGIN TRAN
	BEGIN TRY
		IF(NOT EXISTS (SELECT * FROM KhachHang WHERE maKH=@MaKH)) BEGIN
			RAISERROR (N'MÃ KHÁCH HÀNG KHÔNG TỒN TẠI',16,1)
			ROLLBACK TRAN;
		END
		ELSE BEGIN

		DECLARE @TEMP INT
		SET @TEMP=DATEDIFF(DAY, @NgayLapHD, GETDATE())
		IF(@TEMP=0 AND @TongTien=0)BEGIN
			SELECT HD.*, A.*
			FROM HOADON HD JOIN (SELECT DP.maDP, DP.ngayBatDau, DP.ngayTraPhong, DP.donGia, KH.maKH, KH.hoTen
							FROM dbo.DatPhong DP JOIN dbo.KhachHang KH ON KH.maKH = DP.maKH
							WHERE @MaKH=KH.maKH) AS A ON A.maDP = HD.maDP
			WHERE HD.maKS=@maKS
		END
		ELSE BEGIN
			IF(@TEMP<>0) BEGIN
				IF(@TONGTIEN <>0) BEGIN
					SELECT HD.*, A.*
					FROM HoaDon HD JOIN (SELECT DP.maDP, DP.ngayBatDau, DP.ngayTraPhong, DP.donGia, KH.maKH, KH.hoTen
							FROM dbo.DatPhong DP JOIN dbo.KhachHang KH ON KH.maKH = DP.maKH
							WHERE @MaKH=KH.maKH) AS A ON A.maDP = HD.maDP
					WHERE tongTien=@TONGTIEN AND CONVERT(DATE,@NgayLapHD) =CONVERT(DATE,ngayThanhToan)
					and HD.maKS=@maKS
					END
				ELSE BEGIN
					SELECT HD.*, A.* 
					FROM HoaDon HD JOIN (SELECT DP.maDP, DP.ngayBatDau, DP.ngayTraPhong, DP.donGia, KH.maKH, KH.hoTen
							FROM dbo.DatPhong DP JOIN dbo.KhachHang KH ON KH.maKH = DP.maKH
							WHERE @MaKH=KH.maKH) AS A ON A.maDP = HD.maDP
					WHERE CONVERT(DATE,@NgayLapHD) =CONVERT(DATE,ngayThanhToan)
					and HD.maKS=@maKS
					END
			END
			ELSE BEGIN
				SELECT * 
				FROM HoaDon HD JOIN (SELECT DP.maDP, DP.ngayBatDau, DP.ngayTraPhong, DP.donGia, KH.maKH, KH.hoTen
							FROM dbo.DatPhong DP JOIN dbo.KhachHang KH ON KH.maKH = DP.maKH
							WHERE @MaKH=KH.maKH) AS A ON A.maDP = HD.maDP 
				WHERE tongTien=@TONGTIEN
				and HD.maKS=@maKS
			END
		END	
		END	
	END TRY
	BEGIN CATCH
			PRINT N'Lỗi hệ thống'
		   ROLLBACK TRAN;
	END CATCH
COMMIT TRAN

---CÂU 8 THỐNG KÊ
--DOANH THU THEO THÁNG
CREATE
--alter
 PROC USP_DoanhThu_Thang
	@ngayBD DATETIME,
	@ngayKT DATETIME,
	@maKS INT
AS
BEGIN
	IF( DATEPART(YEAR, @ngayKT) = DATEPART(YEAR, @ngayBD) )
	BEGIN
		SELECT DISTINCT DATEPART(MONTH, HD.ngayThanhToan) AS thang, SUM( CAST (HD.tongTien AS BIGINT) ) AS doanhThuThang
		FROM HoaDon HD JOIN DatPhong DP
		ON CONVERT (DATE, HD.ngayThanhToan) >= CONVERT(DATE, @ngayBD)
		AND CONVERT (DATE, HD.ngayThanhToan) <= CONVERT(DATE, @ngayKT) 
		AND HD.maKS=@maKS
		AND HD.maDP = DP.maDP
		GROUP BY DATEPART(MONTH, HD.ngayThanhToan)
		ORDER BY DATEPART(MONTH, HD.ngayThanhToan)  ASC
	END
	ELSE
	BEGIN
		RAISERROR (N'Không thể thống kê được doanh thu vì 2 năm nhập vào khác nhau', 16,1)
		ROLLBACK
	END
END

--DOANH THU THEO NĂM
CREATE 
--alter
PROC USP_DoanhThu_Nam
	@ngayBD DATE,
	@ngayKT DATE,
	@maKS INT
AS
BEGIN
	SELECT DISTINCT DATEPART(YEAR, HD.ngayThanhToan) AS nam, SUM( CAST(HD.tongTien AS BIGINT)) AS doanhThuNam
	FROM HoaDon HD JOIN DatPhong DP
	ON CONVERT (DATE, HD.ngayThanhToan) >= CONVERT(DATE, @ngayBD)
	AND CONVERT (DATE, HD.ngayThanhToan) <= CONVERT(DATE, @ngayKT) 
	AND HD.maKS=@maKS
	AND HD.maDP = DP.maDP
	GROUP BY DATEPART(YEAR, HD.ngayThanhToan)
	ORDER BY DATEPART(YEAR, HD.ngayThanhToan)  ASC
END 

--DOANH THU THEO LOẠI PHÒNG
CREATE
--alter
 PROC USP_DoanhThu_LoaiPhong
	@ngayBD DATE,
	@ngayKT DATE,
	@maKS INT
AS
BEGIN
	SELECT LP.tenLoaiPhong, SUM(CAST(HD.tongTien AS BigInt)) AS doanhThu
	FROM LoaiPhong LP JOIN HoaDon HD 
	ON HD.maKS=LP.maKS 
		AND HD.maKS=@maKS 
		AND CONVERT (DATE, HD.ngayThanhToan) >= CONVERT (DATE, @ngayBD)
		AND CONVERT (DATE, HD.ngayThanhToan) <= CONVERT(DATE,@ngayKT)
	GROUP BY LP.tenLoaiPhong
END 

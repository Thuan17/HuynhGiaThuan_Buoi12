create database QLHN
go
use QLHN
go
 CREATE TABLE LoaiPhong(
   maLoaiPhong  VARCHAR (10) primary key,
   tenLoaiPhong NVARCHAR (30) NOT NULL,     
);
CREATE TABLE HoiNghi(
   maHoiNghi  VARCHAR (10) primary key,
   tenHoiNghi VARCHAR (30)  NULL,
   SoNguoi int, 
   maLoaiPhong  VARCHAR (10) ,  
   Constraint F_LP_HN Foreign key(maLoaiPhong) references LoaiPhong(maLoaiPhong),
);
INSERT LoaiPhong([maLoaiPhong], [tenLoaiPhong]) VALUES ('PHONG_HN', N'Phòng Hội Nghị')
INSERT LoaiPhong([maLoaiPhong], [tenLoaiPhong]) VALUES ('PHONG_HOP', N'Phòng Họp')

select * from HoiNghi where tenLoaiPhong= N'Phòng Hội Nghị'
delete from HoiNghi where maHoiNghi='HN6705124'

insert into HoiNghi values ('HN5555',N'Mừng Đảng Mừng Xuân',60,N'PHONG_HN')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN111', N'OPEN DAY 2018',200,N'PHONG_HN')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN223', N'Giao lưu cựu sinh viên',240,N'PHONG_HN')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN421', N'Startup',100,N'PHONG_HOP')

INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('HN522', N'Đại Hội Công Nhân Viên 2018',1000,N'PHONG_HN')



CREATE PROCEDURE GetHoiNghiByLoaiPhong
    @tenLoaiPhong NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        H.maHoiNghi,
        H.tenHoiNghi,
        H.SoNguoi
    FROM
        LoaiPhong LP
    JOIN
        HoiNghi H ON LP.maLoaiPhong = H.maLoaiPhong
    WHERE
        LP.tenLoaiPhong = @tenLoaiPhong;
END;



EXEC GetHoiNghiByLoaiPhong @tenLoaiPhong = N'Phòng Hội Nghị';




CREATE PROCEDURE InsertHoiNghi
    @maHoiNghi VARCHAR(10),
    @tenHoiNghi NVARCHAR(30),
    @SoNguoi INT,
    @tenLoaiPhong NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @maLoaiPhong VARCHAR(10);

    -- Lấy maLoaiPhong từ tenLoaiPhong trong bảng LoaiPhong
    SELECT @maLoaiPhong = maLoaiPhong
    FROM LoaiPhong
    WHERE tenLoaiPhong = @tenLoaiPhong;

    -- Thêm dữ liệu vào bảng HoiNghi
    INSERT INTO HoiNghi (maHoiNghi, tenHoiNghi, SoNguoi, maLoaiPhong)
    VALUES (@maHoiNghi, @tenHoiNghi, @SoNguoi, @maLoaiPhong);
END;



EXEC InsertHoiNghi  @maHoiNghi = '1313', @tenHoiNghi = N'TenHoiNghiMoi', @SoNguoi = 100,   @tenLoaiPhong = N'Phòng Hội Nghị';
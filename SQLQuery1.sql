CREATE DATABASE QUANLITP
GO
USE QUANLITP
GO

CREATE TABLE HOKHAU
(
	MaHK VARCHAR(15) PRIMARY KEY,
	DiaChi NVARCHAR(100),
	CCCDChuHo VARCHAR(15),
);
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('000001',N'52, Thầy Linh, Tiểu Cần, Trà Vinh', '123456777580');
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('000002',N'52, Điện Biên Phủ, Trà Cú, Trà Vinh', '123456777581');
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('000003',N'52, Nguyễn Huệ, Duyên Hải,Trà Vinh', '123456777582');
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('000004',N'52, Nguyễn Văn Linh, Càng Long, Trà Vinh','123456777583');
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('000005',N'52, Trần Hưng Đạo, Tiểu Cần, Trà Vinh','123456777584');

GO

CREATE TABLE CONGDAN
(
	CCCD VARCHAR(15) PRIMARY KEY,
	Ten NVARCHAR(30) NOT NULL,
	NgheNghiep NVARCHAR(30),
	SDT VARCHAR(12),
	TonGiao NVARCHAR(30),
	MaHK VARCHAR(15) REFERENCES HOKHAU(MaHK),
	QuanHeVoiChuHo NVARCHAR(30),
);

GO

INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777580' , N'Trần Thị Loan', N'Buôn bán', '0397490429', N'Không', '000001', N'Chủ hộ');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777581' , N'Nguyễn Văn An', N'Buôn bán', '0397490428', N'Không', '000002', N'Chủ hộ');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777582' , N'Trần Thanh Hải', N'Giáo viên', '0397490427', N'Không', '000003', N'Chủ hộ');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777583' , N'Lê Nhật Khôi', N'Buôn bán', '0397490426', N'Phật', '000004', N'Chủ hộ');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777584' , N'Trần Hoàng Phúc', N'Công nhân', '0397490425', N'Không', '000005', N'Chủ hộ');

INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777585' , N'Nguyễn Văn Hùng', N'Buôn bán', '0397490424', N'Không', '000001', N'Chồng');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777586' , N'Nguyễn Kim Tuyền', N'Buôn bán', '0397490423', N'Không', '000001', N'Con gái');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777587' , N'Trần Thị Diệp', N'Buôn bán', '0397490422', N'Phật', '000002', N'Vợ');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777588' , N'Trần Văn Kiệt', N'Buôn bán', '0397490421', N'Thiên chúa', '000003', N'Anh trai');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777589' , N'Lê Văn Liêm', N'Buôn bán', '0397490420', N'Không', '000004', N'Con trai');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777590' , N'Trần Thị Lan', N'Ngân hàng', '0397490419', N'Không', '000004', N'Vợ');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777591' , N'Trần Công Huy', N'Sinh viên', '0397490418', N'Không', '000005', N'Con trai');
INSERT INTO CONGDAN(CCCD,Ten,NgheNghiep,SDT,TonGiao,MaHK,QuanHeVoiChuHo) VALUES ('123456777592' , N'Trần Thị Loan', N'Buôn bán', '0397490417', N'Không', '000005', N'Vợ');

GO

CREATE TABLE CCCD
(
	MaCCCD VARCHAR(15) PRIMARY KEY,
	DacDiem NVARCHAR(50),
	NgayCap DATE,
	FOREIGN KEY (MaCCCD) REFERENCES CONGDAN(CCCD)
);

GO

INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777580', N'Thẹo 2cm đuôi mắt trái', '2015-01-02');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777581', N'Nốt ruồi má trái', '2015-01-03');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777582', N'Thẹo 2cm đuôi mắt phải', '2015-01-21');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777583', N'Mắt trái nhỏ', '2015-11-20');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777584', N'Nốt ruồi giữa tráng', '2013-10-5');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777585', N'Thẹo tròn ở mũi', '2015-8-04');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777586', N'Môi trên có thẹo', '2017-01-01');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777587', N'Thẹo 1cm tai phải', '2015-05-01');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777588', N'Thẹo giữa má', '2015-01-02');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777589', N'Nốt ruồi mép môi trái', '2015-09-11');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777590', N'Mắt phải nhỏ', '2015-05-01');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777591', N'Thẹo tráng 1cm bên trái', '2015-01-09');
INSERT INTO CCCD(MaCCCD, DacDiem, NgayCap) VALUES('123456777592', N'Thẹo tráng 0.5cm phải', '2015-01-03');

GO

CREATE TABLE TAMTRUTAMVANG
(
	MaTTTV VARCHAR(15),
	CCCD VARCHAR(15) PRIMARY KEY,
	DiaChi NVARCHAR(100),
	NgayBD DATE,
	NgayKT DATE,
	TrangThai NVARCHAR(50),
	LiDo NVARCHAR(100) ,
	FOREIGN KEY (CCCD) REFERENCES CCCD(MaCCCD)
);

GO

INSERT INTO TAMTRUTAMVANG(MaTTTV, CCCD, DiaChi, NgayBD, NgayKT, TrangThai, LiDo) VALUES('000001','123456777591',N'484, Lê Văn Việt, Quận 9, Thủ Đức' ,'2015-01-07', '2022-01-10', N'Tạm trú', N'Học đại học' );

GO

CREATE TABLE KHAISINH
(
	MaKS  VARCHAR(15) PRIMARY KEY,
	Ten NVARCHAR (30) NOT NULL,
	NgaySinh DATE NOT NULL,
	NgayDangKy DATE,
	GioiTinh VARCHAR(1) NOT NULL,
	DanToc NVARCHAR(20) NOT NULL,
	QuocTich NVARCHAR(20) NOT NULL,
	NoiSinh NVARCHAR(100),
	QueQuan NVARCHAR(100),
	CCCDCha VARCHAR(15),
	TenCha NVARCHAR(30),
	CCCDMe VARCHAR(15),
	TenMe NVARCHAR(30),
	FOREIGN KEY (MaKS) REFERENCES CCCD(MaCCCD),
);

GO

INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777580' , N'Trần Thị Loan', '1992-01-01','1992-01-02', 'f', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u,Trà Vinh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777581' , N'Nguyễn Văn An', '1993-01-01','1993-01-02', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Đồng Tháp', N'u, u, u,Trà Vinh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777582' , N'Trần Thanh Hải', '1992-01-01','1992-01-01', 'm', N'Khmer', N'Việt Nam', N'u, u, u, Đà Nẵng', N'u, u, u, Vĩnh Long', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777583' , N'Lê Nhật Khôi', '1995-01-01','1995-02-01', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u,Hồ Chí Minh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy, GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777584' , N'Trần Hoàng Phúc', '1992-01-01','1992-01-03', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Trà Vinh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777585' , N'Nguyễn Văn Hùng', '1992-01-01','1992-01-01', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u,Trà Vinh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777586' , N'Nguyễn Kim Tuyền', '1992-01-01','1992-01-01', 'f', N'Hoa', N'Việt Nam', N'u, u, u, Vũng Tàu', N'u, u, u,Trà Vinh', '123456777585', N'Nguyễn Văn Hùng', '123456777580', N'Trần Thị Loan');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777587' , N'Trần Thị Diệp', '1992-01-01','1992-01-01', 'f', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Trà Vinh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777588' , N'Trần Văn Kiệt', '1992-01-01','1992-01-01', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Phan Thiết', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777589' , N'Lê Văn Liêm', '1992-01-01','1992-01-01', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Nha Trang', '123456777583', N'Lê Nhật Khôi', '123456777590', N'Trần Thị Lan');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777590' , N'Trần Thị Lan', '1992-01-01','1992-01-01', 'f', N'Hoa', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Trà Vinh', 'u', N'u', 'u', N'u');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777591' , N'Trần Công Huy', '1992-01-01','1992-01-01', 'm', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Trà Vinh', '123456777591', N'Trần Công Huy', '123456777592', N'Trần thị Loan');
INSERT INTO KHAISINH(MaKS, Ten, NgaySinh, NgayDangKy , GioiTinh, DanToc, QuocTich, NoiSinh, QueQuan, CCCDCha, TenCha, CCCDMe, TenMe) VALUES('123456777592' , N'Trần Thị Loan', '1992-01-01','1992-01-01', 'f', N'Kinh', N'Việt Nam', N'u, u, u, Trà Vinh', N'u, u, u, Trà Vinh', 'u', N'u', 'u', N'u');

GO

CREATE TABLE THUE
(	MaThue VARCHAR(15) PRIMARY KEY,
	CCCD VARCHAR(15),
	SoTienCanNop VARCHAR(20),
	SoTienDaNop VARCHAR(30),
	NgayCap DATE,
	HanNop DATE,
	FOREIGN KEY (CCCD) REFERENCES CCCD(MaCCCD)
);

GO

INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000011','123456777580', '100000','0', '2015-01-02', '2023-05-05');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000013','123456777581', '600000','13520', '2015-01-02', '2023-05-05');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000014','123456777582', '3400000','15110', '2015-01-02', '2023-05-06');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop)VALUES('000015','123456777583', '100000','100000', '2015-01-02', '2023-05-01');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000016','123456777584', '400000','0', '2015-01-02', '2023-06-30');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000017','123456777585', '100000','23520', '2015-01-02', '2023-05-11');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000018','123456777586', '100000','0', '2015-01-02', '2023-08-05');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000019','123456777587', '900000','322320', '2015-01-02', '2023-09-07');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000020','123456777588', '300000','0', '2015-01-02', '2023-01-24');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000021','123456777589', '5400000','231110', '2015-01-02', '2023-06-05');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000022','123456777590', '100000','151210', '2015-01-02', '2023-06-11');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000023','123456777591', '3500000','3412310', '2015-01-02', '2023-07-25');
INSERT INTO THUE(MaThue, CCCD, SoTienCanNop, SoTienDaNop, NgayCap, HanNop) VALUES('000024','123456777592', '700000','13510', '2015-01-02', '2023-08-06');

GO

CREATE TABLE HONNHAN
(
	MaHonNhan VARCHAR(15) PRIMARY KEY,
	CCCDNam VARCHAR(15),
	TenNam NVARCHAR(30),
	CCCDNu VARCHAR(15),
	TenNu NVARCHAR(30),
	NoiDangKy NVARCHAR(100),
	NgayDangKy DATE,
	FOREIGN KEY (CCCDNam) REFERENCES CCCD(MaCCCD),
	FOREIGN KEY (CCCDNu) REFERENCES CCCD(MaCCCD)
);

GO

INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('000001','123456777585',N'Nguyễn Văn Hùng','123456777580',N'Trần Thị Loan',N'u,u,u,Trà Vinh','2022-10-26');
INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('000002','123456777581' , N'Nguyễn Văn An','123456777587', N'Trần Thị Diệp',N'u,u,u,Trà Vinh','2022-10-10');
INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('000003','123456777583' , N'Lê Nhật Khôi','123456777590' , N'Trần Thị Lan',N'u,u,u,Vĩnh Long','2021-11-10');
INSERT INTO HONNHAN(MaHonNhan, CCCDNam, TenNam, CCCDNu, TenNu, NoiDangKy, NgayDangKy) VALUES('000004','123456777584' , N'Trần Hoàng Phúc','123456777592' , N'Trần Thị Loan',N'u,u,u,Trà Vinh','2019-07-10');


GO
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('00000A',N'Chưa nhập hộ', '000000000000');
INSERT INTO HOKHAU(MaHK,DiaChi,CCCDChuHo) VALUES('00000B',N'Tạm trú', '000000000001');
GO

CREATE TABLE ACCOUNT(
UserName VARCHAR(20) PRIMARY KEY,
StrPassword VARCHAR(25),
QuyenTruyCap int,
DisplayName NVARCHAR(30)
);

INSERT INTO ACCOUNT(UserName, StrPassword, QuyenTruyCap, DisplayName) VALUES ('admin', 'admin', 1, N'Tài khoản DEMO');


SELECT *FROM CONGDAN
SELECT *FROM CCCD
SELECT *FROM KHAISINH
SELECT *FROM HOKHAU
SELECT *FROM TAMTRUTAMVANG
SELECT *FROM THUE
SELECT *FROM HONNHAN
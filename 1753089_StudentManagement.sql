﻿/*Ho ten: Nguyen Ly Nhat Phuong
Lop: 17CLC2
MSSV: 1753089*/

CREATE DATABASE STUDENT_MANAGEMENT_1753089

ON (NAME = 'STUDENT_MANAGEMENT_1753089', FILENAME = 'D:\STUDENT_MANAGEMENT_1753089.mdf')
LOG ON (NAME = 'STUDENT_MANAGEMENT_1753089_log', FILENAME = 'D:\STUDENT_MANAGEMENT_1753089.ldf')

GO

USE STUDENT_MANAGEMENT_1753089
GO


CREATE TABLE SINHVIEN
(
	MSSV VARCHAR(10),
	CMND VARCHAR(11),
	HOTEN NVARCHAR(50),
	PASS VARCHAR(50),
	LOP VARCHAR(10),
	NGAYSINH DATE,
	DIACHI NVARCHAR(100),
	GIOITINH NCHAR(3)
	
	

	PRIMARY KEY (MSSV)

);

GO

CREATE TABLE GIAOVU
(
	MAGV VARCHAR(10),
	CMND VARCHAR(11),
	HOTEN NVARCHAR(50),
	PASS VARCHAR(50),
	NGAYSINH DATE,
	DIACHI NVARCHAR(100),
	GIOITINH NCHAR(3)

	PRIMARY KEY (MAGV)
);

GO


CREATE TABLE DIEM
(
	MSSV VARCHAR(10),
	MALOP VARCHAR(10),
	MAMON VARCHAR(10),
	HOCKY VARCHAR(10),
	DIEMGK FLOAT,
	DIEMCK FLOAT,
	DIEMKHAC FLOAT,
	DIEMTONG FLOAT

	PRIMARY KEY (MSSV, MALOP, MAMON, HOCKY)
);

GO


CREATE TABLE MONHOC
(
	MAMON VARCHAR(10),
	TENMON NVARCHAR(40)

	PRIMARY KEY (MAMON)
);

GO


CREATE TABLE LOP
(
	MALOP VARCHAR(10),
	TENLOP NVARCHAR(30)
	
	PRIMARY KEY (MALOP)
);

GO

CREATE TABLE THOIKHOABIEU
(
	MALOP VARCHAR(10),   
    MAMON VARCHAR(10),
    HOCKY VARCHAR(10), --Fall/Spring/Summer
    NAM CHAR(9),
    PHONG CHAR(10),
    CONGKHAIBANGDIEM CHAR(1)

    PRIMARY KEY (MALOP, MAMON, HOCKY)
);

GO




ALTER TABLE SINHVIEN
	ADD CONSTRAINT FK_SINHVIEN_LOP
	FOREIGN KEY (LOP)
	REFERENCES LOP(MALOP)

GO

ALTER TABLE THOIKHOABIEU
	ADD CONSTRAINT FK_THOIKHOABIEU_LOP
    FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
GO

ALTER TABLE THOIKHOABIEU
    ADD CONSTRAINT FK_THOIKHOABIEU_MONHOC
	FOREIGN KEY (MAMON) REFERENCES MONHOC(MAMON)

GO

ALTER TABLE DIEM
	ADD CONSTRAINT FK_DIEM_SINHVIEN
	FOREIGN KEY (MSSV)
	REFERENCES SINHVIEN(MSSV)

GO

ALTER TABLE DIEM
	ADD CONSTRAINT FK_DIEM_THOIKHOABIEU
	FOREIGN KEY (MALOP, MAMON, HOCKY)
	REFERENCES THOIKHOABIEU(MALOP, MAMON, HOCKY)

GO

INSERT INTO LOP(MALOP, TENLOP) VALUES
	('172', '172')

INSERT INTO SINHVIEN(MSSV,CMND,HOTEN,PASS,LOP,NGAYSINH,DIACHI,GIOITINH) VALUES
	('2222','2222','AAAA','29111999','172',CAST('1999-11-29' AS DATE), 'AAA','NAM')
GO


INSERT INTO GIAOVU(MAGV,CMND,HOTEN,PASS,NGAYSINH,DIACHI,GIOITINH) VALUES
	('giaovu','2222','AAAA','giaovu', CAST('1999-11-29' AS DATE), 'AAA','Nam')
GO



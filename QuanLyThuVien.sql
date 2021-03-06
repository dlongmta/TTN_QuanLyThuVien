USE [master]
GO
/****** Object:  Database [BTL_QuanLyThuVien]    Script Date: 11/24/2016 7:41:42 AM ******/
CREATE DATABASE [BTL_QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BTL_QuanLyThuVien', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\BTL_QuanLyThuVien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BTL_QuanLyThuVien_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\BTL_QuanLyThuVien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTL_QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BTL_QuanLyThuVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_checkDG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_checkDG]
@maDG CHAR(10)
AS
BEGIN
SELECT * FROM tblDocGia WHERE MaDG=@maDG
END
GO
/****** Object:  StoredProcedure [dbo].[sp_checkSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_checkSach]
@maSach char(10)
as
begin
select * from tblChiTietMuon where MaSach=@maSach
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DSDauSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DSDauSach]
as
begin
select a.MaDS,a.TenDS,b.TenTL,a.TenTG,a.NXB,str(a.SL1,10)+char(47)+str(a.SL2,3) SoLuong,a.GiaSach from tblDauSach a,tblTheLoai b where a.MaTL=B.MaTL 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DSDocGia]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_DSDocGia]
as
BEGIN
select MaDG,TenDG,GioiTinh,NgaySinh,DiaChi,SDT,DonVi,NgayCapThe,NgayHetHan from tbldocgia
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DSmAdg]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSmAdg]
as
begin
select madg from tblDocGia
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dsmanv]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dsmanv]
as
begin
select manv from tblNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dsMaSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dsMaSach]
@tenDS nvarchar(50)
as
begin
select a.MaSach from tblSach a,tblDauSach b where a.MaDS=b.MaDS and b.TenDS=@tenDS and a.TinhTrangMuon!=N'Đã Mượn'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DSMuonTra]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DSMuonTra]
as
begin
select a.MaMuonTra,d.TenDS,b.MaSach,e.MaDG,e.TenDG,a.NgayMuon,a.HanTra,b.NgayTra,b.GhiChu,(case  when b.NgayTra IS NULL then N'Đã Mượn' else N'Đã Trả' end) as TinhTrang,a.MaNV from tblMuonTra a,tblChiTietMuon b,tblSach c,tblDauSach d,tblDocGia e
where a.MaMuonTra=b.MaMuonTra and b.MaSach=c.MaSach and C.MaDS=D.MaDS and a.MaDG=e.MaDG
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DSNV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DSNV]
as
begin
select * from tblNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DSSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DSSach]
@maDS char(10)
as
begin
select MaSach,TinhTrang,TinhTrangMuon from tblSach where MaDS=@maDS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dstenDS]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dstenDS]
AS
BEGIN
SELECT TENDS FROM TBLDAUSACH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DStenTL]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DStenTL]
as
begin
select TenTL from tblTheLoai
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DSTheLoai]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DSTheLoai]
as
begin
select * from tblTheLoai
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastDG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastDG]
as
begin
SELECT TOP(1) WITH TIES MaDG FROM tblDocGia
ORDER BY MaDG DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastMaDG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastMaDG]
as
begin
SELECT TOP(1) WITH TIES MaDG FROM tblDocGia
ORDER BY MaDG DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastMaDS]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastMaDS]
as
begin
SELECT TOP(1) WITH TIES MaDS FROM tblDauSach
ORDER BY MaDS DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastMaMT]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastMaMT]
as
begin
SELECT TOP(1) WITH TIES MaMuonTra FROM tblMuonTra
ORDER BY MaMuonTra DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastMaNV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastMaNV]
as
begin
SELECT TOP(1) WITH TIES MaNV FROM tblNhanVien
ORDER BY MaNV DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastMaSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastMaSach]
as
begin
SELECT TOP(1) WITH TIES MaSach FROM tblSach
ORDER BY MaSach DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LastMaTL]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LastMaTL]
as
begin
SELECT TOP(1) WITH TIES MaTL FROM tblTheLoai
ORDER BY MaTL DESC
end
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_login]
@maNV char(10),
@ps char(20)
as
begin
select * from tblNhanVien where MaNV=@maNV and pw=@ps
end
GO
/****** Object:  StoredProcedure [dbo].[sp_maTL]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_maTL]
@tenTL nvarchar(50)
as
begin
select MaTL from tblTheLoai WHERE TenTL=@tenTL
end
GO
/****** Object:  StoredProcedure [dbo].[sp_muonSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_muonSach]
@maMT CHAR(10),
@maNV CHAR(10),
@maDG CHAR(10),
@ngayMuon date,
@hanTra date,
@maSach char(10)
as
begin
declare @maDS char(10) set @maDS=(select mads from tblSach where MaSach=@maSach)
update tblSach set TinhTrangMuon=N'Đã Mượn' where MaSach=@maSach
insert into tblMuonTra values(@maMT,@maNV,@maDG,@ngayMuon,@hanTra)
insert into tblChiTietMuon(MaMuonTra,MaSach) values(@maMT,@maSach)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_QuyenHan]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_QuyenHan]
@maNV char(10)
as
begin
select (case PhanQuyen when 'Admin' then 1 else 0 end) from tblNhanVien where MaNV=@maNV
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_chh]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_chh]
@madg char(10),
@ns date
as
begin
update tblDocGia set NgayHetHan=@ns where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_dc]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_dc]
@madg char(10),
@dc nvarchar(50)
as
begin
update tblDocGia set DiaChi=@dc where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_DV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_DV]
@madg char(10),
@DV nvarchar(50)
as
begin
update tblDocGia set DonVi=@DV where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_GT]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_GT]
@madg char(10),
@gioitinh nvarchar(3)
as
begin
update tblDocGia set GioiTinh=@gioitinh where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_nct]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_nct]
@madg char(10),
@ns date
as
begin
update tblDocGia set NgayCapThe=@ns where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_nhh]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_nhh]
@madg char(10),
@ns date
as
begin
update tblDocGia set NgayHetHan=@ns where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_ns]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_ns]
@madg char(10),
@ns date
as
begin
update tblDocGia set NgaySinh=@ns where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_sdt]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_sdt]
@madg char(10),
@sdt nvarchar(50)
as
begin
update tblDocGia set SDT=@sdt where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDG_ten]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDG_ten]
@maDG CHAR(10),
@TENdg nvarchar(50)
as
begin
update tblDocGia set TenDG=@TENdg where MaDG=@maDG
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDS_giasach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDS_giasach]
@mads char(10),
@giasach nvarchar(50)
as
begin
update tblDauSach set GiaSach=@giasach where MaDS=@mads
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDS_nxb]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDS_nxb]
@mads char(10),
@nxb nvarchar(50)
as
begin
update tblDauSach set NXB=@nxb where MaDS=@mads
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDS_ten]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDS_ten]
@maDS char(10),
@tenDS NVARCHAR(50)
AS
begin
update tblDauSach
set TenDS=@tenDS where MaDS=@maDS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDS_TG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDS_TG]
@maDS char(10),
@tg nvarchar(50)
as
begin
update tblDauSach
set TenTG=@tg where MaDS=@maDS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaDS_tl]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaDS_tl]
@maDS CHAR(10),
@MATL CHAR(10)
as
begin
update tblDauSach
set MaTL=@MATL where MaDS=@maDS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaMT_damuon]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaMT_damuon]
@maMT char(10),
@maS char(10),
@maDG char(10),
@maNV char(10),
@ghiChu nvarchar(50),
@nm date,
@hh date
as
begin
update tblChiTietMuon
set MaSach=@maS,GhiChu=@ghiChu where MaMuonTra=@maMT
update tblMuonTra 
set MaDG=@maDG,MaNV=@maNV,NgayMuon=@nm,HanTra=@hh where MaMuonTra=@maMT
UPDATE TBLSACH
SET TinhTrangMuon=N'Đã Mượn' where masach=@maS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaMT_datra]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaMT_datra]
@maMT char(10),
@maS char(10),
@maDG char(10),
@maNV char(10),
@ghiChu nvarchar(50),
@nm date,
@nt date,
@hh date
as
begin
update tblChiTietMuon
set MaSach=@maS,GhiChu=@ghiChu,NgayTra=@nt where MaMuonTra=@maMT
update tblMuonTra 
set MaDG=@maDG,MaNV=@maNV,NgayMuon=@nm,HanTra=@hh where MaMuonTra=@maMT
UPDATE TBLSACH
SET TinhTrangMuon=N'Đã Trả' where masach=@maS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaNV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_suaNV]
@maNV CHAR(10),
@tenNV nvarchar(50),
@gioiTinh nvarchar(3),
@maQuyen CHAR(10),
@pw char(20)
as
begin
update tblNhanVien
set TenNV=@tenNV,GioiTinh=@gioiTinh,PhanQuyen=@maQuyen,pw=@pw where MaNV=@maNV
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaTenTL]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_suaTenTL]
@MaTL char(10),
@TenTL nvarchar(50)
as
begin
update tblTheLoai
set tenTL=@TenTL
where MaTL=@MaTL
end
GO
/****** Object:  StoredProcedure [dbo].[sp_tenDG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_tenDG]
@maDG char(10)
as
begin
select tendg from tblDocGia where MaDG=@maDG
end

GO
/****** Object:  StoredProcedure [dbo].[sp_themDG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themDG]
@maDG char(10),
@tenDG NVARCHAR(50),
@gioitinh nvarchar(50),
@ngaysinh date,
@diachi nvarchar(50),
@sdt char(50),
@nct date,
@nht date,
@donvi nvarchar(50)
as
begin
insert into tblDocGia values(@maDG,@tenDG,@gioitinh,@ngaysinh,@diachi,@sdt,@nct,@nht,@donvi)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemDS]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemDS]
@maDS char(10),
@tenDS nvarchar(50),
@maTL char(10),
@tenTG nvarchar(50),
@nxb nvarchar(50),
@giaSach nvarchar(50),
@sl1 int,
@sl2 int
as
begin
insert into tblDauSach(MaDS,TenDS,MaTL,TenTG,NXB,GiaSach,SL1,SL2) values(@maDS,@tenDS,@maTL,@tenTG,@nxb,@giaSach,@sl1,@sl2)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themMT]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themMT]
@maMT char(10),
@maS char(10),
@maDG char(10),
@maNV char(10),
@ghiChu nvarchar(50),
@nm date,
@hh date
as
begin
insert intO tblMuonTra(MaMuonTra,MaDG,MaNV,NgayMuon,HanTra) VALUES(@maMT,@maDG,@maNV,@nm,@hh)
INSERT INTO tblChiTietMuon(MaMuonTra,MaSach,GhiChu) values(@maMT,@maS,@ghiChu)
UPDATE TBLSACH
SET TinhTrangMuon=N'Đã Mượn' where masach=@maS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themNV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themNV]
@maNV CHAR(10),
@tenNV nvarchar(50),
@gioiTinh nvarchar(3),
@maQuyen CHAR(10),
@pw char(20)
as
begin
insert into tblNhanVien values(@maNV,@tenNV,@gioiTinh,@maQuyen,@pw)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themSach]
@maDS CHAR(10),
@maSach char(10),
@tinhTrang nvarchar(50),
@TinhTrangMuon nvarchar(50)
as
begin
insert into tblSach values(@maSach,@maDS,@tinhTrang,@TinhTrangMuon)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTL]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemTL]
@MaTL char(10),
@TenTL nvarchar(50)
as
begin
insert into tblTheLoai values(@MaTL,@TenTL)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_traSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_traSach]
@maSach char(10),
@ghiChu nvarchar(50),
@ngayTra date
as
begin
declare @maDS char(10) set @maDS=(select mads from tblSach where MaSach=@maSach)
update tblChiTietMuon set NgayTra=@ngayTra,GhiChu=@ghiChu where MaSach=@maSach
update tblSach set TinhTrangMuon=N'Đã Trả' where MaSach=@maSach
update tblDauSach set sl1=sl1+1 where MaDS=@maDS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaDG]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaDG]
@madg char(10)
as

begin
delete from tblDocGia where MaDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaDS]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaDS]
@maDS char(10)
as
begin
delete from tblDauSach
where MaDS=@maDS
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaMT]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaMT]
@maMT CHAR(10)
AS
BEGIN
declare @maS char(10)
set @maS=(select MaSach from TBLCHITIETMUON WHERE MAMUONTRA=@maMT)
UPDATE TBLSACH
SET TinhTrangMuon=N'Không' WHERE MaSach=@maS
DELETE FROM tblChiTietMuon WHERE MaMuonTra=@maMT
DELETE FROM tblMuonTra WHERE MaMuonTra=@maMT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaNV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_xoaNV]
@maNV CHAR(10)
AS
BEGIN
DELETE FROM tblNhanVien WHERE MaNV=@maNV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_xoaSach]
@maSach char(10)
as
begin
delete from tblSach
where MaSach=@maSach
end
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaTL]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xoaTL]
@maTL char(10)
as
begin
delete from tblTheLoai
where maTL=@maTL
end
GO
/****** Object:  StoredProcedure [dbo].[xp_DSNV]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xp_DSNV]
as
begin
select * from tblNhanVien
end
GO
/****** Object:  Table [dbo].[tblChiTietMuon]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietMuon](
	[MaMuonTra] [char](10) NOT NULL,
	[MaSach] [char](10) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [tblChiTietMuon_pk] PRIMARY KEY CLUSTERED 
(
	[MaMuonTra] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDauSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDauSach](
	[MaDS] [char](10) NOT NULL,
	[TenDS] [nvarchar](50) NOT NULL,
	[MaTL] [char](10) NOT NULL,
	[NoiDung] [nvarchar](100) NULL,
	[TenTG] [nvarchar](50) NULL,
	[SoTrang] [int] NULL,
	[NXB] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[GiaSach] [nvarchar](50) NULL,
	[SL1] [int] NULL,
	[SL2] [int] NULL,
 CONSTRAINT [PK__tblDauSa__272586544A06E9CB] PRIMARY KEY CLUSTERED 
(
	[MaDS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[MaDG] [char](10) NOT NULL,
	[TenDG] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](50) NULL,
	[NgayCapThe] [date] NULL,
	[NgayHetHan] [date] NULL,
	[DonVi] [nvarchar](50) NULL,
 CONSTRAINT [PK__tblDocGi__27258660313FF875] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMuonTra]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMuonTra](
	[MaMuonTra] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[MaDG] [char](10) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[HanTra] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMuonTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[PhanQuyen] [char](10) NOT NULL,
	[pw] [char](20) NOT NULL,
 CONSTRAINT [PK__tblNhanV__2725D70A84C6A98E] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSach](
	[MaSach] [char](10) NOT NULL,
	[MaDS] [char](10) NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[TinhTrangMuon] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 11/24/2016 7:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTheLoai](
	[MaTL] [char](10) NOT NULL,
	[TenTL] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000003  ', N'S0000001  ', N'', CAST(0x0E3C0B00 AS Date))
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000004  ', N'S0000001  ', NULL, NULL)
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000005  ', N'S0000006  ', N'', CAST(0x0F3C0B00 AS Date))
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000006  ', N'S0000005  ', NULL, NULL)
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000008  ', N'S0000011  ', N'', CAST(0x123C0B00 AS Date))
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000009  ', N'S0000002  ', NULL, NULL)
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000010  ', N'S0000010  ', NULL, NULL)
INSERT [dbo].[tblChiTietMuon] ([MaMuonTra], [MaSach], [GhiChu], [NgayTra]) VALUES (N'MT000011  ', N'S0000009  ', N'', CAST(0x223C0B00 AS Date))
INSERT [dbo].[tblDauSach] ([MaDS], [TenDS], [MaTL], [NoiDung], [TenTG], [SoTrang], [NXB], [NgayNhap], [GiaSach], [SL1], [SL2]) VALUES (N'DS000001  ', N'Giải Tích 1', N'TL00001   ', NULL, NULL, NULL, NULL, NULL, NULL, 4, 6)
INSERT [dbo].[tblDauSach] ([MaDS], [TenDS], [MaTL], [NoiDung], [TenTG], [SoTrang], [NXB], [NgayNhap], [GiaSach], [SL1], [SL2]) VALUES (N'DS000002  ', N'Giải Tích 2', N'TL00001   ', NULL, NULL, NULL, NULL, NULL, NULL, 5, 6)
INSERT [dbo].[tblDauSach] ([MaDS], [TenDS], [MaTL], [NoiDung], [TenTG], [SoTrang], [NXB], [NgayNhap], [GiaSach], [SL1], [SL2]) VALUES (N'DS000003  ', N'Yêu Em Từ Cái Nhìn Đầu Tiên', N'TL00006   ', NULL, N'Phan Trọng Duy', NULL, NULL, NULL, NULL, 3, 3)
INSERT [dbo].[tblDauSach] ([MaDS], [TenDS], [MaTL], [NoiDung], [TenTG], [SoTrang], [NXB], [NgayNhap], [GiaSach], [SL1], [SL2]) VALUES (N'DS000004  ', N'Doremon', N'TL00004   ', NULL, N'', NULL, N'', NULL, N'0', 5, 5)
INSERT [dbo].[tblDauSach] ([MaDS], [TenDS], [MaTL], [NoiDung], [TenTG], [SoTrang], [NXB], [NgayNhap], [GiaSach], [SL1], [SL2]) VALUES (N'DS000005  ', N'Chí Phèo', N'TL00007   ', NULL, N'', NULL, N'', NULL, N'0', 6, 6)
INSERT [dbo].[tblDauSach] ([MaDS], [TenDS], [MaTL], [NoiDung], [TenTG], [SoTrang], [NXB], [NgayNhap], [GiaSach], [SL1], [SL2]) VALUES (N'DS000006  ', N'Lịch Sử Đảng', N'TL00001   ', NULL, N'', NULL, N'', NULL, N'', 7, 7)
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayCapThe], [NgayHetHan], [DonVi]) VALUES (N'DG00001   ', N'Nguyễn Hữu Huy', N'Nam', CAST(0x0C3C0B00 AS Date), N'1', NULL, CAST(0x0C3C0B00 AS Date), CAST(0x0C3C0B00 AS Date), NULL)
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayCapThe], [NgayHetHan], [DonVi]) VALUES (N'DG00002   ', N'Phan Trọng Duy', N'Nam', CAST(0x0C3C0B00 AS Date), N'', N'                                                  ', CAST(0x0C3C0B00 AS Date), CAST(0x0C3C0B00 AS Date), N'')
INSERT [dbo].[tblDocGia] ([MaDG], [TenDG], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [NgayCapThe], [NgayHetHan], [DonVi]) VALUES (N'DG00003   ', N'Nguyễn Quỳnh Nga', N'Nữ', CAST(0x143C0B00 AS Date), N'11', N'1                                                 ', CAST(0x0C3C0B00 AS Date), CAST(0x0C3C0B00 AS Date), N'')
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000003  ', N'NV00001   ', N'DG00001   ', CAST(0x0E3C0B00 AS Date), CAST(0x0E3C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000004  ', N'NV00001   ', N'DG00003   ', CAST(0x0E3C0B00 AS Date), CAST(0x0E3C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000005  ', N'NV00001   ', N'DG00001   ', CAST(0x0E3C0B00 AS Date), CAST(0x0E3C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000006  ', N'NV00001   ', N'DG00002   ', CAST(0x0E3C0B00 AS Date), CAST(0x0E3C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000008  ', N'nv00001   ', N'DG00003   ', CAST(0x123C0B00 AS Date), CAST(0x123C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000009  ', N'nv00002   ', N'DG00003   ', CAST(0x123C0B00 AS Date), CAST(0x123C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000010  ', N'nv00002   ', N'DG00003   ', CAST(0x123C0B00 AS Date), CAST(0x123C0B00 AS Date))
INSERT [dbo].[tblMuonTra] ([MaMuonTra], [MaNV], [MaDG], [NgayMuon], [HanTra]) VALUES (N'MT000011  ', N'nv00001   ', N'DG00001   ', CAST(0x223C0B00 AS Date), CAST(0x223C0B00 AS Date))
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [PhanQuyen], [pw]) VALUES (N'NV00001   ', N'Admin', N'Nam', N'Admin     ', N'123                 ')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [PhanQuyen], [pw]) VALUES (N'NV00002   ', N'Mod', N'Nữ', N'Admin     ', N'123                 ')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [GioiTinh], [PhanQuyen], [pw]) VALUES (N'NV00004   ', N'Nguyễn Duy Long', N'Nam', N'User      ', N'123                 ')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000001  ', N'DS000001  ', N'Tốt', N'Đã Mượn')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000002  ', N'DS000001  ', N'Tốt', N'Đã Mượn')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000003  ', N'DS000001  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000005  ', N'DS000002  ', N'Tốt', N'Đã Mượn')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000006  ', N'DS000002  ', N'Tốt', N'Đã Trả')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000007  ', N'DS000002  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000009  ', N'DS000003  ', N'Tốt', N'Đã Trả')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000010  ', N'DS000003  ', N'Tốt', N'Đã Mượn')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000011  ', N'DS000003  ', N'Tốt', N'Đã Trả')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000012  ', N'DS000004  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000013  ', N'DS000004  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000014  ', N'DS000004  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000015  ', N'DS000004  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000016  ', N'DS000004  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000017  ', N'DS000002  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000018  ', N'DS000002  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000019  ', N'DS000002  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000021  ', N'DS000001  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000022  ', N'DS000001  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000023  ', N'DS000001  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000024  ', N'DS000005  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000025  ', N'DS000005  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000026  ', N'DS000005  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000027  ', N'DS000005  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000028  ', N'DS000005  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000029  ', N'DS000005  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000030  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000031  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000032  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000033  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000034  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000035  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblSach] ([MaSach], [MaDS], [TinhTrang], [TinhTrangMuon]) VALUES (N'S0000036  ', N'DS000006  ', N'Tốt', N'Không')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00001   ', N'Giáo Trình')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00002   ', N'Truyện Ngắn')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00003   ', N'Tiểu Thuyết')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00004   ', N'Truyện Tranh')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00005   ', N'Khoa Học')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00006   ', N'Ngôn Tình')
INSERT [dbo].[tblTheLoai] ([MaTL], [TenTL]) VALUES (N'TL00007   ', N'Văn Học')
ALTER TABLE [dbo].[tblChiTietMuon]  WITH CHECK ADD  CONSTRAINT [tblChiTietMuon_tblMuonTra_fk] FOREIGN KEY([MaMuonTra])
REFERENCES [dbo].[tblMuonTra] ([MaMuonTra])
GO
ALTER TABLE [dbo].[tblChiTietMuon] CHECK CONSTRAINT [tblChiTietMuon_tblMuonTra_fk]
GO
ALTER TABLE [dbo].[tblChiTietMuon]  WITH CHECK ADD  CONSTRAINT [tblChiTietMuon_tblSach_fk] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblChiTietMuon] CHECK CONSTRAINT [tblChiTietMuon_tblSach_fk]
GO
ALTER TABLE [dbo].[tblDauSach]  WITH CHECK ADD  CONSTRAINT [tblDauSach_tblTheLoai_fk] FOREIGN KEY([MaTL])
REFERENCES [dbo].[tblTheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[tblDauSach] CHECK CONSTRAINT [tblDauSach_tblTheLoai_fk]
GO
ALTER TABLE [dbo].[tblMuonTra]  WITH CHECK ADD  CONSTRAINT [tblMuonTra_tblDocGia_fk] FOREIGN KEY([MaDG])
REFERENCES [dbo].[tblDocGia] ([MaDG])
GO
ALTER TABLE [dbo].[tblMuonTra] CHECK CONSTRAINT [tblMuonTra_tblDocGia_fk]
GO
ALTER TABLE [dbo].[tblMuonTra]  WITH CHECK ADD  CONSTRAINT [tblMuonTra_tblNhanVien_fk] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblMuonTra] CHECK CONSTRAINT [tblMuonTra_tblNhanVien_fk]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [tblSach_tblDauSach_fk] FOREIGN KEY([MaDS])
REFERENCES [dbo].[tblDauSach] ([MaDS])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [tblSach_tblDauSach_fk]
GO
USE [master]
GO
ALTER DATABASE [BTL_QuanLyThuVien] SET  READ_WRITE 
GO

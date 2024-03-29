USE [QLSHOPAOQUAN]
GO
/****** Object:  Table [dbo].[tbl_Quyen]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Quyen](
	[iMaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[sTenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Quyen] PRIMARY KEY CLUSTERED 
(
	[iMaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_taikhoan]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_taikhoan](
	[sMaTK] [int] IDENTITY(1,1) NOT NULL,
	[sTaiKhoan] [nvarchar](50) NOT NULL,
	[sMatKhau] [nvarchar](100) NULL,
	[sEmail] [nvarchar](100) NULL,
	[FK_iMaQuyen] [int] NULL,
 CONSTRAINT [PK_tbl_taikhoan] PRIMARY KEY CLUSTERED 
(
	[sMaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_logic]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_logic]
@user nvarchar(50),
@pass nvarchar(50)
as
BEGIN
	SELECT * FROM tbl_taikhoan WHERE sTaiKhoan = @user AND sMatKhau = @pass
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Retrieve_User]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_Retrieve_User]
as
begin
    select * from Staff
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaNhanVien]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_SuaNhanVien]
@MaNV int,
@TaiKhoan nvarchar(50), 
@MatKhau nvarchar(50)
as
begin
    update Staff 
    set TaiKhoan =@TaiKhoan,
        MatKhau = @MatKhau
    where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemNhanVien]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemNhanVien]
@TaiKhoan nvarchar(50),
@MatKhau nvarchar(50)
as
begin
    Insert into Staff values(@TaiKhoan,@MatKhau)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaNhanVien]    Script Date: 1/6/2024 9:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XoaNhanVien]
@MaNV int
as
begin
    delete Staff where MaNV = @MaNV
end
GO

USE [AdminTest]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 12/11/2015 2:05:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NULL,
	[PerfilId] [int] NULL,
	[password] [varchar](150) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON 

INSERT [dbo].[tblUser] ([Id], [UserName], [PerfilId], [password]) VALUES (1, N'Admin', NULL, N'123')
SET IDENTITY_INSERT [dbo].[tblUser] OFF
/****** Object:  StoredProcedure [dbo].[usp_Login_ValidarLogin]    Script Date: 12/11/2015 2:05:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mario
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[usp_Login_ValidarLogin]
	-- Add the parameters for the stored procedure here
	@Usuario varchar(500),
	@Contrasena varchar(150)
	
AS

Select Id,UserName from tblUser with(nolock) where userName = @Usuario and password=@Contrasena

GO

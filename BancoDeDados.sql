CREATE DATABASE TheSystem
GO

USE [theSystem]
GO
/****** Object:  Table [dbo].[empresas]    Script Date: 26/10/2019 17:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empresas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Razao] [nvarchar](150) NOT NULL,
	[Fantasia] [nvarchar](150) NOT NULL,
	[CNPJ] [nvarchar](150) Unique NOT NULL,
	[Telefone1] [nvarchar](150) NOT NULL,
	[Telefone2] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NOT NULL,
	[Website] [nvarchar](150) NULL,
	[Filial] [nvarchar](150) NULL,
	[Filial_Numero] [nvarchar](150) NULL,
	[CNPJ_Sede] [nvarchar](150) NULL,
	[Rua] [nvarchar](150) NOT NULL,
	[Bairro] [nvarchar](150) NOT NULL,
	[Cidade] [nvarchar](150) NOT NULL,
	[Estado] [nvarchar](150) NOT NULL,
	[Numero] [nvarchar](150) NOT NULL,
	[CEP] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_empresas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionarios]    Script Date: 26/10/2019 17:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](150) NOT NULL,
	[Cargo] [nvarchar](150) NOT NULL,
	[CPF] [nvarchar](150) Unique NOT NULL,
	[CHN] [nvarchar](150)  Unique NOT NULL,
	[Telefone] [nvarchar](150) NULL,
	[Rua] [nvarchar](150) NOT NULL,
	[Bairro] [nvarchar](150) NOT NULL,
	[Cidade] [nvarchar](150) NOT NULL,
	[Estado] [nvarchar](150) NOT NULL,
	[Numero_da_casa] [nvarchar](150) NOT NULL,
	[Numero_Cracha] [nvarchar](150) Unique NOT NULL,
	[CNPJ_Empresa] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_funcionarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

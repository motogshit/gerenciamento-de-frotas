USE [TheSystem]
GO
/****** Object:  Table [dbo].[alugados]    Script Date: 10/11/2019 21:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alugados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[codigo_carro] [int] NOT NULL,
	[Placa_Veiculo] [nvarchar](150) NOT NULL,
	[Codigo_funcionario] [int] NOT NULL,
	[Nome] [nvarchar](150) NOT NULL,
	[Km_Inicial] [nvarchar](150) NOT NULL,
	[Km_Entregue] [nvarchar](150) NULL,
	[status] [nvarchar](150) NOT NULL,
	[Alugado_em] [datetime] NOT NULL,
	[Devolvido_em] [datetime] NULL,
 CONSTRAINT [PK_alugados] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empresas]    Script Date: 10/11/2019 21:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empresas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Razao] [nvarchar](150) NOT NULL,
	[Fantasia] [nvarchar](150) NOT NULL,
	[CNPJ] [nvarchar](150) NOT NULL,
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
	[Adicionado_em] [datetime] NOT NULL,
 CONSTRAINT [PK_empresas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CNPJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionarios]    Script Date: 10/11/2019 21:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](150) NOT NULL,
	[Cargo] [nvarchar](150) NOT NULL,
	[CPF] [nvarchar](150) NOT NULL,
	[CHN] [nvarchar](150) NOT NULL,
	[Telefone] [nvarchar](150) NULL,
	[Rua] [nvarchar](150) NOT NULL,
	[Bairro] [nvarchar](150) NOT NULL,
	[Cidade] [nvarchar](150) NOT NULL,
	[Estado] [nvarchar](150) NOT NULL,
	[Numero_da_casa] [nvarchar](150) NOT NULL,
	[Numero_Cracha] [nvarchar](150) NOT NULL,
	[CNPJ_Empresa] [nvarchar](150) NOT NULL,
	[Adicionado_em] [datetime] NOT NULL,
 CONSTRAINT [PK_funcionarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Numero_Cracha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CHN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recibos]    Script Date: 10/11/2019 21:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recibos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Funcionario] [int] NOT NULL,
	[Nome_Funcionario] [nvarchar](150) NOT NULL,
	[CNPJ] [nvarchar](150) NOT NULL,
	[Razao] [nvarchar](150) NOT NULL,
	[Descricao] [nvarchar](150) NOT NULL,
	[Valor] [float] NOT NULL,
	[data] [datetime] NOT NULL,
 CONSTRAINT [PK_recibos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veiculos]    Script Date: 10/11/2019 21:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veiculos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [nvarchar](150) NOT NULL,
	[Marca] [nvarchar](150) NOT NULL,
	[Ano] [nvarchar](150) NOT NULL,
	[Placa_Veiculo] [nvarchar](150) NOT NULL,
	[Numero_chassi] [nvarchar](150) NOT NULL,
	[Km_Inicial] [nvarchar](150) NOT NULL,
	[Km_Atual] [nvarchar](150) NOT NULL,
	[empresa] [nvarchar](150) NOT NULL,
	[cnpj] [nvarchar](150) NOT NULL,
	[Status] [nvarchar](150) NOT NULL,
	[Adicionado_em] [datetime] NOT NULL,
 CONSTRAINT [PK_veiculos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[alugados] ADD  DEFAULT (getdate()) FOR [Alugado_em]
GO
ALTER TABLE [dbo].[alugados] ADD  DEFAULT (getdate()) FOR [Devolvido_em]
GO
ALTER TABLE [dbo].[empresas] ADD  DEFAULT (getdate()) FOR [Adicionado_em]
GO
ALTER TABLE [dbo].[funcionarios] ADD  DEFAULT (getdate()) FOR [Adicionado_em]
GO
ALTER TABLE [dbo].[recibos] ADD  DEFAULT (getdate()) FOR [data]
GO
ALTER TABLE [dbo].[veiculos] ADD  DEFAULT (getdate()) FOR [Adicionado_em]
GO

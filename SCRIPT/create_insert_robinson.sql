USE [comercial]
GO
/****** Object:  User [comercial]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'comercial')
CREATE USER [comercial] FOR LOGIN [comercial] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [local]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'local')
CREATE USER [local] FOR LOGIN [local] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[TRANSPORTADORA]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TRANSPORTADORA](
	[CNPJ] [varchar](14) NOT NULL,
	[NOME] [varchar](100) NOT NULL,
	[NOMEREDUZIDO] [varchar](100) NOT NULL,
	[ENDERECO] [varchar](100) NOT NULL,
	[NUM] [varchar](40) NOT NULL,
	[COMPLEMENTO] [varchar](40) NULL,
	[BAIRRO] [varchar](100) NOT NULL,
	[UF] [varchar](100) NOT NULL,
	[MUNICIPIO] [varchar](100) NOT NULL,
	[CEP] [varchar](8) NOT NULL,
	[TELEFONE] [varchar](10) NULL,
	[IE] [varchar](11) NOT NULL,
	[EMAIL] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CNPJ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TRANSPORTADORA] ([CNPJ], [NOME], [NOMEREDUZIDO], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [UF], [MUNICIPIO], [CEP], [TELEFONE], [IE], [EMAIL]) VALUES (N'59428815000119', N'Robinson', N'Robinson', N'RUA DOUTOR JOSÉ STILITANO', N'471', NULL, N'PARQUE OURO FINO', N'SP', N'SOROCABA', N'18055680', N'1111111111', N'30195637838', N'rob@uniso.br')
/****** Object:  Table [dbo].[REGIAO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[REGIAO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[REGIAO](
	[CODREGIAO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODREGIAO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[REGIAO] ON
INSERT [dbo].[REGIAO] ([CODREGIAO], [DESCRICAO]) VALUES (1, N'Sorocaba')
SET IDENTITY_INSERT [dbo].[REGIAO] OFF
/****** Object:  Table [dbo].[modelo]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modelo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[modelo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[estrutura] [varchar](100) NOT NULL,
	[dataCriacao] [datetime] NULL,
	[algoritmo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NOTAFISCAL]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NOTAFISCAL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NOTAFISCAL](
	[NrNotaFiscal] [int] NOT NULL,
	[RazaoSocial] [char](100) NULL,
	[Serie] [char](2) NULL,
	[DataEmissao] [datetime] NULL,
	[IE] [varchar](20) NULL,
	[Telefone] [varchar](10) NULL,
	[Endereco] [varchar](100) NULL,
	[Bairro] [varchar](100) NULL,
	[Municipio] [varchar](100) NULL,
	[Icms] [float] NULL,
	[Tipo] [char](1) NULL,
	[CNPJ] [varchar](14) NULL,
	[TipoFrete] [varchar](100) NULL,
	[ValorFrete] [float] NULL,
	[CodVendedor] [varchar](11) NULL,
	[CodTransportadora] [varchar](14) NULL,
	[NrPedido] [int] NULL,
	[ValorNota] [float] NULL,
 CONSTRAINT [PK__NOTAFISC__6197C4BA168449D3] PRIMARY KEY CLUSTERED 
(
	[NrNotaFiscal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NOTAFISCAL] ([NrNotaFiscal], [RazaoSocial], [Serie], [DataEmissao], [IE], [Telefone], [Endereco], [Bairro], [Municipio], [Icms], [Tipo], [CNPJ], [TipoFrete], [ValorFrete], [CodVendedor], [CodTransportadora], [NrPedido], [ValorNota]) VALUES (1, N'Fernando                                                                                            ', N'0 ', CAST(0x00009CD5017174EB AS DateTime), N'100014624117', N'1111111111', N'RUA JOSEPHINA RODRIGUES COLO', N'JARDIM BANDEIRANTES', N'SOROCABA', 18, N'S', N'01117095000190', N'E', 5, N'49848356800', N'59428815000119', 1, 6005)
/****** Object:  Table [dbo].[MODULO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MODULO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MODULO](
	[CODMODULO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODMODULO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ICMS]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ICMS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ICMS](
	[UF] [char](2) NOT NULL,
	[ALIQUOTA] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UF] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ICMS] ([UF], [ALIQUOTA]) VALUES (N'SP', 18)
/****** Object:  Table [dbo].[GRUPOPRODUTO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GRUPOPRODUTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GRUPOPRODUTO](
	[CODGRUPOPRODUTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[DESCONTO] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[CODGRUPOPRODUTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[GRUPOPRODUTO] ON
INSERT [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO], [DESCRICAO], [DESCONTO]) VALUES (1, N'Fresamento', 5)
INSERT [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO], [DESCRICAO], [DESCONTO]) VALUES (2, N'Broca', 10)
SET IDENTITY_INSERT [dbo].[GRUPOPRODUTO] OFF
/****** Object:  Table [dbo].[CONDICAOPAGAMENTO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CONDICAOPAGAMENTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CONDICAOPAGAMENTO](
	[CODCONDICAOPAGAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[QTDEVEZES] [int] NOT NULL,
	[ENTRADA] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODCONDICAOPAGAMENTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CONDICAOPAGAMENTO] ON
INSERT [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO], [DESCRICAO], [QTDEVEZES], [ENTRADA]) VALUES (1, N'60 dias', 2, N'N')
INSERT [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO], [DESCRICAO], [QTDEVEZES], [ENTRADA]) VALUES (2, N'90 dias', 3, N'S')
SET IDENTITY_INSERT [dbo].[CONDICAOPAGAMENTO] OFF
/****** Object:  Table [dbo].[VIATRANSPORTE]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VIATRANSPORTE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VIATRANSPORTE](
	[CODVIATRANSPORTE] [varchar](3) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODVIATRANSPORTE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'aer', N'Aereo')
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'fer', N'Ferroviario')
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'mar', N'Maritimo')
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'ter', N'Terrestre')
/****** Object:  Table [dbo].[USUARIO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USUARIO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[USUARIO](
	[CODUSUARIO] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [varchar](30) NOT NULL,
	[SENHA] [varchar](12) NOT NULL,
	[PRIVILEGIADO] [char](1) NULL,
	[BLOQUEADO] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[CODUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (1, N'admin', N'123', N'S', N'N')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (2, N'system', N'123', N'N', N'N')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (3, N'robinson', N'123', N'N', N'N')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (4, N'fer', N'123', N'N', N'S')
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
/****** Object:  Table [dbo].[UNIDADEMEDIDA]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UNIDADEMEDIDA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UNIDADEMEDIDA](
	[CODUNIDADEMEDIDA] [varchar](3) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODUNIDADEMEDIDA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[UNIDADEMEDIDA] ([CODUNIDADEMEDIDA], [DESCRICAO]) VALUES (N'KG', N'Kilo')
INSERT [dbo].[UNIDADEMEDIDA] ([CODUNIDADEMEDIDA], [DESCRICAO]) VALUES (N'PC', N'Peca')
/****** Object:  Table [dbo].[UF]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UF]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UF](
	[uf_codigo] [float] NULL,
	[uf_sigla] [nvarchar](255) NULL,
	[uf_descricao] [nvarchar](255) NULL
) ON [PRIMARY]
END
GO
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (1, N'AC', N'ACRE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (2, N'AL', N'ALAGOAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (3, N'AP', N'AMAPÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (4, N'AM', N'AMAZONAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (5, N'BA', N'BAHIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (6, N'CE', N'CEARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (7, N'DF', N'DISTRITO FEDERAL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (8, N'ES', N'ESPÍRITO SANTO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (9, N'RR', N'RORAIMA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (10, N'GO', N'GOIÁS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (11, N'MA', N'MARANHÃO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (12, N'MT', N'MATO GROSSO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (13, N'MS', N'MATO GROSSO DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (14, N'MG', N'MINAS GERAIS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (15, N'PA', N'PARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (16, N'PB', N'PARAÍBA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (17, N'PR', N'PARANÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (18, N'PE', N'PERNAMBUCO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (19, N'PI', N'PIAUÍ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (20, N'RJ', N'RIO DE JANEIRO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (21, N'RN', N'RIO GRANDE DO NORTE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (22, N'RS', N'RIO GRANDE DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (23, N'RO', N'RONDÔNIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (24, N'TO', N'TOCANTINS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (25, N'SC', N'SANTA CATARINA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (26, N'SP', N'SÃO PAULO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (27, N'SE', N'SERGIPE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (1, N'AC', N'ACRE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (2, N'AL', N'ALAGOAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (3, N'AP', N'AMAPÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (1, N'AC', N'ACRE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (2, N'AL', N'ALAGOAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (3, N'AP', N'AMAPÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (4, N'AM', N'AMAZONAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (5, N'BA', N'BAHIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (6, N'CE', N'CEARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (7, N'DF', N'DISTRITO FEDERAL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (8, N'ES', N'ESPÍRITO SANTO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (9, N'RR', N'RORAIMA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (10, N'GO', N'GOIÁS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (11, N'MA', N'MARANHÃO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (12, N'MT', N'MATO GROSSO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (13, N'MS', N'MATO GROSSO DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (14, N'MG', N'MINAS GERAIS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (15, N'PA', N'PARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (16, N'PB', N'PARAÍBA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (17, N'PR', N'PARANÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (18, N'PE', N'PERNAMBUCO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (19, N'PI', N'PIAUÍ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (20, N'RJ', N'RIO DE JANEIRO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (21, N'RN', N'RIO GRANDE DO NORTE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (22, N'RS', N'RIO GRANDE DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (23, N'RO', N'RONDÔNIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (24, N'TO', N'TOCANTINS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (25, N'SC', N'SANTA CATARINA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (26, N'SP', N'SÃO PAULO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (27, N'SE', N'SERGIPE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (4, N'AM', N'AMAZONAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (5, N'BA', N'BAHIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (6, N'CE', N'CEARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (7, N'DF', N'DISTRITO FEDERAL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (8, N'ES', N'ESPÍRITO SANTO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (9, N'RR', N'RORAIMA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (10, N'GO', N'GOIÁS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (11, N'MA', N'MARANHÃO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (12, N'MT', N'MATO GROSSO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (13, N'MS', N'MATO GROSSO DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (14, N'MG', N'MINAS GERAIS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (15, N'PA', N'PARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (16, N'PB', N'PARAÍBA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (17, N'PR', N'PARANÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (18, N'PE', N'PERNAMBUCO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (19, N'PI', N'PIAUÍ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (20, N'RJ', N'RIO DE JANEIRO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (21, N'RN', N'RIO GRANDE DO NORTE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (22, N'RS', N'RIO GRANDE DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (23, N'RO', N'RONDÔNIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (24, N'TO', N'TOCANTINS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (25, N'SC', N'SANTA CATARINA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (26, N'SP', N'SÃO PAULO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (27, N'SE', N'SERGIPE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (1, N'AC', N'ACRE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (2, N'AL', N'ALAGOAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (3, N'AP', N'AMAPÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (4, N'AM', N'AMAZONAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (5, N'BA', N'BAHIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (6, N'CE', N'CEARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (7, N'DF', N'DISTRITO FEDERAL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (8, N'ES', N'ESPÍRITO SANTO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (9, N'RR', N'RORAIMA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (10, N'GO', N'GOIÁS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (11, N'MA', N'MARANHÃO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (12, N'MT', N'MATO GROSSO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (13, N'MS', N'MATO GROSSO DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (14, N'MG', N'MINAS GERAIS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (15, N'PA', N'PARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (16, N'PB', N'PARAÍBA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (17, N'PR', N'PARANÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (18, N'PE', N'PERNAMBUCO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (19, N'PI', N'PIAUÍ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (20, N'RJ', N'RIO DE JANEIRO')
GO
print 'Processed 100 total records'
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (21, N'RN', N'RIO GRANDE DO NORTE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (22, N'RS', N'RIO GRANDE DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (23, N'RO', N'RONDÔNIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (24, N'TO', N'TOCANTINS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (25, N'SC', N'SANTA CATARINA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (26, N'SP', N'SÃO PAULO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (27, N'SE', N'SERGIPE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (1, N'AC', N'ACRE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (2, N'AL', N'ALAGOAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (3, N'AP', N'AMAPÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (1, N'AC', N'ACRE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (2, N'AL', N'ALAGOAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (3, N'AP', N'AMAPÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (4, N'AM', N'AMAZONAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (5, N'BA', N'BAHIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (6, N'CE', N'CEARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (7, N'DF', N'DISTRITO FEDERAL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (8, N'ES', N'ESPÍRITO SANTO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (9, N'RR', N'RORAIMA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (10, N'GO', N'GOIÁS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (11, N'MA', N'MARANHÃO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (12, N'MT', N'MATO GROSSO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (13, N'MS', N'MATO GROSSO DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (14, N'MG', N'MINAS GERAIS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (15, N'PA', N'PARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (16, N'PB', N'PARAÍBA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (17, N'PR', N'PARANÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (18, N'PE', N'PERNAMBUCO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (19, N'PI', N'PIAUÍ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (20, N'RJ', N'RIO DE JANEIRO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (21, N'RN', N'RIO GRANDE DO NORTE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (22, N'RS', N'RIO GRANDE DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (23, N'RO', N'RONDÔNIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (24, N'TO', N'TOCANTINS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (25, N'SC', N'SANTA CATARINA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (26, N'SP', N'SÃO PAULO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (27, N'SE', N'SERGIPE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (4, N'AM', N'AMAZONAS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (5, N'BA', N'BAHIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (6, N'CE', N'CEARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (7, N'DF', N'DISTRITO FEDERAL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (8, N'ES', N'ESPÍRITO SANTO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (9, N'RR', N'RORAIMA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (10, N'GO', N'GOIÁS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (11, N'MA', N'MARANHÃO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (12, N'MT', N'MATO GROSSO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (13, N'MS', N'MATO GROSSO DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (14, N'MG', N'MINAS GERAIS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (15, N'PA', N'PARÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (16, N'PB', N'PARAÍBA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (17, N'PR', N'PARANÁ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (18, N'PE', N'PERNAMBUCO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (19, N'PI', N'PIAUÍ')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (20, N'RJ', N'RIO DE JANEIRO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (21, N'RN', N'RIO GRANDE DO NORTE')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (22, N'RS', N'RIO GRANDE DO SUL')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (23, N'RO', N'RONDÔNIA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (24, N'TO', N'TOCANTINS')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (25, N'SC', N'SANTA CATARINA')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (26, N'SP', N'SÃO PAULO')
INSERT [dbo].[UF] ([uf_codigo], [uf_sigla], [uf_descricao]) VALUES (27, N'SE', N'SERGIPE')
/****** Object:  Table [dbo].[ItemNotaFiscal]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemNotaFiscal]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemNotaFiscal](
	[Descricao] [varchar](100) NULL,
	[Quantidade] [int] NULL,
	[Desconto] [float] NULL,
	[Valor] [float] NULL,
	[IPI] [float] NULL,
	[CodProduto] [int] NOT NULL,
	[CodUnidadeMedida] [varchar](3) NULL,
	[NrNotaFiscal] [int] NOT NULL,
	[QuantidadeDev] [int] NULL,
 CONSTRAINT [PK_ItemNotaFiscal] PRIMARY KEY CLUSTERED 
(
	[NrNotaFiscal] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ItemNotaFiscal] ([Descricao], [Quantidade], [Desconto], [Valor], [IPI], [CodProduto], [CodUnidadeMedida], [NrNotaFiscal], [QuantidadeDev]) VALUES (N'P1', 5, 5, 1000, 7, 1, N'KG', 1, NULL)
/****** Object:  Table [dbo].[TRANSPORTADORAVIA]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TRANSPORTADORAVIA](
	[CODVIATRANSPORTE] [varchar](3) NOT NULL,
	[CODTRANSPORTADORA] [varchar](14) NOT NULL,
 CONSTRAINT [PK_TRANSPORTADORAVIA] PRIMARY KEY CLUSTERED 
(
	[CODVIATRANSPORTE] ASC,
	[CODTRANSPORTADORA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TRANSPORTADORAVIA] ([CODVIATRANSPORTE], [CODTRANSPORTADORA]) VALUES (N'fer', N'59428815000119')
INSERT [dbo].[TRANSPORTADORAVIA] ([CODVIATRANSPORTE], [CODTRANSPORTADORA]) VALUES (N'mar', N'59428815000119')
/****** Object:  Table [dbo].[VENDEDOR]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VENDEDOR]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VENDEDOR](
	[CPF] [varchar](11) NOT NULL,
	[NOME] [varchar](100) NOT NULL,
	[ENDERECO] [varchar](100) NOT NULL,
	[NUM] [varchar](40) NOT NULL,
	[COMPLEMENTO] [varchar](40) NULL,
	[BAIRRO] [varchar](100) NOT NULL,
	[MUNICIPIO] [varchar](100) NOT NULL,
	[UF] [char](2) NOT NULL,
	[CEP] [varchar](8) NOT NULL,
	[TELEFONE] [varchar](10) NULL,
	[CELULAR] [varchar](10) NULL,
	[FAX] [varchar](10) NULL,
	[RG] [varchar](9) NOT NULL,
	[CODUSUARIO] [int] NULL,
	[EMAIL] [varchar](100) NULL,
	[COMISSAO] [float] NULL,
	[ATIVO] [char](1) NULL,
	[SEXO] [char](1) NULL,
	[CODREGIAO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[VENDEDOR] ([CPF], [NOME], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [TELEFONE], [CELULAR], [FAX], [RG], [CODUSUARIO], [EMAIL], [COMISSAO], [ATIVO], [SEXO], [CODREGIAO]) VALUES (N'49848356800', N'Robinson Luz', N'RUA DOUTOR JOSÉ STILITANO', N'-471', NULL, N'PARQUE OURO FINO', N'SOROCABA', N'SP', N'18055680', N'5555555555', N'5555555555', N'5555555555', N'111111111', 3, N'robinson@uniso.br', 3, N'S', N'M', 1)
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLIENTE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLIENTE](
	[CNPJ] [varchar](14) NOT NULL,
	[RAZAOSOCIAL] [varchar](100) NOT NULL,
	[NOMEFANTASIA] [varchar](100) NOT NULL,
	[TELEFONE] [varchar](10) NULL,
	[FAX] [varchar](10) NULL,
	[EMAIL] [varchar](100) NULL,
	[IE] [varchar](20) NULL,
	[ENDERECO] [varchar](100) NOT NULL,
	[NUM] [varchar](40) NOT NULL,
	[COMPLEMENTO] [varchar](40) NULL,
	[BAIRRO] [varchar](100) NOT NULL,
	[MUNICIPIO] [varchar](100) NOT NULL,
	[UF] [char](2) NOT NULL,
	[CEP] [varchar](8) NOT NULL,
	[CODREGIAO] [int] NULL,
	[CODUSUARIO] [int] NULL,
	[AREAATUACAO] [varchar](100) NULL,
	[LIMITECRED] [float] NULL,
	[APROVADOCRED] [char](1) NULL,
	[ATIVO] [char](1) NULL,
 CONSTRAINT [PK__CLIENTE__AA57D6B549E3F248] PRIMARY KEY CLUSTERED 
(
	[CNPJ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'01117095000190', N'Fernando', N'Fernando', N'1111111111', N'1111111111', N'fer@beilke.com.br', N'100014624117', N'RUA JOSEPHINA RODRIGUES COLO', N'358', NULL, N'JARDIM BANDEIRANTES', N'SOROCABA', N'SP', N'18017127', 1, 4, N'FERRAMENTAS', 50000, N'S', NULL)
/****** Object:  Table [dbo].[ATUCUBO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ATUCUBO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ATUCUBO](
	[NRATUALIZACAO] [int] IDENTITY(1,1) NOT NULL,
	[CODUSUARIO] [int] NOT NULL,
	[DATAATUALIZACAO] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[NRATUALIZACAO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[ATUCUBO] ON
INSERT [dbo].[ATUCUBO] ([NRATUALIZACAO], [CODUSUARIO], [DATAATUALIZACAO]) VALUES (1, 1, CAST(0x00009CD500000000 AS DateTime))
INSERT [dbo].[ATUCUBO] ([NRATUALIZACAO], [CODUSUARIO], [DATAATUALIZACAO]) VALUES (2, 1, CAST(0x00009CD800000000 AS DateTime))
INSERT [dbo].[ATUCUBO] ([NRATUALIZACAO], [CODUSUARIO], [DATAATUALIZACAO]) VALUES (3, 1, CAST(0x00009CD900000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[ATUCUBO] OFF
/****** Object:  Table [dbo].[ACESSO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ACESSO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ACESSO](
	[CODMODULO] [int] NOT NULL,
	[CODUSUARIO] [int] NOT NULL,
 CONSTRAINT [PK_ACESSO] PRIMARY KEY CLUSTERED 
(
	[CODMODULO] ASC,
	[CODUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[modeloCampo]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modeloCampo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[modeloCampo](
	[idModelo] [int] NOT NULL,
	[campo] [varchar](100) NOT NULL,
	[tipo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idModelo] ASC,
	[campo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PRODUTO](
	[CODPRODUTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[DATACADASTRO] [datetime] NOT NULL,
	[PRECOCUSTO] [float] NOT NULL,
	[PESOLIQUIDO] [float] NOT NULL,
	[CODGRUPOPRODUTO] [int] NOT NULL,
	[PRECOVENDA] [float] NOT NULL,
	[ESTOQUEATUAL] [float] NULL,
	[ESTOQUEMIN] [float] NULL,
	[IPI] [float] NULL,
	[ATIVO] [char](1) NULL,
	[CODUNIDADEMEDIDA] [varchar](3) NOT NULL,
 CONSTRAINT [PK__PRODUTO__6AE10B5B4DB4832C] PRIMARY KEY CLUSTERED 
(
	[CODPRODUTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUTO] ON
INSERT [dbo].[PRODUTO] ([CODPRODUTO], [DESCRICAO], [DATACADASTRO], [PRECOCUSTO], [PESOLIQUIDO], [CODGRUPOPRODUTO], [PRECOVENDA], [ESTOQUEATUAL], [ESTOQUEMIN], [IPI], [ATIVO], [CODUNIDADEMEDIDA]) VALUES (1, N'P1', CAST(0x00009CD50168E2BC AS DateTime), 800, 25, 1, 900, 8, 10, 7, NULL, N'KG')
INSERT [dbo].[PRODUTO] ([CODPRODUTO], [DESCRICAO], [DATACADASTRO], [PRECOCUSTO], [PESOLIQUIDO], [CODGRUPOPRODUTO], [PRECOVENDA], [ESTOQUEATUAL], [ESTOQUEMIN], [IPI], [ATIVO], [CODUNIDADEMEDIDA]) VALUES (2, N'P2', CAST(0x00009CD5016D6BA7 AS DateTime), 80, 2, 2, 100, 2, 5, 5, NULL, N'PC')
SET IDENTITY_INSERT [dbo].[PRODUTO] OFF
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PEDIDO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PEDIDO](
	[NRPEDIDO] [int] IDENTITY(1,1) NOT NULL,
	[TIPO] [char](1) NOT NULL,
	[DATAEMISSAO] [datetime] NULL,
	[DATAENTREGA] [datetime] NULL,
	[CODCONDICAOPAGAMENTO] [int] NOT NULL,
	[SITUACAO] [char](1) NULL,
	[CODVENDEDOR] [varchar](11) NOT NULL,
	[CODCLIENTE] [varchar](14) NOT NULL,
	[CODTRANSPORTADORA] [varchar](14) NOT NULL,
	[VALORFRETE] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[NRPEDIDO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PEDIDO] ON
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA], [VALORFRETE]) VALUES (1, N'N', CAST(0x00009CD500000000 AS DateTime), CAST(0x00009CD500000000 AS DateTime), 1, N'E', N'49848356800', N'01117095000190', N'59428815000119', 5)
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA], [VALORFRETE]) VALUES (2, N'N', CAST(0x00009CD500000000 AS DateTime), CAST(0x00009CD500000000 AS DateTime), 2, N'E', N'49848356800', N'01117095000190', N'59428815000119', 34)
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA], [VALORFRETE]) VALUES (3, N'N', CAST(0x00009CD500000000 AS DateTime), CAST(0x00009CD500000000 AS DateTime), 1, N'E', N'49848356800', N'01117095000190', N'59428815000119', 50)
SET IDENTITY_INSERT [dbo].[PEDIDO] OFF
/****** Object:  Table [dbo].[ITEMPEDIDO]    Script Date: 12/08/2009 21:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ITEMPEDIDO](
	[ITEM] [int] NOT NULL,
	[NRPEDIDO] [int] NOT NULL,
	[CODPRODUTO] [int] NOT NULL,
	[QUANTIDADE] [int] NOT NULL,
	[DESCONTO] [float] NULL,
	[VALOR] [float] NOT NULL,
	[IPI] [float] NULL,
	[QUANTIDADELIB] [int] NULL,
 CONSTRAINT [PK_ITEMPEDIDO] PRIMARY KEY CLUSTERED 
(
	[NRPEDIDO] ASC,
	[CODPRODUTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[ITEMPEDIDO] ([ITEM], [NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI], [QUANTIDADELIB]) VALUES (1, 1, 1, 5, 5, 1000, 7, 5)
INSERT [dbo].[ITEMPEDIDO] ([ITEM], [NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI], [QUANTIDADELIB]) VALUES (1, 2, 2, 5, 10, 100, 5, 5)
INSERT [dbo].[ITEMPEDIDO] ([ITEM], [NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI], [QUANTIDADELIB]) VALUES (1, 3, 2, 18, 10, 100, 5, 18)
/****** Object:  View [dbo].[vw_trimestre]    Script Date: 12/08/2009 21:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_trimestre]'))
EXEC dbo.sp_executesql @statement = N'
CREATE view [dbo].[vw_trimestre] as      
select cast(floor(CAST(DATAEMISSAO as float)) as datetime) dia ,   COUNT(*)quant from PEDIDO      
where MONTH(DATAEMISSAO) > 9      
group by cast(floor(CAST(DATAEMISSAO as float)) as datetime)'
GO
/****** Object:  View [dbo].[VW_QTDE_VENDAS]    Script Date: 12/08/2009 21:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VW_QTDE_VENDAS]'))
EXEC dbo.sp_executesql @statement = N'create view [dbo].[VW_QTDE_VENDAS] as
select dataemissao, COUNT(nrpedido) qtde_pedido
from PEDIDO
group by dataemissao'
GO
/****** Object:  View [dbo].[VW_VENDA_REGIAO_PRODUTO_FATO]    Script Date: 12/08/2009 21:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VW_VENDA_REGIAO_PRODUTO_FATO]'))
EXEC dbo.sp_executesql @statement = N'/*    
 VIEW VENDAS POR REGIAO E PRODUTO    
*/    
    
CREATE view [dbo].[VW_VENDA_REGIAO_PRODUTO_FATO] as      
select c.CNPJ,c.RAZAOSOCIAL cliente,v.CPF cpf_ven, v.NOME nome_ven,
  r.DESCRICAO regiao,po.DESCRICAO produto,g.DESCRICAO grupo,DATAEMISSAO As data,    
COUNT(*) as quant_produto, SUM(i.VALOR*QUANTIDADE)valor       
from PEDIDO p inner join ITEMPEDIDO i on p.NRPEDIDO = i.NRPEDIDO      
        inner join PRODUTO po on po.CODPRODUTO = i.CODPRODUTO      
        inner join CLIENTE c on c.CNPJ = p.CODCLIENTE      
        inner join REGIAO r on r.CODREGIAO = c.CODREGIAO      
        inner join GRUPOPRODUTO g on g.CODGRUPOPRODUTO = po.CODGRUPOPRODUTO  
        inner join VENDEDOR v on v.CPF = p.CODVENDEDOR  
            
group by c.CNPJ,c.RAZAOSOCIAL ,v.CPF , v.NOME ,
  r.DESCRICAO,po.DESCRICAO ,g.DESCRICAO ,DATAEMISSAO    
          
          
          '
GO
/****** Object:  View [dbo].[VW_VENDA_REGIAO_PRODUTO]    Script Date: 12/08/2009 21:45:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VW_VENDA_REGIAO_PRODUTO]'))
EXEC dbo.sp_executesql @statement = N'CREATE view [dbo].[VW_VENDA_REGIAO_PRODUTO] as        
select  r.DESCRICAO regiao,po.DESCRICAO produto, COUNT(*) as quant_produto     
from PEDIDO p inner join ITEMPEDIDO i on p.NRPEDIDO = i.NRPEDIDO        
        inner join PRODUTO po on po.CODPRODUTO = i.CODPRODUTO        
        inner join CLIENTE c on c.CNPJ = p.CODCLIENTE        
        inner join REGIAO r on r.CODREGIAO = c.CODREGIAO        
        inner join GRUPOPRODUTO g on g.CODGRUPOPRODUTO = po.CODGRUPOPRODUTO    
        inner join VENDEDOR v on v.CPF = p.CODVENDEDOR    
              
group by r.DESCRICAO,po.DESCRICAO      
            '
GO
/****** Object:  Check [cliente_bairro_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_bairro_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_bairro_empty] CHECK  (([bairro]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_bairro_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_bairro_empty]
GO
/****** Object:  Check [cliente_cep_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_cep_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_cep_empty] CHECK  (([cep]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_cep_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_cep_empty]
GO
/****** Object:  Check [cliente_endereco_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_endereco_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_endereco_empty] CHECK  (([endereco]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_endereco_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_endereco_empty]
GO
/****** Object:  Check [cliente_ie_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_ie_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_ie_empty] CHECK  (([ie]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_ie_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_ie_empty]
GO
/****** Object:  Check [cliente_municipio_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_municipio_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_municipio_empty] CHECK  (([cep]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_municipio_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_municipio_empty]
GO
/****** Object:  Check [cliente_nomefantasia_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_nomefantasia_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_nomefantasia_empty] CHECK  (([nomefantasia]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_nomefantasia_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_nomefantasia_empty]
GO
/****** Object:  Check [cliente_num_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_num_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_num_empty] CHECK  (([num]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_num_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_num_empty]
GO
/****** Object:  Check [cliente_razaosocial_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_razaosocial_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_razaosocial_empty] CHECK  (([razaosocial]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_razaosocial_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_razaosocial_empty]
GO
/****** Object:  Check [cliente_uf_empty]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_uf_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_uf_empty] CHECK  (([uf]<>''))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_uf_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_uf_empty]
GO
/****** Object:  ForeignKey [FK_ACESSO_MODULO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_MODULO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO]  WITH CHECK ADD  CONSTRAINT [FK_ACESSO_MODULO] FOREIGN KEY([CODMODULO])
REFERENCES [dbo].[MODULO] ([CODMODULO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_MODULO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO] CHECK CONSTRAINT [FK_ACESSO_MODULO]
GO
/****** Object:  ForeignKey [FK_ACESSO_USUARIO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO]  WITH CHECK ADD  CONSTRAINT [FK_ACESSO_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO] CHECK CONSTRAINT [FK_ACESSO_USUARIO]
GO
/****** Object:  ForeignKey [FK_ATUCUBO_USUARIO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ATUCUBO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ATUCUBO]'))
ALTER TABLE [dbo].[ATUCUBO]  WITH CHECK ADD  CONSTRAINT [FK_ATUCUBO_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ATUCUBO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ATUCUBO]'))
ALTER TABLE [dbo].[ATUCUBO] CHECK CONSTRAINT [FK_ATUCUBO_USUARIO]
GO
/****** Object:  ForeignKey [FK_CLIENTE_REGIAO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_REGIAO] FOREIGN KEY([CODREGIAO])
REFERENCES [dbo].[REGIAO] ([CODREGIAO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_REGIAO]
GO
/****** Object:  ForeignKey [FK_CLIENTE_USUARIO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_USUARIO]
GO
/****** Object:  ForeignKey [FK_ItemNotaFiscal_NOTA_FISCAL]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItemNotaFiscal_NOTA_FISCAL]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItemNotaFiscal]'))
ALTER TABLE [dbo].[ItemNotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_ItemNotaFiscal_NOTA_FISCAL] FOREIGN KEY([NrNotaFiscal])
REFERENCES [dbo].[NOTAFISCAL] ([NrNotaFiscal])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItemNotaFiscal_NOTA_FISCAL]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItemNotaFiscal]'))
ALTER TABLE [dbo].[ItemNotaFiscal] CHECK CONSTRAINT [FK_ItemNotaFiscal_NOTA_FISCAL]
GO
/****** Object:  ForeignKey [FK_ITEMPEDIDO_PEDIDO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PEDIDO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_ITEMPEDIDO_PEDIDO] FOREIGN KEY([NRPEDIDO])
REFERENCES [dbo].[PEDIDO] ([NRPEDIDO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PEDIDO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO] CHECK CONSTRAINT [FK_ITEMPEDIDO_PEDIDO]
GO
/****** Object:  ForeignKey [FK_ITEMPEDIDO_PRODUTO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PRODUTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_ITEMPEDIDO_PRODUTO] FOREIGN KEY([CODPRODUTO])
REFERENCES [dbo].[PRODUTO] ([CODPRODUTO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PRODUTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO] CHECK CONSTRAINT [FK_ITEMPEDIDO_PRODUTO]
GO
/****** Object:  ForeignKey [FK_modelo_modeloCampo]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelo_modeloCampo]') AND parent_object_id = OBJECT_ID(N'[dbo].[modeloCampo]'))
ALTER TABLE [dbo].[modeloCampo]  WITH CHECK ADD  CONSTRAINT [FK_modelo_modeloCampo] FOREIGN KEY([idModelo])
REFERENCES [dbo].[modelo] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelo_modeloCampo]') AND parent_object_id = OBJECT_ID(N'[dbo].[modeloCampo]'))
ALTER TABLE [dbo].[modeloCampo] CHECK CONSTRAINT [FK_modelo_modeloCampo]
GO
/****** Object:  ForeignKey [FK_PEDIDO_CLIENTE]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_CLIENTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_CLIENTE] FOREIGN KEY([CODCLIENTE])
REFERENCES [dbo].[CLIENTE] ([CNPJ])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_CLIENTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_CLIENTE]
GO
/****** Object:  ForeignKey [FK_PEDIDO_PAGAMENTO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_PAGAMENTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_PAGAMENTO] FOREIGN KEY([CODCONDICAOPAGAMENTO])
REFERENCES [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_PAGAMENTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_PAGAMENTO]
GO
/****** Object:  ForeignKey [FK_PEDIDO_TRANSPORTADORA]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_TRANSPORTADORA] FOREIGN KEY([CODTRANSPORTADORA])
REFERENCES [dbo].[TRANSPORTADORA] ([CNPJ])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_TRANSPORTADORA]
GO
/****** Object:  ForeignKey [FK_PEDIDO_VENDEDOR]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_VENDEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_VENDEDOR] FOREIGN KEY([CODVENDEDOR])
REFERENCES [dbo].[VENDEDOR] ([CPF])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_VENDEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_VENDEDOR]
GO
/****** Object:  ForeignKey [FK_PRODUTO_GRUPO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_GRUPO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTO_GRUPO] FOREIGN KEY([CODGRUPOPRODUTO])
REFERENCES [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_GRUPO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] CHECK CONSTRAINT [FK_PRODUTO_GRUPO]
GO
/****** Object:  ForeignKey [FK_PRODUTO_UNIDADE_MEDIDA]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_UNIDADE_MEDIDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTO_UNIDADE_MEDIDA] FOREIGN KEY([CODUNIDADEMEDIDA])
REFERENCES [dbo].[UNIDADEMEDIDA] ([CODUNIDADEMEDIDA])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_UNIDADE_MEDIDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] CHECK CONSTRAINT [FK_PRODUTO_UNIDADE_MEDIDA]
GO
/****** Object:  ForeignKey [FK_TRANSPORTADORAVIA_TRANSPORTADORA]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA]  WITH CHECK ADD  CONSTRAINT [FK_TRANSPORTADORAVIA_TRANSPORTADORA] FOREIGN KEY([CODTRANSPORTADORA])
REFERENCES [dbo].[TRANSPORTADORA] ([CNPJ])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA] CHECK CONSTRAINT [FK_TRANSPORTADORAVIA_TRANSPORTADORA]
GO
/****** Object:  ForeignKey [FK_TRANSPORTADORAVIA_VIATRANSPORTE]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_VIATRANSPORTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA]  WITH CHECK ADD  CONSTRAINT [FK_TRANSPORTADORAVIA_VIATRANSPORTE] FOREIGN KEY([CODVIATRANSPORTE])
REFERENCES [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_VIATRANSPORTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA] CHECK CONSTRAINT [FK_TRANSPORTADORAVIA_VIATRANSPORTE]
GO
/****** Object:  ForeignKey [FK_VENDEDOR_REGIAO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [FK_VENDEDOR_REGIAO] FOREIGN KEY([CODREGIAO])
REFERENCES [dbo].[REGIAO] ([CODREGIAO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [FK_VENDEDOR_REGIAO]
GO
/****** Object:  ForeignKey [FK_VENDEDOR_USUARIO]    Script Date: 12/08/2009 21:45:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [FK_VENDEDOR_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [FK_VENDEDOR_USUARIO]
GO

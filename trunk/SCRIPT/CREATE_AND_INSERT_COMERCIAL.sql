USE [COMERCIAL]
GO
/****** Object:  Table [dbo].[TRANSPORTADORA]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TRANSPORTADORA] ([CNPJ], [NOME], [NOMEREDUZIDO], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [UF], [MUNICIPIO], [CEP], [TELEFONE], [IE], [EMAIL]) VALUES (N'00525056000160', N'Ocean Cargas', N'Ocean', N'Av. Trabalhadores Unidos', N'189', NULL, N'Centro', N'SP', N'Campinas', N'18144400', N'1989652357', N'36598745691', N'ocean@gmail.com')
INSERT [dbo].[TRANSPORTADORA] ([CNPJ], [NOME], [NOMEREDUZIDO], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [UF], [MUNICIPIO], [CEP], [TELEFONE], [IE], [EMAIL]) VALUES (N'07608749000165', N'Três Irmãos Trasnportadora', N'Três Irmãos', N'Rua Carlos Mattos', N'1090', NULL, N'Campolim', N'SP', N'Sorocaba', N'18133300', N'1522222328', N'21211211121', N'tresirmaos@tresirmaos')
/****** Object:  Table [dbo].[REGIAO]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REGIAO](
	[CODREGIAO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODREGIAO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[REGIAO] ON
INSERT [dbo].[REGIAO] ([CODREGIAO], [DESCRICAO]) VALUES (1, N'Sorocaba')
INSERT [dbo].[REGIAO] ([CODREGIAO], [DESCRICAO]) VALUES (2, N'Campinas')
INSERT [dbo].[REGIAO] ([CODREGIAO], [DESCRICAO]) VALUES (3, N'Triangulo Mineiro')
INSERT [dbo].[REGIAO] ([CODREGIAO], [DESCRICAO]) VALUES (4, N'Ribeirão Preto')
INSERT [dbo].[REGIAO] ([CODREGIAO], [DESCRICAO]) VALUES (5, N'Grande São Paulo')
SET IDENTITY_INSERT [dbo].[REGIAO] OFF
/****** Object:  Table [dbo].[ICMS]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ICMS](
	[UF] [char](2) NOT NULL,
	[ALIQUOTA] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UF] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GRUPOPRODUTO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GRUPOPRODUTO](
	[CODGRUPOPRODUTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
	[DESCONTO] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[CODGRUPOPRODUTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[GRUPOPRODUTO] ON
INSERT [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO], [DESCRICAO], [DESCONTO]) VALUES (1, N'Torneamento', 10)
INSERT [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO], [DESCRICAO], [DESCONTO]) VALUES (2, N'Furação', 5)
INSERT [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO], [DESCRICAO], [DESCONTO]) VALUES (3, N'Broca', 20)
INSERT [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO], [DESCRICAO], [DESCONTO]) VALUES (4, N'Fresa', 5)
SET IDENTITY_INSERT [dbo].[GRUPOPRODUTO] OFF
/****** Object:  Table [dbo].[CONDICAOPAGAMENTO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CONDICAOPAGAMENTO] ON
INSERT [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO], [DESCRICAO], [QTDEVEZES], [ENTRADA]) VALUES (1, N'30 dias', 1, N'N')
INSERT [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO], [DESCRICAO], [QTDEVEZES], [ENTRADA]) VALUES (3, N'30,60,90 dias c/ entrada', 3, N'S')
INSERT [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO], [DESCRICAO], [QTDEVEZES], [ENTRADA]) VALUES (4, N'A vista', 1, N'S')
SET IDENTITY_INSERT [dbo].[CONDICAOPAGAMENTO] OFF
/****** Object:  Table [dbo].[NOTAFISCAL]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NOTAFISCAL](
	[NrNotaFiscal] [int] NOT NULL,
	[RazaoSocial] [char](100) NULL,
	[Serie] [char](2) NULL,
	[DataEmissao] [datetime] NULL,
	[IE] [varchar](11) NULL,
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
PRIMARY KEY CLUSTERED 
(
	[NrNotaFiscal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MODULO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MODULO](
	[CODMODULO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODMODULO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MODULO] ON
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (1, N'FRMCADCLI')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (2, N'FRMCONPAG')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (3, N'FRMCADGRPPROD')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (4, N'FRMCADPED')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (5, N'FRMCADPROD')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (6, N'FRMCADTRA')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (7, N'FRMCADUNIMED')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (8, N'FRMCADUSU')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (9, N'FRMCADVEN')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (10, N'FRMALTSEN')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (11, N'FRMCONCLI')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (12, N'FRMCONPDV')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (13, N'FRMCONPROD')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (14, N'FRMCONVEN')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (15, N'FRMDEVNOTAFISCAL')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (16, N'FRMEMINOTFIS')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (17, N'FRMLIBPDV')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (18, N'FRMLOGIN')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (19, N'FRMPESNOTFIS')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (20, N'FRMPRINC')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (21, N'FRMRELGERAL')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (22, N'FRMSOBRE')
INSERT [dbo].[MODULO] ([CODMODULO], [DESCRICAO]) VALUES (23, N'FRMVISGERAL')
SET IDENTITY_INSERT [dbo].[MODULO] OFF
/****** Object:  Table [dbo].[USUARIO]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (1, N'admin', N'123', N'S', N'N')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (2, N'Claudio Branco', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (3, N'aluminio', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (4, N'arcom', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (5, N'agrotools', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (6, N'petronorte', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (7, N'santher', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (8, N'kabum', N'125', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (9, N'hiptol', N'123', N'N', N'S')
INSERT [dbo].[USUARIO] ([CODUSUARIO], [USUARIO], [SENHA], [PRIVILEGIADO], [BLOQUEADO]) VALUES (10, N'tetstsbhsg', N'123', N'N', N'S')
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
/****** Object:  Table [dbo].[UNIDADEMEDIDA]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UNIDADEMEDIDA](
	[CODUNIDADEMEDIDA] [varchar](3) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODUNIDADEMEDIDA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[UNIDADEMEDIDA] ([CODUNIDADEMEDIDA], [DESCRICAO]) VALUES (N'KG', N'Quilograma')
INSERT [dbo].[UNIDADEMEDIDA] ([CODUNIDADEMEDIDA], [DESCRICAO]) VALUES (N'pç', N'Peça')
/****** Object:  Table [dbo].[VIATRANSPORTE]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VIATRANSPORTE](
	[CODVIATRANSPORTE] [varchar](3) NOT NULL,
	[DESCRICAO] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODVIATRANSPORTE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'aer', N'Aéreo')
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'mar', N'Marítimo')
INSERT [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE], [DESCRICAO]) VALUES (N'ter', N'Terrestre')
/****** Object:  Table [dbo].[ItemNotaFiscal]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemNotaFiscal](
	[Descricao] [varchar](100) NULL,
	[Quantidade] [int] NULL,
	[Desconto] [float] NULL,
	[Valor] [float] NULL,
	[IPI] [float] NULL,
	[CodProduto] [int] NOT NULL,
	[CodUnidadeMedida] [varchar](3) NULL,
	[NrNotaFiscal] [int] NOT NULL,
 CONSTRAINT [PK_ItemNotaFiscal] PRIMARY KEY CLUSTERED 
(
	[NrNotaFiscal] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDEDOR]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[VENDEDOR] ([CPF], [NOME], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [TELEFONE], [CELULAR], [FAX], [RG], [CODUSUARIO], [EMAIL], [COMISSAO], [ATIVO], [SEXO], [CODREGIAO]) VALUES (N'26589654878', N'Maria', N'Rua das Flores', N'96', NULL, N'Roselandia', N'Cotia', N'SP', N'25698365', N'1198568745', N'1191212568', NULL, N'569874523', 1, N'maria@maria.com', 2.5, NULL, N'F', 2)
INSERT [dbo].[VENDEDOR] ([CPF], [NOME], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [TELEFONE], [CELULAR], [FAX], [RG], [CODUSUARIO], [EMAIL], [COMISSAO], [ATIVO], [SEXO], [CODREGIAO]) VALUES (N'31838427856', N'Claudio', N'Av. Vereador Luis Marques', N'387', NULL, N'Centro', N'Itu', N'SP', N'18145600', N'1125639856', N'1598653214', NULL, N'459658963', 2, N'claudio@claudio.com', 5, NULL, N'M', 1)
/****** Object:  Table [dbo].[TRANSPORTADORAVIA]    Script Date: 10/09/2009 14:53:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRANSPORTADORAVIA](
	[CODVIATRANSPORTE] [varchar](3) NOT NULL,
	[CODTRANSPORTADORA] [varchar](14) NOT NULL,
 CONSTRAINT [PK_TRANSPORTADORAVIA] PRIMARY KEY CLUSTERED 
(
	[CODVIATRANSPORTE] ASC,
	[CODTRANSPORTADORA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TRANSPORTADORAVIA] ([CODVIATRANSPORTE], [CODTRANSPORTADORA]) VALUES (N'aer', N'07608749000165')
INSERT [dbo].[TRANSPORTADORAVIA] ([CODVIATRANSPORTE], [CODTRANSPORTADORA]) VALUES (N'mar', N'00525056000160')
INSERT [dbo].[TRANSPORTADORAVIA] ([CODVIATRANSPORTE], [CODTRANSPORTADORA]) VALUES (N'ter', N'07608749000165')
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[CNPJ] [varchar](14) NOT NULL,
	[RAZAOSOCIAL] [varchar](100) NOT NULL,
	[NOMEFANTASIA] [varchar](100) NOT NULL,
	[TELEFONE] [varchar](10) NULL,
	[FAX] [varchar](10) NULL,
	[EMAIL] [varchar](100) NULL,
	[IE] [varchar](11) NOT NULL,
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
PRIMARY KEY CLUSTERED 
(
	[CNPJ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'05570714000159', N'', N'kvdlf', N'1544545445', N'5454545454', N'b.b@gmail.com', N'11111111111', N'dsds', N'5', N'dsds', N'dsd', N'sds', N'TO', N'25698000', 1, 10, N'AUTO - RODA/DIREÇÃO', 145, N'S', NULL)
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'55256424000103', N'PetroNorte S.A', N'PetroNorte', N'1569898989', NULL, N'petronorte@petronorte.com', N'22222222222', N'Rod. Dep. Carlos Gonçalves', N'Km 25', NULL, N'Capuavinha', N'Registro', N'SP', N'25566666', 1, 6, N'VÁLVULAS - PETRÓLEO', 25000, N'S', N'S')
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'59147165000303', N'Aluminio Brasil Ltda', N'Aluminio Brasil', N'1598756888', NULL, N'aluminio@aluminio.com', N'36555565656', N'Rua Das Piranhas ', N'8', NULL, N'Gurgel', N'Piedade', N'SP', N'18170000', 1, 3, N'GERAL - TRAB. MADEIRA', 7500, N'S', N'S')
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'59748988000114', N'Mario Luiz ME', N'AgroTools Ferramentas Agrícolas', N'3185632565', NULL, N'agrotools@gmail.com', N'56897454545', N'Rod. Avelino Torres', N'Km 52', N'Próx. Posto Shell', N'Lavrinhas', N'Araguari', N'MG', N'52369700', 3, 5, N'GERAL - PRODUTOS AGRICOLAS', 1200, N'S', N'S')
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'61101895000498', N'Santher', N'Santher Ferramentas Elétricas', N'1198658989', NULL, N'santher@gmail.com', N'22222222222', N'Rua Cap. Pereira da Silva', N'565', NULL, N'Alagado', N'Barueri', N'SP', N'25698000', 5, 7, N'FERRAMENTAS', 30, N'S', N'S')
INSERT [dbo].[CLIENTE] ([CNPJ], [RAZAOSOCIAL], [NOMEFANTASIA], [TELEFONE], [FAX], [EMAIL], [IE], [ENDERECO], [NUM], [COMPLEMENTO], [BAIRRO], [MUNICIPIO], [UF], [CEP], [CODREGIAO], [CODUSUARIO], [AREAATUACAO], [LIMITECRED], [APROVADOCRED], [ATIVO]) VALUES (N'68976430000268', N'Arcom S.A', N'Arcom Ferramentas', N'1936986532', N'1936985241', N'arcom@arcom.com.br', N'36655589784', N'Av. Cel Duarte', N'256', NULL, N'Centro', N'Valinhos', N'SP', N'15235780', 2, 4, N'FERRAMENTAS', 15, N'S', N'S')
/****** Object:  Table [dbo].[ACESSO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACESSO](
	[CODMODULO] [int] NOT NULL,
	[CODUSUARIO] [int] NOT NULL,
 CONSTRAINT [PK_ACESSO] PRIMARY KEY CLUSTERED 
(
	[CODMODULO] ASC,
	[CODUSUARIO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
	[CODUNIDADEMEDIDA] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[CODPRODUTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUTO] ON
INSERT [dbo].[PRODUTO] ([CODPRODUTO], [DESCRICAO], [DATACADASTRO], [PRECOCUSTO], [PESOLIQUIDO], [CODGRUPOPRODUTO], [PRECOVENDA], [ESTOQUEATUAL], [ESTOQUEMIN], [IPI], [ATIVO], [CODUNIDADEMEDIDA]) VALUES (1, N'Broca 25 mm', CAST(0x00009C9400000000 AS DateTime), 45.8, 450, 3, 78.4, 25, 10, 2.5, NULL, N'pç')
INSERT [dbo].[PRODUTO] ([CODPRODUTO], [DESCRICAO], [DATACADASTRO], [PRECOCUSTO], [PESOLIQUIDO], [CODGRUPOPRODUTO], [PRECOVENDA], [ESTOQUEATUAL], [ESTOQUEMIN], [IPI], [ATIVO], [CODUNIDADEMEDIDA]) VALUES (2, N'Broca 30 mm', CAST(0x00009C9500000000 AS DateTime), 45.8, 450, 3, 89.4, 30, 10, 2.5, NULL, N'pç')
SET IDENTITY_INSERT [dbo].[PRODUTO] OFF
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
PRIMARY KEY CLUSTERED 
(
	[NRPEDIDO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PEDIDO] ON
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA]) VALUES (1, N'N', CAST(0x00009C9400000000 AS DateTime), CAST(0x00009C9900000000 AS DateTime), 1, N'P', N'31838427856', N'59147165000303', N'00525056000160')
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA]) VALUES (6, N'N', CAST(0x00009C9500000000 AS DateTime), CAST(0x00009C9E00000000 AS DateTime), 3, N'P', N'31838427856', N'68976430000268', N'07608749000165')
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA]) VALUES (8, N'N', CAST(0x00009C9800000000 AS DateTime), CAST(0x00009CAD00000000 AS DateTime), 1, N'P', N'31838427856', N'68976430000268', N'07608749000165')
INSERT [dbo].[PEDIDO] ([NRPEDIDO], [TIPO], [DATAEMISSAO], [DATAENTREGA], [CODCONDICAOPAGAMENTO], [SITUACAO], [CODVENDEDOR], [CODCLIENTE], [CODTRANSPORTADORA]) VALUES (9, N'N', CAST(0x00009C9C00000000 AS DateTime), CAST(0x00009CAD00000000 AS DateTime), 3, N'P', N'31838427856', N'61101895000498', N'00525056000160')
SET IDENTITY_INSERT [dbo].[PEDIDO] OFF
/****** Object:  Table [dbo].[ITEMPEDIDO]    Script Date: 10/09/2009 14:53:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMPEDIDO](
	[NRPEDIDO] [int] NOT NULL,
	[CODPRODUTO] [int] NOT NULL,
	[QUANTIDADE] [int] NOT NULL,
	[DESCONTO] [float] NULL,
	[VALOR] [float] NOT NULL,
	[IPI] [float] NULL,
 CONSTRAINT [PK_ITEMPEDIDO] PRIMARY KEY CLUSTERED 
(
	[NRPEDIDO] ASC,
	[CODPRODUTO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ITEMPEDIDO] ([NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI]) VALUES (1, 1, 3, 5, 152.3, 2.5)
INSERT [dbo].[ITEMPEDIDO] ([NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI]) VALUES (1, 2, 2, 2, 87.6, 1.25)
INSERT [dbo].[ITEMPEDIDO] ([NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI]) VALUES (6, 2, 2, 5, 568, 3.5)
INSERT [dbo].[ITEMPEDIDO] ([NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI]) VALUES (8, 1, 2, 2, 300, 2.5)
INSERT [dbo].[ITEMPEDIDO] ([NRPEDIDO], [CODPRODUTO], [QUANTIDADE], [DESCONTO], [VALOR], [IPI]) VALUES (8, 2, 3, 2, 200, 2.3)
/****** Object:  Check [cliente_bairro_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_bairro_empty] CHECK  (([bairro]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_bairro_empty]
GO
/****** Object:  Check [cliente_cep_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_cep_empty] CHECK  (([cep]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_cep_empty]
GO
/****** Object:  Check [cliente_endereco_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_endereco_empty] CHECK  (([endereco]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_endereco_empty]
GO
/****** Object:  Check [cliente_ie_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_ie_empty] CHECK  (([ie]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_ie_empty]
GO
/****** Object:  Check [cliente_municipio_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_municipio_empty] CHECK  (([cep]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_municipio_empty]
GO
/****** Object:  Check [cliente_nomefantasia_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_nomefantasia_empty] CHECK  (([nomefantasia]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_nomefantasia_empty]
GO
/****** Object:  Check [cliente_num_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_num_empty] CHECK  (([num]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_num_empty]
GO
/****** Object:  Check [cliente_uf_empty]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [cliente_uf_empty] CHECK  (([uf]<>''))
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [cliente_uf_empty]
GO
/****** Object:  ForeignKey [FK_ACESSO_MODULO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[ACESSO]  WITH CHECK ADD  CONSTRAINT [FK_ACESSO_MODULO] FOREIGN KEY([CODMODULO])
REFERENCES [dbo].[MODULO] ([CODMODULO])
GO
ALTER TABLE [dbo].[ACESSO] CHECK CONSTRAINT [FK_ACESSO_MODULO]
GO
/****** Object:  ForeignKey [FK_ACESSO_USUARIO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[ACESSO]  WITH CHECK ADD  CONSTRAINT [FK_ACESSO_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
ALTER TABLE [dbo].[ACESSO] CHECK CONSTRAINT [FK_ACESSO_USUARIO]
GO
/****** Object:  ForeignKey [FK_CLIENTE_REGIAO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_REGIAO] FOREIGN KEY([CODREGIAO])
REFERENCES [dbo].[REGIAO] ([CODREGIAO])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_REGIAO]
GO
/****** Object:  ForeignKey [FK_CLIENTE_USUARIO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
ALTER TABLE [dbo].[CLIENTE] CHECK CONSTRAINT [FK_CLIENTE_USUARIO]
GO
/****** Object:  ForeignKey [FK_ItemNotaFiscal_NOTA_FISCAL]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[ItemNotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_ItemNotaFiscal_NOTA_FISCAL] FOREIGN KEY([NrNotaFiscal])
REFERENCES [dbo].[NOTAFISCAL] ([NrNotaFiscal])
GO
ALTER TABLE [dbo].[ItemNotaFiscal] CHECK CONSTRAINT [FK_ItemNotaFiscal_NOTA_FISCAL]
GO
/****** Object:  ForeignKey [FK_ITEMPEDIDO_PEDIDO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[ITEMPEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_ITEMPEDIDO_PEDIDO] FOREIGN KEY([NRPEDIDO])
REFERENCES [dbo].[PEDIDO] ([NRPEDIDO])
GO
ALTER TABLE [dbo].[ITEMPEDIDO] CHECK CONSTRAINT [FK_ITEMPEDIDO_PEDIDO]
GO
/****** Object:  ForeignKey [FK_ITEMPEDIDO_PRODUTO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[ITEMPEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_ITEMPEDIDO_PRODUTO] FOREIGN KEY([CODPRODUTO])
REFERENCES [dbo].[PRODUTO] ([CODPRODUTO])
GO
ALTER TABLE [dbo].[ITEMPEDIDO] CHECK CONSTRAINT [FK_ITEMPEDIDO_PRODUTO]
GO
/****** Object:  ForeignKey [FK_PEDIDO_CLIENTE]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_CLIENTE] FOREIGN KEY([CODCLIENTE])
REFERENCES [dbo].[CLIENTE] ([CNPJ])
GO
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_CLIENTE]
GO
/****** Object:  ForeignKey [FK_PEDIDO_PAGAMENTO]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_PAGAMENTO] FOREIGN KEY([CODCONDICAOPAGAMENTO])
REFERENCES [dbo].[CONDICAOPAGAMENTO] ([CODCONDICAOPAGAMENTO])
GO
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_PAGAMENTO]
GO
/****** Object:  ForeignKey [FK_PEDIDO_TRANSPORTADORA]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_TRANSPORTADORA] FOREIGN KEY([CODTRANSPORTADORA])
REFERENCES [dbo].[TRANSPORTADORA] ([CNPJ])
GO
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_TRANSPORTADORA]
GO
/****** Object:  ForeignKey [FK_PEDIDO_VENDEDOR]    Script Date: 10/09/2009 14:53:16 ******/
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_VENDEDOR] FOREIGN KEY([CODVENDEDOR])
REFERENCES [dbo].[VENDEDOR] ([CPF])
GO
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_VENDEDOR]
GO
/****** Object:  ForeignKey [FK_PRODUTO_GRUPO]    Script Date: 10/09/2009 14:53:17 ******/
ALTER TABLE [dbo].[PRODUTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTO_GRUPO] FOREIGN KEY([CODGRUPOPRODUTO])
REFERENCES [dbo].[GRUPOPRODUTO] ([CODGRUPOPRODUTO])
GO
ALTER TABLE [dbo].[PRODUTO] CHECK CONSTRAINT [FK_PRODUTO_GRUPO]
GO
/****** Object:  ForeignKey [FK_PRODUTO_UNIDADE_MEDIDA]    Script Date: 10/09/2009 14:53:17 ******/
ALTER TABLE [dbo].[PRODUTO]  WITH CHECK ADD  CONSTRAINT [FK_PRODUTO_UNIDADE_MEDIDA] FOREIGN KEY([CODUNIDADEMEDIDA])
REFERENCES [dbo].[UNIDADEMEDIDA] ([CODUNIDADEMEDIDA])
GO
ALTER TABLE [dbo].[PRODUTO] CHECK CONSTRAINT [FK_PRODUTO_UNIDADE_MEDIDA]
GO
/****** Object:  ForeignKey [FK_TRANSPORTADORAVIA_TRANSPORTADORA]    Script Date: 10/09/2009 14:53:17 ******/
ALTER TABLE [dbo].[TRANSPORTADORAVIA]  WITH CHECK ADD  CONSTRAINT [FK_TRANSPORTADORAVIA_TRANSPORTADORA] FOREIGN KEY([CODTRANSPORTADORA])
REFERENCES [dbo].[TRANSPORTADORA] ([CNPJ])
GO
ALTER TABLE [dbo].[TRANSPORTADORAVIA] CHECK CONSTRAINT [FK_TRANSPORTADORAVIA_TRANSPORTADORA]
GO
/****** Object:  ForeignKey [FK_TRANSPORTADORAVIA_VIATRANSPORTE]    Script Date: 10/09/2009 14:53:17 ******/
ALTER TABLE [dbo].[TRANSPORTADORAVIA]  WITH CHECK ADD  CONSTRAINT [FK_TRANSPORTADORAVIA_VIATRANSPORTE] FOREIGN KEY([CODVIATRANSPORTE])
REFERENCES [dbo].[VIATRANSPORTE] ([CODVIATRANSPORTE])
GO
ALTER TABLE [dbo].[TRANSPORTADORAVIA] CHECK CONSTRAINT [FK_TRANSPORTADORAVIA_VIATRANSPORTE]
GO
/****** Object:  ForeignKey [FK_VENDEDOR_REGIAO]    Script Date: 10/09/2009 14:53:17 ******/
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [FK_VENDEDOR_REGIAO] FOREIGN KEY([CODREGIAO])
REFERENCES [dbo].[REGIAO] ([CODREGIAO])
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [FK_VENDEDOR_REGIAO]
GO
/****** Object:  ForeignKey [FK_VENDEDOR_USUARIO]    Script Date: 10/09/2009 14:53:17 ******/
ALTER TABLE [dbo].[VENDEDOR]  WITH CHECK ADD  CONSTRAINT [FK_VENDEDOR_USUARIO] FOREIGN KEY([CODUSUARIO])
REFERENCES [dbo].[USUARIO] ([CODUSUARIO])
GO
ALTER TABLE [dbo].[VENDEDOR] CHECK CONSTRAINT [FK_VENDEDOR_USUARIO]
GO

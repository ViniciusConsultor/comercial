USE [comercial]
GO
/****** Object:  ForeignKey [FK_ACESSO_MODULO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_MODULO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO] DROP CONSTRAINT [FK_ACESSO_MODULO]
GO
/****** Object:  ForeignKey [FK_ACESSO_USUARIO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO] DROP CONSTRAINT [FK_ACESSO_USUARIO]
GO
/****** Object:  ForeignKey [FK_ATUCUBO_USUARIO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ATUCUBO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ATUCUBO]'))
ALTER TABLE [dbo].[ATUCUBO] DROP CONSTRAINT [FK_ATUCUBO_USUARIO]
GO
/****** Object:  ForeignKey [FK_CLIENTE_REGIAO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [FK_CLIENTE_REGIAO]
GO
/****** Object:  ForeignKey [FK_CLIENTE_USUARIO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [FK_CLIENTE_USUARIO]
GO
/****** Object:  ForeignKey [FK_ItemNotaFiscal_NOTA_FISCAL]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItemNotaFiscal_NOTA_FISCAL]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItemNotaFiscal]'))
ALTER TABLE [dbo].[ItemNotaFiscal] DROP CONSTRAINT [FK_ItemNotaFiscal_NOTA_FISCAL]
GO
/****** Object:  ForeignKey [FK_ITEMPEDIDO_PEDIDO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PEDIDO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO] DROP CONSTRAINT [FK_ITEMPEDIDO_PEDIDO]
GO
/****** Object:  ForeignKey [FK_ITEMPEDIDO_PRODUTO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PRODUTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO] DROP CONSTRAINT [FK_ITEMPEDIDO_PRODUTO]
GO
/****** Object:  ForeignKey [FK_modelo_modeloCampo]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelo_modeloCampo]') AND parent_object_id = OBJECT_ID(N'[dbo].[modeloCampo]'))
ALTER TABLE [dbo].[modeloCampo] DROP CONSTRAINT [FK_modelo_modeloCampo]
GO
/****** Object:  ForeignKey [FK_PEDIDO_CLIENTE]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_CLIENTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_CLIENTE]
GO
/****** Object:  ForeignKey [FK_PEDIDO_PAGAMENTO]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_PAGAMENTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_PAGAMENTO]
GO
/****** Object:  ForeignKey [FK_PEDIDO_TRANSPORTADORA]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_TRANSPORTADORA]
GO
/****** Object:  ForeignKey [FK_PEDIDO_VENDEDOR]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_VENDEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_VENDEDOR]
GO
/****** Object:  ForeignKey [FK_PRODUTO_GRUPO]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_GRUPO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] DROP CONSTRAINT [FK_PRODUTO_GRUPO]
GO
/****** Object:  ForeignKey [FK_PRODUTO_UNIDADE_MEDIDA]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_UNIDADE_MEDIDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] DROP CONSTRAINT [FK_PRODUTO_UNIDADE_MEDIDA]
GO
/****** Object:  ForeignKey [FK_TRANSPORTADORAVIA_TRANSPORTADORA]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA] DROP CONSTRAINT [FK_TRANSPORTADORAVIA_TRANSPORTADORA]
GO
/****** Object:  ForeignKey [FK_TRANSPORTADORAVIA_VIATRANSPORTE]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_VIATRANSPORTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA] DROP CONSTRAINT [FK_TRANSPORTADORAVIA_VIATRANSPORTE]
GO
/****** Object:  ForeignKey [FK_VENDEDOR_REGIAO]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR] DROP CONSTRAINT [FK_VENDEDOR_REGIAO]
GO
/****** Object:  ForeignKey [FK_VENDEDOR_USUARIO]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR] DROP CONSTRAINT [FK_VENDEDOR_USUARIO]
GO
/****** Object:  Check [cliente_bairro_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_bairro_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_bairro_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_bairro_empty]

END
GO
/****** Object:  Check [cliente_cep_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_cep_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_cep_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_cep_empty]

END
GO
/****** Object:  Check [cliente_endereco_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_endereco_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_endereco_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_endereco_empty]

END
GO
/****** Object:  Check [cliente_ie_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_ie_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_ie_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_ie_empty]

END
GO
/****** Object:  Check [cliente_municipio_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_municipio_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_municipio_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_municipio_empty]

END
GO
/****** Object:  Check [cliente_nomefantasia_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_nomefantasia_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_nomefantasia_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_nomefantasia_empty]

END
GO
/****** Object:  Check [cliente_num_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_num_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_num_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_num_empty]

END
GO
/****** Object:  Check [cliente_razaosocial_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_razaosocial_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_razaosocial_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_razaosocial_empty]

END
GO
/****** Object:  Check [cliente_uf_empty]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_uf_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_uf_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_uf_empty]

END
GO
/****** Object:  Table [dbo].[ITEMPEDIDO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PEDIDO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO] DROP CONSTRAINT [FK_ITEMPEDIDO_PEDIDO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ITEMPEDIDO_PRODUTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]'))
ALTER TABLE [dbo].[ITEMPEDIDO] DROP CONSTRAINT [FK_ITEMPEDIDO_PRODUTO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMPEDIDO]') AND type in (N'U'))
DROP TABLE [dbo].[ITEMPEDIDO]
GO
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_CLIENTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_CLIENTE]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_PAGAMENTO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_PAGAMENTO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_TRANSPORTADORA]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PEDIDO_VENDEDOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PEDIDO]'))
ALTER TABLE [dbo].[PEDIDO] DROP CONSTRAINT [FK_PEDIDO_VENDEDOR]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PEDIDO]') AND type in (N'U'))
DROP TABLE [dbo].[PEDIDO]
GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_GRUPO]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] DROP CONSTRAINT [FK_PRODUTO_GRUPO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PRODUTO_UNIDADE_MEDIDA]') AND parent_object_id = OBJECT_ID(N'[dbo].[PRODUTO]'))
ALTER TABLE [dbo].[PRODUTO] DROP CONSTRAINT [FK_PRODUTO_UNIDADE_MEDIDA]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUTO]') AND type in (N'U'))
DROP TABLE [dbo].[PRODUTO]
GO
/****** Object:  Table [dbo].[ACESSO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_MODULO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO] DROP CONSTRAINT [FK_ACESSO_MODULO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ACESSO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ACESSO]'))
ALTER TABLE [dbo].[ACESSO] DROP CONSTRAINT [FK_ACESSO_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ACESSO]') AND type in (N'U'))
DROP TABLE [dbo].[ACESSO]
GO
/****** Object:  Table [dbo].[ATUCUBO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ATUCUBO_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[ATUCUBO]'))
ALTER TABLE [dbo].[ATUCUBO] DROP CONSTRAINT [FK_ATUCUBO_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ATUCUBO]') AND type in (N'U'))
DROP TABLE [dbo].[ATUCUBO]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [FK_CLIENTE_REGIAO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CLIENTE_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [FK_CLIENTE_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_bairro_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_bairro_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_cep_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_cep_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_endereco_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_endereco_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_ie_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_ie_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_municipio_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_municipio_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_nomefantasia_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_nomefantasia_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_num_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_num_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_razaosocial_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_razaosocial_empty]
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[cliente_uf_empty]') AND parent_object_id = OBJECT_ID(N'[dbo].[CLIENTE]'))
ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [cliente_uf_empty]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLIENTE]') AND type in (N'U'))
DROP TABLE [dbo].[CLIENTE]
GO
/****** Object:  Table [dbo].[TRANSPORTADORAVIA]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_TRANSPORTADORA]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA] DROP CONSTRAINT [FK_TRANSPORTADORAVIA_TRANSPORTADORA]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TRANSPORTADORAVIA_VIATRANSPORTE]') AND parent_object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]'))
ALTER TABLE [dbo].[TRANSPORTADORAVIA] DROP CONSTRAINT [FK_TRANSPORTADORAVIA_VIATRANSPORTE]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORAVIA]') AND type in (N'U'))
DROP TABLE [dbo].[TRANSPORTADORAVIA]
GO
/****** Object:  Table [dbo].[modeloCampo]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelo_modeloCampo]') AND parent_object_id = OBJECT_ID(N'[dbo].[modeloCampo]'))
ALTER TABLE [dbo].[modeloCampo] DROP CONSTRAINT [FK_modelo_modeloCampo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modeloCampo]') AND type in (N'U'))
DROP TABLE [dbo].[modeloCampo]
GO
/****** Object:  Table [dbo].[VENDEDOR]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_REGIAO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR] DROP CONSTRAINT [FK_VENDEDOR_REGIAO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VENDEDOR_USUARIO]') AND parent_object_id = OBJECT_ID(N'[dbo].[VENDEDOR]'))
ALTER TABLE [dbo].[VENDEDOR] DROP CONSTRAINT [FK_VENDEDOR_USUARIO]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VENDEDOR]') AND type in (N'U'))
DROP TABLE [dbo].[VENDEDOR]
GO
/****** Object:  Table [dbo].[ItemNotaFiscal]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItemNotaFiscal_NOTA_FISCAL]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItemNotaFiscal]'))
ALTER TABLE [dbo].[ItemNotaFiscal] DROP CONSTRAINT [FK_ItemNotaFiscal_NOTA_FISCAL]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemNotaFiscal]') AND type in (N'U'))
DROP TABLE [dbo].[ItemNotaFiscal]
GO
/****** Object:  Table [dbo].[modelo]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modelo]') AND type in (N'U'))
DROP TABLE [dbo].[modelo]
GO
/****** Object:  Table [dbo].[VIATRANSPORTE]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VIATRANSPORTE]') AND type in (N'U'))
DROP TABLE [dbo].[VIATRANSPORTE]
GO
/****** Object:  Table [dbo].[MODULO]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MODULO]') AND type in (N'U'))
DROP TABLE [dbo].[MODULO]
GO
/****** Object:  Table [dbo].[NOTAFISCAL]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NOTAFISCAL]') AND type in (N'U'))
DROP TABLE [dbo].[NOTAFISCAL]
GO
/****** Object:  Table [dbo].[UF]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UF]') AND type in (N'U'))
DROP TABLE [dbo].[UF]
GO
/****** Object:  Table [dbo].[UNIDADEMEDIDA]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UNIDADEMEDIDA]') AND type in (N'U'))
DROP TABLE [dbo].[UNIDADEMEDIDA]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 12/03/2009 19:39:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USUARIO]') AND type in (N'U'))
DROP TABLE [dbo].[USUARIO]
GO
/****** Object:  Table [dbo].[CONDICAOPAGAMENTO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CONDICAOPAGAMENTO]') AND type in (N'U'))
DROP TABLE [dbo].[CONDICAOPAGAMENTO]
GO
/****** Object:  Table [dbo].[GRUPOPRODUTO]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GRUPOPRODUTO]') AND type in (N'U'))
DROP TABLE [dbo].[GRUPOPRODUTO]
GO
/****** Object:  Table [dbo].[ICMS]    Script Date: 12/03/2009 19:39:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ICMS]') AND type in (N'U'))
DROP TABLE [dbo].[ICMS]
GO
/****** Object:  Table [dbo].[REGIAO]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[REGIAO]') AND type in (N'U'))
DROP TABLE [dbo].[REGIAO]
GO
/****** Object:  Table [dbo].[TRANSPORTADORA]    Script Date: 12/03/2009 19:39:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TRANSPORTADORA]') AND type in (N'U'))
DROP TABLE [dbo].[TRANSPORTADORA]
GO

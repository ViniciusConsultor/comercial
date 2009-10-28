﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Comercial
{
    public partial class FrmVisGeral : Form
    {
        private Form _parent;
        public Control _controle;


        public FrmVisGeral(Form parent, Control controle)
        {
            InitializeComponent();
            _parent = parent;
            _controle = controle;

            #region Colunas GridViewGeral Usuario
            if (_parent is FrmCadUsu)
            {
                rdBtnCod.Visible = false;
                rdBtnNome.Text = "Usuário";
                rdBtnNome.Checked = true;

                col1.HeaderText = "Usuário";
                col1.DataPropertyName = "usuario";
                dtGrdVwVis.Columns[1].Visible = false;
            }
            #endregion

            #region Colunas GridViewGeral Produto
            if ((_parent is FrmConEstProd) || (_parent is FrmConProd && _controle.Name == "txtBtnCodProd"))
            {
                rdBtnCod.Visible = true;
                rdBtnCod.Text = "Código";
                rdBtnCod.Checked = true;
                rdBtnNome.Text = "Descrição";
                rdBtnNome.Checked = true;

                col1.HeaderText = "Código";
                col1.DataPropertyName = "CODPRODUTO";
                dtGrdVwVis.Columns[1].Visible = true;

                col2.HeaderText = "Descrição";
                col2.DataPropertyName = "DESCRICAO";
                dtGrdVwVis.Columns[1].Visible = true;
            }
            #endregion

            #region Colunas GridViewGeral GrupoProduto
            if ((_parent is FrmConProd && _controle.Name == "txtBtnCodGrp") || (_parent is FrmCadProd && _controle.Name == "txtBtnCodGrp"))
            {
                rdBtnCod.Visible = true;
                rdBtnCod.Text = "Código";
                rdBtnCod.Checked = true;
                rdBtnNome.Text = "Descrição";
                rdBtnNome.Checked = true;

                col1.HeaderText = "Código";
                col1.DataPropertyName = "codgrupoproduto";
                dtGrdVwVis.Columns[1].Visible = true;

                col2.HeaderText = "Descrição";
                col2.DataPropertyName = "descricao";
                dtGrdVwVis.Columns[1].Visible = true;
            }
            #endregion

            #region Colunas GridViewGeral Pedido
            if (_parent is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)_parent;

                #region VisGeral Pedido Cliente
                if (controle.Name == "txtcodCli")
                {
                    rdBtnCod.Visible = true;
                    rdBtnCod.Text = "CNPJ";
                    rdBtnCod.Checked = true;
                    rdBtnNome.Text = "Nome";
                    rdBtnNome.Checked = true;

                    col1.HeaderText = "CNPJ";
                    col1.DataPropertyName = "CNPJ";
                    dtGrdVwVis.Columns[1].Visible = true;

                    col2.HeaderText = "Razão Social";
                    col2.DataPropertyName = "RAZAOSOCIAL";
                    dtGrdVwVis.Columns[1].Visible = true;
                }

                #endregion

                #region VisGeral Pedido Vendedor
                if (controle.Name == "txtCodVendedor")
                {
                    rdBtnCod.Visible = true;
                    rdBtnCod.Text = "CPF";
                    rdBtnCod.Checked = true;
                    rdBtnNome.Text = "Nome";
                    rdBtnNome.Checked = true;

                    col1.HeaderText = "CPF";
                    col1.DataPropertyName = "CPF";
                    dtGrdVwVis.Columns[1].Visible = true;

                    col2.HeaderText = "Nome";
                    col2.DataPropertyName = "Nome";
                    dtGrdVwVis.Columns[1].Visible = true;
                }
                #endregion

                #region VisGeral Pedido Condicao Pagto
                if (controle.Name == "txtCondPagto")
                {
                    rdBtnCod.Visible = true;
                    rdBtnCod.Text = "Código";
                    rdBtnCod.Checked = true;
                    rdBtnNome.Text = "Descrição";
                    rdBtnNome.Checked = true;

                    col1.HeaderText = "Código";
                    col1.DataPropertyName = "CODCONDICAOPAGAMENTO";
                    dtGrdVwVis.Columns[1].Visible = true;

                    col2.HeaderText = "Descrição";
                    col2.DataPropertyName = "DESCRICAO";
                    dtGrdVwVis.Columns[1].Visible = true;

                    dtGrdVwVis.Columns.Add("col3", "Vezes");
                    dtGrdVwVis.Columns["col3"].DataPropertyName = "QTDEVEZES";

                    dtGrdVwVis.Columns.Add("col4", "Entrada");
                    dtGrdVwVis.Columns["col4"].DataPropertyName = "ENTRADA";


                    //col3.HeaderText = "Vezes";
                    //col3.DataPropertyName = "QTDEVEZES";
                    //dtGrdVwVis.Columns[1].Visible = true;
                    //col3.Visible = true;

                    //col4.HeaderText = "Entrada";
                    //col4.DataPropertyName = "ENTRADA";
                    //dtGrdVwVis.Columns[1].Visible = true;
                    //col4.Visible = true;
                }
                #endregion

                #region VisGeral Pedido Transportadora
                if (controle.Name == "txtCodTransportadora")
                {
                    rdBtnCod.Visible = true;
                    rdBtnCod.Text = "CNPJ";
                    rdBtnCod.Checked = true;
                    rdBtnNome.Text = "Nome";
                    rdBtnNome.Checked = true;

                    col1.HeaderText = "CNPJ";
                    col1.DataPropertyName = "CNPJ";
                    dtGrdVwVis.Columns[1].Visible = true;

                    col2.HeaderText = "Nome";
                    col2.DataPropertyName = "NOME";
                    dtGrdVwVis.Columns[1].Visible = true;
                }
                #endregion

                #region VisGeral Pedido Produto
                if (controle.Name == "txtProduto")
                {
                    rdBtnCod.Visible = true;
                    rdBtnCod.Text = "Código";
                    rdBtnCod.Checked = true;
                    rdBtnNome.Text = "Descrição";
                    rdBtnNome.Checked = true;

                    col1.HeaderText = "Código";
                    col1.DataPropertyName = "CODPRODUTO";
                    dtGrdVwVis.Columns[1].Visible = true;

                    col2.HeaderText = "Descrição";
                    col2.DataPropertyName = "DESCRICAO";
                    dtGrdVwVis.Columns[1].Visible = true;

                    dtGrdVwVis.Columns.Add("col3", "UM");
                    dtGrdVwVis.Columns["col3"].DataPropertyName = "CODUNIDADEMEDIDA";

                    dtGrdVwVis.Columns.Add("col4", "Estoque Atual");
                    dtGrdVwVis.Columns["col4"].DataPropertyName = "ESTOQUEATUAL";

                    dtGrdVwVis.Columns.Add("col5", "Preço Venda");
                    dtGrdVwVis.Columns["col5"].DataPropertyName = "PRECOVENDA";

                    dtGrdVwVis.Columns.Add("col6", "IPI Produto");
                    dtGrdVwVis.Columns["col6"].DataPropertyName = "IPI";

                    dtGrdVwVis.Columns.Add("col7", "Desconto Produto");
                    dtGrdVwVis.Columns["col7"].DataPropertyName = "DESCONTO";


                }
                #endregion

            }
            #endregion

            #region Colunas GridViewGeral Cliente
            if (_parent is frmConCli)
            {
                rdBtnCod.Visible = true;
                rdBtnCod.Text = "CNPJ";
                rdBtnNome.Visible = true;
                rdBtnNome.Text = "N. Fant.";
                rdBtnCod.Checked = true;

                col1.HeaderText = "CNPJ";
                col1.DataPropertyName = "CNPJ";
                dtGrdVwVis.Columns[1].Visible = true;

                col2.HeaderText = "Nome Fantasia";
                col2.DataPropertyName = "NomeFantasia";
                dtGrdVwVis.Columns[1].Visible = true;

            }

            #endregion

            #region Colunas GridViewGeral Consulta Pedido
            if (_parent is FrmConPDV)
            {
                FrmConPDV Conped = (FrmConPDV)_parent;

                #region VisGeral Consulta Pedido Produto
                if (controle.Name == "txtCodProd")
                {
                    rdBtnCod.Visible = true;
                    rdBtnCod.Text = "Código";
                    rdBtnCod.Checked = true;
                    rdBtnNome.Text = "Descrição";
                    rdBtnNome.Checked = true;

                    col1.HeaderText = "Código";
                    col1.DataPropertyName = "CODPRODUTO";
                    dtGrdVwVis.Columns[1].Visible = true;

                    col2.HeaderText = "Descrição";
                    col2.DataPropertyName = "DESCRICAO";
                    dtGrdVwVis.Columns[1].Visible = true;

                    dtGrdVwVis.Columns.Add("col3", "UM");
                    dtGrdVwVis.Columns["col3"].DataPropertyName = "CODUNIDADEMEDIDA";

                    dtGrdVwVis.Columns.Add("col4", "Estoque Atual");
                    dtGrdVwVis.Columns["col4"].DataPropertyName = "ESTOQUEATUAL";

                    dtGrdVwVis.Columns.Add("col5", "Preço Venda");
                    dtGrdVwVis.Columns["col5"].DataPropertyName = "PRECOVENDA";

                    dtGrdVwVis.Columns.Add("col6", "IPI Produto");
                    dtGrdVwVis.Columns["col6"].DataPropertyName = "IPI";

                    dtGrdVwVis.Columns.Add("col7", "Desconto Produto");
                    dtGrdVwVis.Columns["col7"].DataPropertyName = "DESCONTO";


                }
                #endregion

            }
            #endregion

            #region Coluna GridViewGeral Pedido Processo
            if (controle.Name == "txtbtnPedido")
            {
                rdBtnCod.Visible = true;
                rdBtnCod.Text = "Pedido";
                rdBtnCod.Checked = true;
                rdBtnNome.Text = "Cliente";
                rdBtnNome.Checked = true;

                col1.HeaderText = "Numero Pedido";
                col1.DataPropertyName = "NRPEDIDO";
                dtGrdVwVis.Columns[1].Visible = true;

                col2.HeaderText = "Cod Cliente";
                col2.DataPropertyName = "CODCLIENTE";
                dtGrdVwVis.Columns[1].Visible = true;


                dtGrdVwVis.Columns.Add("col3", "Tipo");
                dtGrdVwVis.Columns["col3"].DataPropertyName = "TIPO";

                dtGrdVwVis.Columns.Add("col4", "Cod Vendedor");
                dtGrdVwVis.Columns["col4"].DataPropertyName = "CODVENDEDOR";

                dtGrdVwVis.Columns.Add("col5", "Cond Pagto");
                dtGrdVwVis.Columns["col5"].DataPropertyName = "CODCONDICAOPAGAMENTO";

                dtGrdVwVis.Columns.Add("col6", "Cod Trans");
                dtGrdVwVis.Columns["col6"].DataPropertyName = "CODTRANSPORTADORA";

                dtGrdVwVis.Columns.Add("col7", "Data Emissão");
                dtGrdVwVis.Columns["col7"].DataPropertyName = "DATAEMISSAO";

                dtGrdVwVis.Columns.Add("col8", "Data Entrega");
                dtGrdVwVis.Columns["col8"].DataPropertyName = "DATAENTREGA";



            }
            #endregion
        }

        #region Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            #region FormPesquisa Usuario
            if (_parent is FrmCadUsu)
            {

                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(c);
                conn.Open();

                SqlCommand cmd = new SqlCommand("select usuario from usuario where usuario like @usu ", conn);

                cmd.Parameters.Add(new SqlParameter("@usu", txtPesquisar.Text + "%"));

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dtGrdVwVis.DataSource = table;


            }

            #endregion

            #region FormPesquisa Zabotto
            if ((_parent is FrmCadPed) || (_parent is FrmConPDV) || (_parent is FrmConEstProd) || (_parent is FrmConProd) || (_parent is FrmCadProd))
            {

                #region Pedido Pesquisa Cliente
                if (_controle.Name == "txtcodCli")
                {
                    if (rdBtnCod.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select cnpj, razaosocial from CLIENTE where cnpj like @cnpj ", conn);

                        cmd.Parameters.Add(new SqlParameter("@cnpj", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select cnpj, razaosocial from CLIENTE where razaosocial like @razaosocial ", conn);

                        cmd.Parameters.Add(new SqlParameter("@razaosocial", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }
                #endregion

                #region Pedido Pesquisa Vendedor

                if (_controle.Name == "txtCodVendedor")
                {
                    if (rdBtnCod.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select CPF, NOME from VENDEDOR where CPF like @CPF ", conn);

                        cmd.Parameters.Add(new SqlParameter("@cpf", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select CPF, NOME from VENDEDOR where nome like @nome ", conn);

                        cmd.Parameters.Add(new SqlParameter("@nome", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }
                #endregion

                #region Pedido Pesquisa Condicao Pagto
                if (_controle.Name == "txtCondPagto")
                {
                    if (rdBtnCod.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select *  from CONDICAOPAGAMENTO where CODCONDICAOPAGAMENTO like @CODCONDICAOPAGAMENTO ", conn);

                        cmd.Parameters.Add(new SqlParameter("@CODCONDICAOPAGAMENTO", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select * from CONDICAOPAGAMENTO where DESCRICAO like @DESCRICAO ", conn);

                        cmd.Parameters.Add(new SqlParameter("@DESCRICAO", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }

                #endregion

                #region Pedido Pesquisa Vendedor

                if (_controle.Name == "txtCodTransportadora")
                {
                    if (rdBtnCod.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select CNPJ, NOME from TRANSPORTADORA where CNPJ like @CNPJ ", conn);

                        cmd.Parameters.Add(new SqlParameter("@CNPJ", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select CNPJ, NOME from TRANSPORTADORA where nome like @nome ", conn);

                        cmd.Parameters.Add(new SqlParameter("@nome", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }
                #endregion

                #region Pedido Pesquisa Produto

                if ((_controle.Name == "txtProduto") || (_controle.Name == "txtCodProd") || (_controle.Name == "txtBtnCodProd"))
                {
                    if (rdBtnCod.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select CODPRODUTO,DESCRICAO,CODUNIDADEMEDIDA,ESTOQUEATUAL,PRECOVENDA from PRODUTO where CODPRODUTO like @CODPRODUTO ", conn);

                        cmd.Parameters.Add(new SqlParameter("@CODPRODUTO", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select CODPRODUTO,DESCRICAO,CODUNIDADEMEDIDA,ESTOQUEATUAL,PRECOVENDA from PRODUTO where DESCRICAO like @DESCRICAO ", conn);

                        cmd.Parameters.Add(new SqlParameter("@DESCRICAO", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }
                #endregion

                #region Pedido Pesquisa Grupo Produto

                if ((_controle.Name == "txtBtnCodGrp"))
                {
                    if (rdBtnCod.Checked)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select codgrupoproduto, descricao from grupoproduto where codgrupoproduto like @codgrupoproduto ", conn);

                        cmd.Parameters.Add(new SqlParameter("@codgrupoproduto", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("select codgrupoproduto, descricao from grupoproduto where DESCRICAO like @DESCRICAO ", conn);

                        cmd.Parameters.Add(new SqlParameter("@DESCRICAO", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }
                #endregion

                

            }
            #endregion

            #region FormPesquisa Claudio
            if (_parent is frmConCli)
            {
                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(c);
                conn.Open();
                String consulta = "select cnpj,nomefantasia from cliente where ";
                if (rdBtnCod.Checked == true)
                {
                    consulta += "cnpj=@cnpj";
                }
                else consulta += "nomefantasia like @nomefantasia";

                SqlCommand cmd = new SqlCommand(consulta, conn);

                if (rdBtnCod.Checked == true)
                {
                    cmd.Parameters.Add(new SqlParameter("@cnpj", txtPesquisar.Text));
                }
                else cmd.Parameters.Add(new SqlParameter("@nomefantasia", "%" + txtPesquisar.Text + "%"));

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dtGrdVwVis.DataSource = table;

            }

            #endregion

            if (_parent is FrmLibPDV)
            {
                #region Processo Liberar Pedido Pesquisa 

                if ((_controle.Name == "txtbtnPedido") )
                {
                    if (rdBtnCod.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("SELECT NRPEDIDO, TIPO, ped.CODCLIENTE, CODVENDEDOR,CODCONDICAOPAGAMENTO, CODTRANSPORTADORA, Convert(char(10),DATAEMISSAO,103)as DATAEMISSAO , Convert(char(10),DATAENTREGA,103) as DATAENTREGA " +
                            " FROM PEDIDO ped INNER JOIN CLIENTE cli ON ped.CODCLIENTE = cli.CNPJ "+
                            "WHERE SITUACAO <> 'C' AND NRPEDIDO = @NRPEDIDO ", conn);

                        cmd.Parameters.Add(new SqlParameter("@NRPEDIDO", txtPesquisar.Text));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                    if (rdBtnNome.Checked == true)
                    {
                        string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                        SqlConnection conn = new SqlConnection(c);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("SELECT NRPEDIDO, TIPO, ped.CODCLIENTE, CODVENDEDOR,CODCONDICAOPAGAMENTO, CODTRANSPORTADORA, Convert(char(10),DATAEMISSAO,103)as DATAEMISSAO , Convert(char(10),DATAENTREGA,103) as DATAENTREGA " +
                            " FROM PEDIDO ped INNER JOIN CLIENTE cli ON ped.CODCLIENTE = cli.CNPJ ", conn);

                        cmd.Parameters.Add(new SqlParameter("@CODCLIENTE", txtPesquisar.Text + "%"));

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dtGrdVwVis.DataSource = table;
                    }

                }
                #endregion
            }

        }
        #endregion

        #region Double Click
        private void dtGrdVwVis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Double Click Pesquisa Usuario
            if (_parent is FrmCadUsu)
            {
                FrmCadUsu usu = (FrmCadUsu)_parent;

                // vamos obter as células selecionadas no DataGridView
                DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                DataGridViewCell celula = selecionadas[1];
                int linha = celula.RowIndex;
                int coluna = celula.ColumnIndex;


                usu.txtUsu.getText = celula.Value.ToString();

                this.Close();
                this.Dispose();
            }
            #endregion

            #region Double Click Pesquisa Pedido
            if (_parent is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)_parent;

                #region Double Click Pesquisa Cliente
                if (_controle.Name == "txtcodCli")
                {
                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                    DataGridViewCell celula = selecionadas[0];
                    int linha = celula.RowIndex;
                    int coluna = celula.ColumnIndex;


                    Ped.txtcodCli.getText = celula.Value.ToString();
                    Ped.txtNomeCliente.Text = selecionadas[1].Value.ToString();

                    this.Close();
                    this.Dispose();
                }
                #endregion

                #region Double Click Pesquisa Vendedor
                if (_controle.Name == "txtCodVendedor")
                {
                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                    DataGridViewCell celula = selecionadas[0];
                    int linha = celula.RowIndex;
                    int coluna = celula.ColumnIndex;


                    Ped.txtCodVendedor.getText = celula.Value.ToString();
                    Ped.txtNomeVendedor.Text = selecionadas[1].Value.ToString();

                    this.Close();
                    this.Dispose();
                }

                #endregion

                #region Double Click Pesquisa Condição Pagto
                if (_controle.Name == "txtCondPagto")
                {
                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                    DataGridViewCell celula = selecionadas[0];
                    int linha = celula.RowIndex;
                    int coluna = celula.ColumnIndex;


                    Ped.txtCondPagto.getText = celula.Value.ToString();


                    this.Close();
                    this.Dispose();
                }

                #endregion

                #region Double Click Pesquisa Transportadora
                if (_controle.Name == "txtCodTransportadora")
                {
                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                    DataGridViewCell celula = selecionadas[0];
                    int linha = celula.RowIndex;
                    int coluna = celula.ColumnIndex;


                    Ped.txtCodTransportadora.getText = celula.Value.ToString();
                    Ped.txtNomeTransportadora.Text = selecionadas[1].Value.ToString();

                    this.Close();
                    this.Dispose();
                }

                #endregion

                #region Double Click Pesquisa Produto
                if (_controle.Name == "txtProduto")
                {
                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                    DataGridViewCell celula = selecionadas[0];
                    int linha = celula.RowIndex;
                    int coluna = celula.ColumnIndex;


                    Ped.txtProduto.getText = celula.Value.ToString();
                    Ped.txtDescprod.Text = selecionadas[1].Value.ToString();
                    Ped.txtUM.Text = selecionadas[2].Value.ToString();
                    Ped.txtEstAtual.Text = selecionadas[3].Value.ToString();
                    Ped.txtPrcUnit.Text = selecionadas[4].Value.ToString();
                    Ped.txtipi.Text = selecionadas[5].Value.ToString();
                    Ped.txtDesconto.Text = selecionadas[6].Value.ToString();

                    this.Close();
                    this.Dispose();
                }

                #endregion

            }

            #endregion

            #region Double Click Pesquisa Cliente
            if (_parent is frmConCli)
            {
                frmConCli cli = (frmConCli)_parent;

                DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;
                DataGridViewCell celula = selecionadas[0];
                int linha = celula.RowIndex;
                int coluna = celula.ColumnIndex;

                cli.txtCnpjCli.getText = celula.Value.ToString();
                cli.txtNomeFantasiaCli.Text = selecionadas[1].Value.ToString();

                this.Close();
                this.Dispose();
            }

            #endregion

            #region Double Click Consulta Produto

            #region Produto
            if ((_parent is FrmCadProd))
            {
                if (_controle.Name == "txtBtnCodGrp")
                {
                    FrmCadProd conprod = (FrmCadProd)_parent;

                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;
                    DataGridViewCell celula = selecionadas[0];

                    conprod.txtBtnCodGrp.getText = celula.Value.ToString();
                    conprod.txtGrupo.Text = selecionadas[1].Value.ToString();

                    this.Close();
                    this.Dispose();
                }
            }
            #endregion

            #region Produto
            if ((_parent is FrmConPDV) || (_parent is FrmConEstProd) || (_parent is FrmConProd))
            {
                if (_controle.Name == "txtBtnCodGrp")
                {
                    FrmConProd conprod = (FrmConProd)_parent;

                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;
                    DataGridViewCell celula = selecionadas[0];

                    conprod.txtBtnCodGrp.getText = celula.Value.ToString();
                    conprod.txtGrupo.Text = selecionadas[1].Value.ToString();

                    this.Close();
                    this.Dispose();
                }

                #region Double Click Consulta Produto
                if (_controle.Name == "txtCodProd")
                {
                    FrmConPDV ConPed = (FrmConPDV)_parent;

                    // vamos obter as células selecionadas no DataGridView
                    DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                    DataGridViewCell celula = selecionadas[0];

                    ConPed.txtCodProd.getText = celula.Value.ToString();

                    this.Close();
                    this.Dispose();
                }

                if (_controle.Name == "txtBtnCodProd")
                {
                    FrmConEstProd EstProd = null;
                    FrmConProd prod = null;
                    if (_parent.GetType() == typeof(FrmConProd))
                    {
                        prod = (FrmConProd)_parent;
                        DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                        DataGridViewCell celula = selecionadas[0];

                        prod.txtBtnCodProd.getText = celula.Value.ToString();
                        prod.txtProdDesc.Text = selecionadas[1].Value.ToString();
                    }

                    else
                    {
                        EstProd = (FrmConEstProd)_parent;
                        DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                        DataGridViewCell celula = selecionadas[0];

                        EstProd.txtBtnCodProd.getText = celula.Value.ToString();
                    }


                    // vamos obter as células selecionadas no DataGridView



                    this.Close();
                    this.Dispose();
                }

                #endregion

            #endregion

            }
            #endregion

            #region Double Click Processo Pedido
            if (_controle.Name == "txtbtnPedido")
            {
                FrmLibPDV PedLib = (FrmLibPDV)_parent;
                // vamos obter as células selecionadas no DataGridView
                DataGridViewSelectedCellCollection selecionadas = dtGrdVwVis.SelectedCells;

                DataGridViewCell celula = selecionadas[0];
                int linha = celula.RowIndex;
                int coluna = celula.ColumnIndex;

                PedLib.txtbtnPedido.getText = selecionadas[0].Value.ToString();

                if (selecionadas[1].Value.ToString() == "N")
                {
                    PedLib.chkNormal.Checked = true;
                }
                else
                {
                    PedLib.chkNormal.Checked = false;
                }

                if (selecionadas[1].Value.ToString() == "C")
                {
                    PedLib.chkComplemento.Checked = true;
                }
                else
                {
                    PedLib.chkComplemento.Checked = false;
                }
                PedLib.txtCodCliente.Text = selecionadas[2].Value.ToString();
                PedLib.txtCodVendedor.Text = selecionadas[3].Value.ToString();
                PedLib.txtCondPagto.Text = selecionadas[4].Value.ToString();
                PedLib.txtCodTransportadora.Text = selecionadas[5].Value.ToString();
                PedLib.dtpEntrega.Text = selecionadas[7].Value.ToString();
                PedLib.dtpEmissao.Text = selecionadas[6].Value.ToString();

                PedLib.txtNomeCliente.Text = Convert.ToString(PedLib.ListarNomeCliente(PedLib.txtCodCliente.Text));
                PedLib.txtNomeTransportadora.Text = Convert.ToString(PedLib.ListarNomeTransportadora(PedLib.txtCodTransportadora.Text));
                PedLib.txtNomeVendedor.Text = Convert.ToString(PedLib.ListarNomeVendedor(PedLib.txtCodVendedor.Text));
                PedLib.populargrid();

                this.Close();
                this.Dispose();
            }
            #endregion
        }
        #endregion

        private void FrmVisGeral_Load(object sender, EventArgs e)
        {

        }
    }
}
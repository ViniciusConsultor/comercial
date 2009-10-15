using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (_parent is FrmCadPed)
            {
                FrmCadPed Ped = (FrmCadPed)_parent;

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

                if (_controle.Name == "txtProduto")
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

            }
            #endregion

            #region FormPesquisa Claudio
            if (_parent is frmConCli)
            {
                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(c);
                conn.Open();
                String consulta="select cnpj,nomefantasia from cliente where ";
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
                else cmd.Parameters.Add(new SqlParameter("@nomefantasia","%"+txtPesquisar.Text+"%"));

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dtGrdVwVis.DataSource = table;
               
            }

            #endregion

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
                    Ped.txtPrcVen.Text = selecionadas[4].Value.ToString();

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
        }
        #endregion

        private void FrmVisGeral_Load(object sender, EventArgs e)
        {

        }
    }
}

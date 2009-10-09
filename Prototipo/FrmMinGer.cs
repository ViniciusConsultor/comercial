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
    public partial class FrmMinGer : Form
    {
        private FrmPrinc _princ = null;

        private string _algoritmo;



        public FrmMinGer(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

        public FrmPrinc getPrinc()
        {
            return _princ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

        }

        private void dtGrdVwCampos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstBxTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click_1(object sender, EventArgs e)
        {

        }

        private void rdBtnCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnDia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckBxDia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmMinGer_Load(object sender, EventArgs e)
        {


        }

        private void lstBxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMinGer_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpProcesso", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;
            foreach (ToolStripButton x in strip2.Items)
            {
                x.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBxTipoDataMining_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTipoDataMining.SelectedIndex == 0)
            {
                rchTxtBxTexto.Text = "O algoritmo Árvores de Decisão é um algoritmo de decisão adequado para modelos de previsão. O algoritmo oferece suporte à previsão de atributos discretos e contínuos.";
            }

            if (cmbBxTipoDataMining.SelectedIndex == 1)
            {
                rchTxtBxTexto.Text = "O algoritmo de agrupamento usa técnicas iterativas para agrupar registros de um conjunto de dados em clusters que contenham características semelhantes. Isso é útil quando você deseja encontrar agrupamentos gerais nos seus dados.";
            }

            if (cmbBxTipoDataMining.SelectedIndex == 2)
            {
                rchTxtBxTexto.Text = "O algoritmo MTS usa uma combinação de análise ARIMA e de regressão linear com base em árvores de decisão para analisar os dados relacionados a tempo, por exemplo, dados de vendas mensais ou lucros anuais. Os padrões descobertos podem ser usados para prever valores para futuros períodos. O algoritmo pode ser personalizado para usar ou método de árvore de decisão ou ARIMA, ou mesmo ambos.";
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {

            //Pedido...

            if (checkBox32.Checked)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "NrPedido");
                dataGridView1.Rows.Add(false, "CodCliente");
                dataGridView1.Rows.Add(false, "CodVendedor");
                dataGridView1.Rows.Add(false, "Tipo");
                dataGridView1.Rows.Add(false, "DataEmissao");
                dataGridView1.Rows.Add(false, "DataEntrega");
                dataGridView1.Rows.Add(false, "NrNotaFiscal");
                dataGridView1.Rows.Add(false, "CodCondicaoPagamento");
                dataGridView1.Rows.Add(false, "CodTransportadora");
                dataGridView1.Rows.Add(false, "Situacao");
            }
            else
            {
                dataGridView1.Rows.Clear();

            }




        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            //Produto...

            if (checkBox31.Checked)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodProduto");
                dataGridView1.Rows.Add(false, "Descricao");
                dataGridView1.Rows.Add(false, "DataCadastro");
                dataGridView1.Rows.Add(false, "PrecoCusto");
                dataGridView1.Rows.Add(false, "PesoLiquido");
                dataGridView1.Rows.Add(false, "CodUnidadeMedida");
                dataGridView1.Rows.Add(false, "CodGrupoProduto");
                dataGridView1.Rows.Add(false, "PrecoVenda");
                dataGridView1.Rows.Add(false, "EstoqueAtual");
                dataGridView1.Rows.Add(false, "EstoqueMinimo");
                dataGridView1.Rows.Add(false, "IPI");
            }
            else
            {
                dataGridView1.Rows.Clear();

            }

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

            //Item...

            if (checkBox36.Checked)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "NrPedido");
                dataGridView1.Rows.Add(false, "CodProduto");
                dataGridView1.Rows.Add(false, "Quantidade");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {


            //Grupo de produto...

            if (checkBox30.Checked)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodGrupoPrduto");
                dataGridView1.Rows.Add(false, "Descricao");
                dataGridView1.Rows.Add(false, "Desconto");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {



            //Cliente...

            if (checkBox29.Checked)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodCliente");
                dataGridView1.Rows.Add(false, "RazaoSocial");
                dataGridView1.Rows.Add(false, "NomeFantasia");
                dataGridView1.Rows.Add(false, "Telefone");
                dataGridView1.Rows.Add(false, "Email");
                dataGridView1.Rows.Add(false, "CNPJ");
                dataGridView1.Rows.Add(false, "IE");
                dataGridView1.Rows.Add(false, "Endereco");
                dataGridView1.Rows.Add(false, "Bairro");
                dataGridView1.Rows.Add(false, "Municipio");
                dataGridView1.Rows.Add(false, "UF");
                dataGridView1.Rows.Add(false, "CEP");
                dataGridView1.Rows.Add(false, "CodRegiao");
                dataGridView1.Rows.Add(false, "CodUsuario");
                dataGridView1.Rows.Add(false, "AreaAtuacao");
                dataGridView1.Rows.Add(false, "LimiteCred");
                dataGridView1.Rows.Add(false, "AprovadoCred");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {


            //Vendedor...

            if (checkBox28.Checked)
            {

                dataGridView1.Rows.Clear();
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodVendedor");
                dataGridView1.Rows.Add(false, "Nome");
                dataGridView1.Rows.Add(false, "Endereco");
                dataGridView1.Rows.Add(false, "Bairro");
                dataGridView1.Rows.Add(false, "Municipio");
                dataGridView1.Rows.Add(false, "UF");
                dataGridView1.Rows.Add(false, "CEP");
                dataGridView1.Rows.Add(false, "Telefone");
                dataGridView1.Rows.Add(false, "Fax");
                dataGridView1.Rows.Add(false, "CPF");
                dataGridView1.Rows.Add(false, "RG");
                dataGridView1.Rows.Add(false, "Email");
                dataGridView1.Rows.Add(false, "Comissao");
                dataGridView1.Rows.Add(false, "Sexo");
                dataGridView1.Rows.Add(false, "CodRegiao");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {


            //Condicao Pagamento...

            if (checkBox28.Checked)
            {

                dataGridView1.Rows.Clear();
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodCondicaoPagamento");
                dataGridView1.Rows.Add(false, "Descricao");
                dataGridView1.Rows.Add(false, "DiasCondicao");
                dataGridView1.Rows.Add(false, "Entrada");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }


        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            //Transportadora...

            if (checkBox28.Checked)
            {

                dataGridView1.Rows.Clear();
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodTransportadora");
                dataGridView1.Rows.Add(false, "Nome");
                dataGridView1.Rows.Add(false, "NomeReduzido");
                dataGridView1.Rows.Add(false, "ViaTransporte");
                dataGridView1.Rows.Add(false, "Endereco");
                dataGridView1.Rows.Add(false, "Bairro");
                dataGridView1.Rows.Add(false, "Municipio");
                dataGridView1.Rows.Add(false, "CEP");
                dataGridView1.Rows.Add(false, "Telefone");
                dataGridView1.Rows.Add(false, "CNPJ");
                dataGridView1.Rows.Add(false, "IE");
                dataGridView1.Rows.Add(false, "Email");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

            //Regiao

            if (checkBox28.Checked)
            {
                dataGridView1.Rows.Clear();

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

                dataGridView1.Rows.Add(false, "CodRegiao");
                dataGridView1.Rows.Add(false, "Descricao");
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(c);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from sys.all_objects where type in ('U','V') "+
                                                "and schema_id = '1'and name not like 'sysdiagrams'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                foreach (var r in reader)
                {
                    treeView1.Nodes.Add(reader["name"].ToString());
                }
            }

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            string node = treeView1.SelectedNode.Name;

            foreach (TreeNode item in treeView1.Nodes)
            {
                item.Checked = false;
            }

        //    node.Checked = true;
        }

    }
}

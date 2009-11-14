using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Comercial
{
    public partial class FrmCadProd : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            _princ.bindingNavigator1.BindingSource = pRODUTOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);

            // novo

            _princ.novo();
        }

        private void FrmCadProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.UNIDADEMEDIDA' table. You can move, or remove it, as needed.
            this.uNIDADEMEDIDATableAdapter.Fill(this.cOMERCIALDataSet.UNIDADEMEDIDA);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PRODUTO' table. You can move, or remove it, as needed.
        }

        private void FrmCadProd_Shown(object sender, EventArgs e)
        {
            pRODUTOTableAdapter.Fill(cOMERCIALDataSet.PRODUTO);
        }

        public int salvar()
        {
            String g = dtmPckrCadastro.Text;

            DataRowView objProduto = (DataRowView)pRODUTOBindingSource.Current;
            objProduto["CODGRUPOPRODUTO"] = txtBtnCodGrp.getText;
            try
            {
                if (Convert.ToDouble(mskedTxtBxPrecoCusto.Text.Replace("R$", "").Replace(".", "")) < 0)
                {
                    MessageBox.Show("Preço de Custo Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Preço de Custo Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            try
            {
                if (Convert.ToDouble(mskedTxtBxPrecoUnitario.Text.Replace("R$", "").Replace(".", "")) < 0)
                {
                    MessageBox.Show("Preço Unitário Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Preço Unitário Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            if (Convert.ToDouble(mskedTxtBxIpi.Text) < 0 || Convert.ToDouble(mskedTxtBxIpi.Text) > 100)
            {
                MessageBox.Show("IPI Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            if (Convert.ToDouble(mskedTxtBxEstAtual.Text) < 0)
            {
                MessageBox.Show("Estoque Atual Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            if (Convert.ToDouble(mskedTxtBxEstMinimo.Text) < 0)
            {
                MessageBox.Show("Estoque Mínimo Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            if (Convert.ToDouble(txtPesoLiquido.Text) < 0)
            {
                MessageBox.Show("Peso Liquido Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            return 0;
        }

        public void novo()
        {
            dtmPckrCadastro.Value = DateTime.Now;
            dtmPckrCadastro.Enabled = false;
            txtGrupo.Enabled = false;
            txtGrupo.Text = "";
        }

        #region ListarGrpProdutoDataGridView Pesquisa
        public DataTable ListarGrupoProduto()
        {
            Database db = DatabaseFactory.CreateDatabase();

            DataSet dtsDados = new DataSet();

            StringBuilder sqlcommand = new StringBuilder();

            sqlcommand.Append("select codgrupoproduto, descricao from grupoproduto");

            DbCommand dbComd = db.GetSqlStringCommand(sqlcommand.ToString());

            dtsDados = db.ExecuteDataSet(dbComd);

            return dtsDados.Tables[0];

        }
        #endregion

        private void txtCodProd_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.dtGrdVwVis.DataSource = ListarGrupoProduto();
            x.Text = "Consulta Cadastro de Grupo Produto";

            x.ShowDialog();
        }

        private void pRODUTOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRODUTOBindingSource.Current != null)
            {
                DataRowView v = (DataRowView)pRODUTOBindingSource.Current;

                txtBtnCodGrp.getText = v["CODGRUPOPRODUTO"].ToString();
                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(c);
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from grupoproduto where codgrupoproduto = @gr", conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@gr";
                param.Value = txtBtnCodGrp.getText;
                cmd.Parameters.Add(param);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    txtGrupo.Text = reader["DESCRICAO"].ToString();
                }
                conn.Close();
                conn.Dispose();
            }
        }
    }
}

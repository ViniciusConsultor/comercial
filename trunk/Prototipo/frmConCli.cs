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
    public partial class frmConCli : Form
    {
        private FrmPrinc _princ = null;

        public frmConCli(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            
        }
        #region inutil

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckdLstBxColunas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tipo_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chckBxTudo_CheckStateChanged(object sender, EventArgs e)
        {
            
    }

        private void chckBxIE_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxRazaoSocial_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chckBxEndereco_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxBairro_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void chckBxMunicipio_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void chckBxCep_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void chckBxUf_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void chckBxTelefone_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxFax_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxEmail_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxPerfil_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxPotencialanual_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chckBxAreaatuacao_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckBxTudo_CheckedChanged(object sender, EventArgs e)
        {

        }
 #endregion
        private void txtCodPed_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.ShowDialog();

        }

        private void txtCodCli_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAreaAtu_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.ShowDialog();
        }

        private void frmConCli_Leave(object sender, EventArgs e)
        {
            Control[] z = _princ.Controls.Find("bindingNavigator1", true);
            ToolStrip strip = (ToolStrip)z[0];

            strip.Visible = true;

            Control[] y = _princ.Controls.Find("tlStrpConsulta", true);
            ToolStrip strip2 = (ToolStrip)y[0];

            strip2.Visible = false;

        }

        public void pesquisar()
        {
            string sql = "select p.CODCLIENTE,c.NOMEFANTASIA,p.NRPEDIDO,p.DATAEMISSAO,SUM(VALOR) valor from PEDIDO p, ITEMPEDIDO ip , CLIENTE c where p.NRPEDIDO=ip.NRPEDIDO and p.codCliente=c.cnpj ";
            string groupBy = " group by p.NRPEDIDO,  p.DATAEMISSAO,p.CODCLIENTE,c.NomeFantasia ";
            
            // pesquisa por nrPedido
            if (!string.IsNullOrEmpty(txtNumPed.Text))
            {
                sql += " and p.nrPedido = " + txtNumPed.Text;
            }

            // pesquisa por tipo pedido
            if (!string.IsNullOrEmpty(cmBxTipoPed.Text))
            {
                if (cmBxTipoPed.Text=="N = Normal")
                {
                    sql += " and p.tipo = 'N'";
                }
                else sql += " and p.tipo = 'C'";
                
            }

            
            // pesquisa por situacao pedido
            if (rdbtnEfetivado.Checked)
            {
                sql += " and p.situacao ='E'";
            }

            if (rdbtnPendente.Checked)
            {
                sql += " and p.situacao ='P'";
            }

            if (rdbtnCancelado.Checked)
            {
                sql += " and p.situacao = 'C'";
            }


            //Pesquisa por data
            if (dttmDataPedido.Checked)
            {
                string formatData = dttmDataPedido.Value.Year + "-" + dttmDataPedido.Value.Month + "-" + dttmDataPedido.Value.Day;

                sql += " and p.dataEmissao= '"+formatData+"'";
            }
            // Pesquisa por CNPJ Cliente
            if (!string.IsNullOrEmpty(txtCnpjCli.Text))
            {

                sql += " and c.cnpj =" + txtCnpjCli.Text;
               
            }
            //Pesquisa por área de atuação do cliente
            if (!string.IsNullOrEmpty(cmbAreaAtuCli.Text))
            {
                sql += " and c.areaAtuacao ='" + cmbAreaAtuCli.Text + "'";

            }
            //Pesquisa por razão social do cliente
            if (!string.IsNullOrEmpty(txtRazaoSocialCli.Text))
            {
                sql += " and c.RazaoSocial like '%" + txtRazaoSocialCli.Text + "%' ";
            }
            if (!string.IsNullOrEmpty(txtNomeFantasiaCli.Text))
            {
                sql += " and c.NomeFantasia like '%" + txtNomeFantasiaCli.Text + "%' ";
            }


            sql += groupBy;
            

             string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;

             SqlConnection conn = new SqlConnection(c);
             conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);


                dtgrdConCli.DataSource = table;

            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                rdbtnCancelado.Checked = false;
                rdbtnEfetivado.Checked = false;
                rdbtnPendente.Checked = false;
                //groupBox2.Enabled = false;
            }
            else rdbtnEfetivado.Checked=true;
        }

        private void rdbtnEfetivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEfetivado.Checked == true)
                checkBox1.Checked = true;

        }

        private void rdbtnPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPendente.Checked == true)
                checkBox1.Checked = true;
        }

        private void rdbtnCancelado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCancelado.Checked == true)
                checkBox1.Checked = true;
        }

        private void frmConCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);

        }

        private void txtCnpjCli_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this, (Control)sender);
            x.Text = "Pesquisa Cadastro de Cliente";
            x.ShowDialog();
        }


      }
    }
    

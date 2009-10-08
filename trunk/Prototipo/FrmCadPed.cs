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
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.ObjectBuilder;
using System.Data.Common;
using System.Data.OleDb;

namespace Comercial
{
    public partial class FrmCadPed : Form
    {
        private FrmPrinc _princ = null;

        public FrmCadPed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
            _princ.bindingNavigator1.BindingSource = pEDIDOBindingSource;
            _princ.setdataSet(cOMERCIALDataSet);
            _princ.novo();
        }

        private void textButton1_ButtonClick_1(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void textButton4_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();

        }

        private void textButton2_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void textButton5_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void textButton3_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void FrmCadPed_Load(object sender, EventArgs e)
        {


        }

        private void pEDIDOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pEDIDOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOMERCIALDataSet);

        }

        private void FrmCadPed_Shown(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CONDICAOPAGAMENTO' table. You can move, or remove it, as needed.
            this.cONDICAOPAGAMENTOTableAdapter.Fill(this.cOMERCIALDataSet.CONDICAOPAGAMENTO);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.cOMERCIALDataSet.CLIENTE);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.VENDEDOR' table. You can move, or remove it, as needed.
            this.vENDEDORTableAdapter.Fill(this.cOMERCIALDataSet.VENDEDOR);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.CONDICAOPAGAMENTO' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'cOMERCIALDataSet.TRANSPORTADORA' table. You can move, or remove it, as needed.
            this.tRANSPORTADORATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORA);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.TRANSPORTADORA' table. You can move, or remove it, as needed.
            this.tRANSPORTADORATableAdapter.Fill(this.cOMERCIALDataSet.TRANSPORTADORA);
            // TODO: This line of code loads data into the 'cOMERCIALDataSet.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.cOMERCIALDataSet.PEDIDO);

        }

        public int SalvarPedidoCab()
        {
            DataRowView objPedido;
            objPedido = (DataRowView)pEDIDOBindingSource.Current;

            if (chkCancelado.Checked)
            {

                objPedido["SITUACAO"] = "C";
            }
            else if (chkEfetivado.Checked)
            {
                objPedido["SITUACAO"] = "E";
            }
            else
            {
                objPedido["SITUACAO"] = "P";
            }

            if (chkNormal.Checked)
            {

                objPedido["TIPO"] = "N";
            }
            else
            {
                objPedido["TIPO"] = "C";
            }


            return 0;

        }

        private void nRPEDIDOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pEDIDOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView objPedido;
            objPedido = (DataRowView)pEDIDOBindingSource.Current;

            if (objPedido["SITUACAO"].ToString() == "C")
            {
                chkCancelado.Checked = true;
            }
            else
            {
                chkCancelado.Checked = false;
            }
            if (objPedido["SITUACAO"].ToString() == "E")
            {
                chkEfetivado.Checked = true;
            }
            else
            {
                chkPendente.Checked = false;
            }

            if (objPedido["SITUACAO"].ToString() == "P")
            {
                chkPendente.Checked = true;
            }
            else
            {
                chkPendente.Checked = false;
            }

            if (objPedido["TIPO"].ToString() == "N")
            {
                chkNormal.Checked = true;
            }
            else
            {
                chkNormal.Checked = false;
            }


            if (objPedido["TIPO"].ToString() == "C")
            {
                chkComplemento.Checked = true;
            }
            else
            {
                chkComplemento.Checked = false;
            }

        }







    }
}

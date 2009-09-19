using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comercial
{
    public partial class FrmCadPed : Form
    {
        private BindingSource source;
        private COMERCIALEntities db;

        private FrmPrinc _princ = null;


        private void FrmCadPed_Load(object sender, EventArgs e)
        {
            var query = from ped in db.PEDIDO
                        select ped;

            pEDIDOBindingSource.DataSource = query;

        }

        public FrmCadPed(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;

            ComercialDAO DAO = new ComercialDAO();
            db = DAO.getComercialEntities();

            parent.setdb(db);
        }


        #region Generico
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
        #endregion

        #region Salvar
        public void salvar()
        {
            PEDIDO ped = (PEDIDO)pEDIDOBindingSource.Current;
            {

                PEDIDO objPedido = new PEDIDO();
                objPedido.CLIENTE.CNPJ = txtBtnCodCli.getText;
                objPedido.VENDEDOR.CPF = txtBtnCodVend.getText;
                objPedido.CONDICAOPAGAMENTO.CODCONDICAOPAGAMENTO = Convert.ToInt32(txtBtnCondPgto.getText);
                objPedido.TRANSPORTADORA.CNPJ = txtBtnTransp.getText;

                if (rdbpend.Checked)
                {
                    ped.SITUACAO = "P";
                }
                else if (rdbefet.Checked)
                {
                    ped.SITUACAO = "E";
                }
                else
                {
                    ped.SITUACAO = "C";
                }

            }
        }
        #endregion
       

        private void grpBxPedVenda_Enter(object sender, EventArgs e)
        {

            _princ.bindingNavigator1.BindingSource = pEDIDOBindingSource;
            _princ.setsource(pEDIDOBindingSource);

        }

        private void grpBxItPedVen_Enter(object sender, EventArgs e)
        {
            _princ.bindingNavigator1.BindingSource = iTEMPEDIDOBindingSource;
            _princ.setsource(iTEMPEDIDOBindingSource);

        }

        private void pEDIDOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PEDIDO ped = (PEDIDO)pEDIDOBindingSource.Current;

            if (ped.SITUACAO == "P")
            {
                rdbpend.Checked = true;
            }
            else if (ped.SITUACAO == "E")
            {
                rdbefet.Checked = true;
            }
            else
            {
                rdbcanc.Checked = true;
            }
            
        }

    }
}

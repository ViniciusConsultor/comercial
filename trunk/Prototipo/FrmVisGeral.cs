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
    public partial class FrmVisGeral : Form
    {
        private Form _parent;

        public FrmVisGeral(Form parent)
        {
            InitializeComponent();
            _parent = parent;

            if (_parent is FrmPrinc)
            {
                Form form = _parent.MdiChildren[0];

                if (form is FrmCadPed)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Data";

                    ClmUm.HeaderText = "Código Ped.";
                    ClmDois.HeaderText = "Código Cliente";
                }

                if (form is FrmCadCli)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Nome";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Nome";
                }

                if (form is FrmCadProd)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Descrição";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Descrição";
                }

                if (form is FrmCadVen)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Nome";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Nome";
                }

                if (form is FrmCadGrpProd)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Descrição";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Descrição";
                }

                if (form is FrmCadConPag)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Descrição";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Descrição";
                }

                if (form is FrmCadTes)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Descrição";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Descrição";
                }

                if (form is FrmCadTra)
                {
                    rdBtnCod.Text = "Código";
                    rdBtnNome.Text = "Descrição";

                    ClmUm.HeaderText = "Código";
                    ClmDois.HeaderText = "Descrição";
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmCadPed x = (FrmCadPed)_parent;

            
        }
    }
}

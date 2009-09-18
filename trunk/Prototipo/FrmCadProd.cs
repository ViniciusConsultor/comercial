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
    public partial class FrmCadProd : Form
    {
       private FrmPrinc _princ = null;

       public FrmCadProd(FrmPrinc parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _princ = parent;
        }

       /* private MaskUtil atribuiMascara(char caractere, string texto)
        {   //preenche atributos mascara

            MaskUtil objetoMascara = new MaskUtil();
            objetoMascara.recebeTecla(caractere);
            objetoMascara.recebePalavra(texto);

            return objetoMascara;
        }
        */
        private void mskedTxtBxImpostos_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* MaskUtil mascara = atribuiMascara((char)e.KeyChar, mskedTxtBxImpostos.Text);

            if (!(e.Handled = mascara.mascaraNumero(6))) //este numero é a quantidade de caracteres maximo do campo
                mskedTxtBxImpostos.Text = mascara.mascaraMoeda();

            mskedTxtBxImpostos.SelectionStart = mskedTxtBxImpostos.Text.Length + 1;*/
        }

        private void mskedTxtBxPrecoUnitario_Leave(object sender, EventArgs e)
        {
            //mskedTxtBxPrecoUnitario.Text = String.Format("{0:c}", mskedTxtBxPrecoUnitario.Text);
        }

        private void txtFabricante_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

        private void txtGrupo_ButtonClick(object sender, EventArgs e)
        {
            FrmVisGeral x = new FrmVisGeral(this);
            x.ShowDialog();
        }

       
    }
}

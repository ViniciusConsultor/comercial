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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ComercialDAO dao = new ComercialDAO();
            var db = dao.getComercialEntities();

            var login = from x in db.USUARIO
                        where x.USUARIO1 == txtusu.Text
                        where x.SENHA == txtsenha.Text
                        select new
                        {
                            usuario = x.USUARIO1,
                            bloqueado = x.BLOQUEADO,
                            privilegiado = x.PRIVILEGIADO,
                            codusu = x.CODUSUARIO
                        };
            
            

            if (login.Count() >= 1)
            {
                //Verifica Bloqueado
                if (login.FirstOrDefault().bloqueado != "S")
                {

                    // verifica se é privilegiado
                    if (login.FirstOrDefault().privilegiado == "S")
                    {
                        FrmPrinc princ = new FrmPrinc();
                        princ.Show();
                        this.Hide();
                        db.Dispose();
                    }
                    else
                    {
                        //Verificar permissoes
                        // ************ ARRUMAR ************
                        FrmPrinc princ = new FrmPrinc();
                        princ.Show();
                        this.Hide();
                        db.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário Bloqueado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

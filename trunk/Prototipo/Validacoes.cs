using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Configuration;

namespace Comercial
{
    class Validacoes
    {
        #region Validação de CPF


        public int ValidaCPF(string cpf)
        {
            int soma = 0;
            int d1;
            int d2;
            int resto;
            int contador;
            int resultado;

            for (int i = 0; i < cpf.Length - 2; i++)
            {
                soma += Convert.ToInt32(Convert.ToString(cpf[i])) * (i + 1);
            }

            resto = soma % 11;

            if (resto == 10)
                d1 = 0;
            else d1 = resto;

            contador = 11;
            soma = 0;
            for (int i = 0; i < cpf.Length - 1; i++)
            {
                soma += Convert.ToInt32(Convert.ToString(cpf[i])) * contador;
                contador--;
            }

            resto = (soma * 10) % 11;

            if (resto == 10)
                d2 = 0;
            else d2 = resto;

            if (d1 == Convert.ToInt32(Convert.ToString(cpf[9])) && d2 == Convert.ToInt32(Convert.ToString(cpf[10])))
                resultado = 0;
            else resultado = 1;

            return resultado;

        }
        #endregion

        #region Validação de CNPJ


        public int ValidaCNPJ(string cnpj)
        {
            int result;
            int d1;
            int d2;
            int soma = 0;
            for (int i = 0; i < cnpj.Length - 2; i++)
            {
                switch (i)
                {
                    case 0: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 5; break;
                    case 1: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 4; break;
                    case 2: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 3; break;
                    case 3: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 2; break;
                    case 4: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 9; break;
                    case 5: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 8; break;
                    case 6: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 7; break;
                    case 7: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 6; break;
                    case 8: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 5; break;
                    case 9: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 4; break;
                    case 10: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 3; break;
                    case 11: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 2; break;
                }
            }
            int resto = (soma % 11);

            if (resto == 1 || resto == 0)
                d1 = 0;
            else
            {
                resto = 11 - resto;
                d1 = resto;
            }

            soma = 0;
            for (int i = 0; i < cnpj.Length - 2; i++)
            {
                switch (i)
                {
                    case 0: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 6; break;
                    case 1: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 5; break;
                    case 2: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 4; break;
                    case 3: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 3; break;
                    case 4: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 2; break;
                    case 5: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 9; break;
                    case 6: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 8; break;
                    case 7: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 7; break;
                    case 8: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 6; break;
                    case 9: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 5; break;
                    case 10: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 4; break;
                    case 11: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 3; break;
                }
            }
            soma += d1 * 2;
            resto = (soma % 11);
            if (resto == 1 || resto == 0)
                d2 = 0;
            else
            {
                resto = 11 - resto;
                d2 = resto;
            }

            if (d1 == Convert.ToInt32(Convert.ToString(cnpj[12])) && d2 == Convert.ToInt32(Convert.ToString(cnpj[13])))
                result = 0;
            else result = 1;

            return result;

        }
        #endregion

        #region Validação de email
        public bool ValidaEmail(string email)
        {

            // Expressão regular que vai validar os e-mails
            string emailRegex = @"^(([^<>()[\]\\.,;áàãâäéèêëíìîïóòõôöúùûüç:\s@\""]+"
            + @"(\.[^<>()[\]\\.,;áàãâäéèêëíìîïóòõôöúùûüç:\s@\""]+)*)|(\"".+\""))@"
            + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|"
            + @"(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$";

            // Instância da classe Regex, passando como 
            // argumento sua Expressão Regular 
            Regex rx = new Regex(emailRegex);

            // Método IsMatch da classe Regex que retorna
            // verdadeiro caso o e-mail passado estiver
            // dentro das regras da sua regex.
            return rx.IsMatch(email);
        }

        #endregion

        #region Tratar SystemExceções
        public void tratarSystemExceções(Exception ex)
        {

            if (ex.GetType().FullName == "System.Data.ConstraintException")
                MessageBox.Show("Registro já cadastrado (Violação de chave primária)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.GetType().FullName == "System.Data.NoNullAllowedException" || ex.GetType().FullName == "System.InvalidOperationException" || ex.GetType().FullName == "System.ArgumentException" || ex.GetType().FullName == "System.FormatException" || ex.Message == "campo vazio")
                MessageBox.Show("Campo(s) Obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.GetType().FullName == "System.FormatException")
                MessageBox.Show("Quantidade não pode ser 0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "cnpj invalido")
                MessageBox.Show("CNPJ Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "Grid Vazio")
                MessageBox.Show("Não há dados para gerar o relatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "email invalido")
                MessageBox.Show("Email Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "ie invalida")
                MessageBox.Show("I.E. Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "valor invalido")
                MessageBox.Show("Limite de crédito inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "Efetivado")
                MessageBox.Show("Pedido não pode ser alterado pois já está Efetivado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "Cancelado")
                MessageBox.Show("Pedido não pode ser alterado pois está Cancelado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "DataInvalida")
                MessageBox.Show("Data de entrega não pode ser inferior a data de emissão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "DataSistema")
                MessageBox.Show("Data de Emissão não pode ser inferior a data do sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "Quantidade")
                MessageBox.Show("Quantidade não pode ser 0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "valortotal")
                MessageBox.Show("Valor Total não pode ser 0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "QuantidadeNegativa")
                MessageBox.Show("Quantidade não pode ser negativa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "valortotalnegativo")
                MessageBox.Show("Valor Total não pode ser negativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "PrecoUnitario")
                MessageBox.Show("Preço Unitário não pode ser 0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "PrecoUnitarioNegativo")
                MessageBox.Show("Preço Unitário não pode ser negativo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "ValidaEstoque")
                MessageBox.Show("Saldo em Estoque Indisponivel!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "ValidaLimite")
                MessageBox.Show("Limite de Credito insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "ValidaQtdeLiberada")
                MessageBox.Show("Quantidade liberada não pode ser superior a quantidade do pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (ex.Message == "ItenLibMenor")
                MessageBox.Show("A quantidade liberada é inválida \nJá existe quantidade liberada anteriormente!.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            else MessageBox.Show("Erro desconhecido.\nContate o administrador do sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Tratar SqlExceções

        public void tratarSqlExceções(SqlException sqlex)
        {
            int erro = sqlex.ErrorCode;
            if (erro == -2146232060)
            {
                MessageBox.Show("Campo(s) Obrigatório(s) não preenchido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Erro desconhecido.\nContate o administrador do sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Procura_CEP

        public string procuraCEP(string cep)
        {
            try
            {
                string sql = "select c.cidade_descricao cidade, u.uf_sigla UF, bairro_descricao bairro, endereco_logradouro endereco, " +
                "endereco_complemento complemento " +
                "from cidade c inner join uf u on u.uf_codigo = c.uf_codigo " +
                           "left join bairro b on c.cidade_codigo = b.cidade_codigo " +
                           "left join endereco e on b.bairro_codigo = e.bairro_codigo " +
                "where ISNULL(e.endereco_cep,c.cidade_cep) = @CEP";

                string c = ConfigurationManager.ConnectionStrings["Comercial.Properties.Settings.COMERCIALConnectionString"].ConnectionString;


                SqlConnection conn = new SqlConnection(c);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@CEP", cep));
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                if (reader.HasRows)
                {
                    return reader["cidade"].ToString() + ";" + reader["UF"].ToString() + ";" +
                            reader["bairro"].ToString() + ";" + reader["endereco"].ToString() + ";" +
                            reader["complemento"].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }


        }
        #endregion

    }


}



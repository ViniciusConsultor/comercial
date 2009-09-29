using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercial
{
    class Validacoes
    {
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



        public int ValidaCNPJ(string cnpj)
        {
            /*int result;
            int d1;
            int d2;
            int soma = 0;
            for (int i = 0; i < cnpj.Length - 2; i++)
            {
                switch (i)
                {
                    case 0: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 5;break;
                    case 1: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 4;break;
                    case 2: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 3;break;
                    case 3: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 2;break;
                    case 4: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 9;break;
                    case 5: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 8;break;
                    case 6: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 7;break;
                    case 7: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 6;break;
                    case 8: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 5;break;
                    case 9: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 4;break;
                    case 10: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 3;break;
                    case 11: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 2;break;
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
                    case 0: soma += Convert.ToInt32(Convert.ToString(cnpj[i])) * 6;break;
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
        
            */
            return 0;
        }
    }


}



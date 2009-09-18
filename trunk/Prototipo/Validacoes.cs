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

    }


}

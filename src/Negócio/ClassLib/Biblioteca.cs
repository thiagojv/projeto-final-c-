using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Biblioteca
    {
        public static int ConverterBool2Int(bool Valor)
        {
            if (Valor)
                return 1;
            else
                return 0;
        }

        public static string FormatarNumero(double Numero)
        {
            string strngNumero = Numero.ToString();

            strngNumero = strngNumero.Replace(",", ".");

            return strngNumero;
        }

        public static string FormatarData(DateTime DataHora)
        {
            string strngDia = DataHora.Day.ToString();
            string strngMes = DataHora.Month.ToString();
            string strngAno = DataHora.Year.ToString();

            return strngMes + "/" + strngDia + "/" + strngAno;
        }

        public static double FormatarDecimais(double Numero)
        {
            return Convert.ToDouble(string.Format("{0:F3}", Numero));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Tamanho : Ancestral
    {
        private int intCodigo;
        private string strngDescricao;
        private double dcmlTamanho_Min;
        private double dcmlTamanho_Max;

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public string Descricao
        {
            get { return strngDescricao; }
            set { strngDescricao = value; }
        }

        public double Tamanho_Min
        {
            get { return dcmlTamanho_Min; }
            set { dcmlTamanho_Min = value; }
        }

        public double Tamanho_Max
        {
            get { return dcmlTamanho_Max; }
            set { dcmlTamanho_Max = value; }
        }
    }
}

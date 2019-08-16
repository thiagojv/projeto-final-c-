using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Esforco : Ancestral
    {
        private int intModelo;
        private int intTipoFundamental;
        private double dblEsforcoFatorMultiplicacao;
        private double dblEsforcoExponencial;

        public int Modelo
        {
            get { return intModelo; }
            set { intModelo = value; }
        }

        public int TipoFundamental
        {
            get { return intTipoFundamental; }
            set { intTipoFundamental = value; }
        }

        public double EsforcoFatorMultiplicacao
        {
            get { return dblEsforcoFatorMultiplicacao; }
            set { dblEsforcoFatorMultiplicacao = value; }
        }

        public double EsforcoExponencial
        {
            get { return dblEsforcoExponencial; }
            set { dblEsforcoExponencial = value; }
        }
    }
}

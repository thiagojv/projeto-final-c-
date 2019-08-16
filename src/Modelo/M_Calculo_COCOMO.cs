using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Calculo_COCOMO : Ancestral
    {
        private double dblKDSI;
        private double dblEsforco;
        private double dblPrazo;

        public double KDSI
        {
            get { return dblKDSI; }
            set { dblKDSI = value; }
        }

        public double Esforco
        {
            get { return dblEsforco; }
            set { dblEsforco = value; }
        }

        public double Prazo
        {
            get { return dblPrazo; }
            set { dblPrazo = value; }
        }

        public double Equipe
        {
            get { return Convert.ToDouble(string.Format("{0:F3}", Esforco / Prazo)); }
        }
    }
}

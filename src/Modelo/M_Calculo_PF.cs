using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Calculo_PF : Ancestral
    {
        private double dblSPFNA;
        private double dblSNI;
        private double dblPF;

        public double SPFNA
        {
            get { return dblSPFNA; }
            set { dblSPFNA = value; }
        }

        public double SNI
        {
            get { return dblSNI; }
            set { dblSNI = value; }
        }

        public double PF
        {
            get { return dblPF; }
            set { dblPF = value; }
        }
    }
}

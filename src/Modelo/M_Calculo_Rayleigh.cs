using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Calculo_Rayleigh : Ancestral
    {
        private string strngFase;
        private double dblPercentual;

        public string Fase
        {
            get { return strngFase; }
            set { strngFase = value; }
        }

        public double Percentual
        {
            get { return dblPercentual; }
            set { dblPercentual = value; }
        }
    }
}

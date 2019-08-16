using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Projeto_Historico : Ancestral
    {
        private int intProjeto;
        private int intCodigo;
        private DateTime dtmData;
        private double dblTamanho_PF;

        public int Projeto
        {
            get { return intProjeto; }
            set { intProjeto = value; }
        }

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public DateTime Data
        {
            get { return dtmData; }
            set { dtmData = value; }
        }

        public double Tamanho_PF
        {
            get { return dblTamanho_PF; }
            set { dblTamanho_PF = value; }
        }

        public string Display
        {
            get { return Data.ToString() + " - " + Tamanho_PF.ToString(); }
        }
    }
}

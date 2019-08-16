using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Linguagem : Ancestral
    {
        private int intCodigo;
        private double dblEquivalente_PF;
        private string strngNome;

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public double Equivalente_PF
        {
            get { return dblEquivalente_PF; }
            set { dblEquivalente_PF = value; }
        }

        public string Nome
        {
            get { return strngNome; }
            set { strngNome = value; }
        }

        public M_Linguagem()
        {

        }
    }
}

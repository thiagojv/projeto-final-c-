using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Tipos_FundamentaisCOCOMO : Ancestral
    {
        private int intCodigo;
        private string strngNome;
        private double dblPrazoFatorMultiplicacao;
        private double dblPrazoExponencial;

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public string Nome
        {
            get { return strngNome; }
            set { strngNome = value; }
        }

        public double PrazoFatorMultiplicacao
        {
            get { return dblPrazoFatorMultiplicacao; }
            set { dblPrazoFatorMultiplicacao = value; }
        }

        public double PrazoExponencial
        {
            get { return dblPrazoExponencial; }
            set { dblPrazoExponencial = value; }
        }
    }
}

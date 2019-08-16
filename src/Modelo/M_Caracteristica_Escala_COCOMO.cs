using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Caracteristica_Escala_COCOMO : Ancestral
    {
        private int intCaracteristica;
        private int intEscala;
        private double dblFatorAjuste;
        private string strngClassificacao;

        public int Caracteristica
        {
            get { return intCaracteristica; }
            set { intCaracteristica = value; }
        }

        public int Escala
        {
            get { return intEscala; }
            set { intEscala = value; }
        }

        public double FatorAjuste
        {
            get { return dblFatorAjuste; }
            set { dblFatorAjuste = value; }
        }

        public string Classificacao
        {
            get { return strngClassificacao; }
            set { strngClassificacao = value; }
        }
    }
}

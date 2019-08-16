using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Projeto_Caracteristicas_COCOMO : Ancestral
    {
        private int intProjeto;
        private int intCOCOMO_Caracteristica;
        private int intCOCOMO_Escala;

        public int Projeto
        {
            get { return intProjeto; }
            set { intProjeto = value; }
        }

        public int COCOMO_Caracteristica
        {
            get { return intCOCOMO_Caracteristica; }
            set { intCOCOMO_Caracteristica = value; }
        }

        public int COCOMO_Escala
        {
            get { return intCOCOMO_Escala; }
            set { intCOCOMO_Escala = value; }
        }
    }
}

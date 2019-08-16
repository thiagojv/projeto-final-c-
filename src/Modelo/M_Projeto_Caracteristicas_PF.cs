using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Projeto_Caracteristicas_PF : Ancestral
    {
        private int intProjeto;
        private int intCaracteristica;
        private int intNivel_Influencia;

        public int Projeto
        {
            get { return intProjeto; }
            set { intProjeto = value; }
        }

        public int Caracteristica
        {
            get { return intCaracteristica; }
            set { intCaracteristica = value; }
        }

        public int Nivel_Influencia
        {
            get { return intNivel_Influencia; }
            set { intNivel_Influencia = value; }
        }
    }
}

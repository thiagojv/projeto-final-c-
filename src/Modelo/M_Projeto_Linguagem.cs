using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Projeto_Linguagem : Ancestral
    {
        private int intProjeto;
        private int intLinguagem;
        private string strngNomeLinguagem;

        public int Projeto
        {
            get { return intProjeto; }
            set { intProjeto = value; }
        }

        public int Linguagem
        {
            get { return intLinguagem; }
            set { intLinguagem = value; }
        }

        public string NomeLinguagem
        {
            get { return strngNomeLinguagem; }
            set { strngNomeLinguagem = value; }
        }
    }
}

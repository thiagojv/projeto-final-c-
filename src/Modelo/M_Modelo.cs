using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Modelo : Ancestral
    {
        private int intCodigo;
        private string strngNome;

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
    }
}

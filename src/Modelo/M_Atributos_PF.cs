using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Atributos_PF : Ancestral
    {
        private int intCodigo;
        private string strngNome;
        private string strngNomeParametro1;
        private string strngNomeParametro2;
        private string strngNomeParametro3;
        private string strngNomeParametro4;
        private bool blEstendido;

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

        public string NomeParametro1
        {
            get { return strngNomeParametro1; }
            set { strngNomeParametro1 = value; }
        }

        public string NomeParametro2
        {
            get { return strngNomeParametro2; }
            set { strngNomeParametro2 = value; }
        }

        public string NomeParametro3
        {
            get { return strngNomeParametro3; }
            set { strngNomeParametro3 = value; }
        }

        public string NomeParametro4
        {
            get { return strngNomeParametro4; }
            set { strngNomeParametro4 = value; }
        }

        public bool Estendido
        {
            get { return blEstendido; }
            set { blEstendido = value; }
        }
    }
}

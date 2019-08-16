using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Nivel_Influencia_PF : Ancestral
    {
        private int intCodigo;
        private string strngDescricao;
        private int intNota;

        public int Codigo
        {
            get { return intCodigo; }
            set { intCodigo = value; }
        }

        public string Descricao
        {
            get { return strngDescricao; }
            set { strngDescricao = value; }
        }

        public int Nota
        {
            get { return intNota; }
            set { intNota = value; }
        }
    }
}

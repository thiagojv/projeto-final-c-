using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Escalas_COCOMO : Ancestral
    {
        private int intCodigo;
        private string strngDescricao;

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
    }
}

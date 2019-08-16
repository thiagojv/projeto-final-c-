using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Tipo_Distribuicao : Ancestral
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

        public M_Tipo_Distribuicao()
        {

        }
    }
}

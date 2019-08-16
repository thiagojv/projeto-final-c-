using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class M_Caracteristicas_COCOMO : Ancestral
    {
        private int intCodigo;
        private string strngDescricao;
        private string strngSigla;
        private int intAncestral;

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

        public string Sigla
        {
            get { return strngSigla; }
            set { strngSigla = value; }
        }

        public int Ancestral
        {
            get { return intAncestral; }
            set { intAncestral = value; }
        }


    }
}

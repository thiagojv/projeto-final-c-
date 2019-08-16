using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Ancestral
    {
        private string strngMensagem;

        public string Mensagem
        {
            get { return strngMensagem; }
        }

        protected void SetMensagem(string Mensagem)
        {
            strngMensagem = Mensagem;
        }
    }
}

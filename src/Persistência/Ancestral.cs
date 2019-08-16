using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class Ancestral
    {
        private Conexao cnxConnection;
        protected string strngMensagem;

        public Ancestral()
        {
            cnxConnection = new Conexao();
        }

        protected Conexao Connection
        {
            get { return cnxConnection; }
            set { cnxConnection = value; }
        }

        public string Mensagem
        {
            get { return strngMensagem; }
        }

        protected void SetMensagem(string Value)
        {
            strngMensagem = Value;
        }
    }
}

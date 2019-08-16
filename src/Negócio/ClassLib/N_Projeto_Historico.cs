using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Persistencia;
using Modelo;

namespace Negocio
{
    public class N_Projeto_Historico : Ancestral
    {
        private string GerarStringInserir(M_Projeto_Historico Projeto_Historico)
        {
            return String.Format("INSERT INTO Projeto_Historico (Projeto, Data, Tamanho_PF) VALUES ({0}, '{1}', {2})", Projeto_Historico.Projeto, Biblioteca.FormatarData(Projeto_Historico.Data), Biblioteca.FormatarNumero(Projeto_Historico.Tamanho_PF));
        }

        private string GerarStringSelecionarProjeto(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Historico WHERE Projeto = {0}", Projeto);
        }

        public bool Inserir(int Projeto, DateTime Data, double Tamanho_PF)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Historico mprjthstrcModelo = new M_Projeto_Historico();

            try
            {
                mprjthstrcModelo.Projeto = Projeto;
                mprjthstrcModelo.Data = Data;
                mprjthstrcModelo.Tamanho_PF = Tamanho_PF;

                int intResultado = excExecucao.Executar(GerarStringInserir(mprjthstrcModelo));

                if (intResultado < 0)
                    SetMensagem(Mensagens.INSERCAO_ERRO + excExecucao.Mensagem);
                else if (intResultado == 0)
                    SetMensagem(Mensagens.INSERCAO_FALHA + excExecucao.Mensagem);
                else
                    SetMensagem(Mensagens.INSERCAO_SUCESSO);

                return intResultado > 0;
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.INSERCAO_ERRO + E.Message);
                return false;
            }
        }

        private List<M_Projeto_Historico> GerarLista(SqlDataReader Leitor)
        {
            List<M_Projeto_Historico> lstLista = new List<M_Projeto_Historico>();

            try
            {
                while (Leitor.Read())
                {
                    M_Projeto_Historico mprjthstrcModelo = new M_Projeto_Historico();

                    mprjthstrcModelo.Projeto = (int)Leitor["Projeto"];
                    mprjthstrcModelo.Codigo = (int)Leitor["Codigo"];
                    mprjthstrcModelo.Data = (DateTime)Leitor["Data"];
                    mprjthstrcModelo.Tamanho_PF = (double)Leitor["Tamanho_PF"];

                    lstLista.Add(mprjthstrcModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Projeto_Historico> Selecionar(int Projeto)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarProjeto(Projeto));

                if (sqldtrdrLeitor.HasRows)
                {
                    return GerarLista(sqldtrdrLeitor);
                }
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Histórico"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }
    }
}

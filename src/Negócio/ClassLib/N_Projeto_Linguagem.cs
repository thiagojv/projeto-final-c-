using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Persistencia;
using Modelo;

namespace Negocio
{
    public class N_Projeto_Linguagem : Ancestral
    {
        private string GerarStringInserir(M_Projeto_Linguagem Projeto_Linguagem)
        {
            return String.Format("INSERT INTO Projeto_Linguagem (Projeto, Linguagem) VALUES ({0}, {1})", Projeto_Linguagem.Projeto, Projeto_Linguagem.Linguagem);
        }

        private string GerarStringExcluir(M_Projeto_Linguagem Projeto_Linguagem)
        {
            return String.Format("DELETE FROM Projeto_Linguagem WHERE Projeto = {0} AND Linguagem = {1}", Projeto_Linguagem.Projeto, Projeto_Linguagem.Linguagem);
        }

        private string GerarStringSelecionarProjeto(int Projeto)
        {
            return string.Format("SELECT Projeto_Linguagem.Projeto, Projeto_Linguagem.Linguagem, Linguagem.Nome FROM Projeto_Linguagem INNER JOIN Linguagem ON Projeto_Linguagem.Linguagem = Linguagem.Codigo WHERE Projeto = {0}", Projeto);
        }

        private string GerarStringSelecionarProjetoDisponivel(int Projeto)
        {
            return string.Format("SELECT {0} AS Projeto, Codigo AS Linguagem, Nome FROM Linguagem WHERE (Codigo NOT IN (SELECT Linguagem FROM Projeto_Linguagem WHERE Projeto = {0})) ORDER BY Nome", Projeto);
        }

        public bool Inserir(int Projeto, int Linguagem)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Linguagem mprjtlngmModelo = new M_Projeto_Linguagem();

            try
            {
                mprjtlngmModelo.Projeto = Projeto;
                mprjtlngmModelo.Linguagem = Linguagem;

                int intResultado = excExecucao.Executar(GerarStringInserir(mprjtlngmModelo));

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

        public bool Excluir(int Projeto, int Linguagem)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Linguagem mprjtlngmModelo = new M_Projeto_Linguagem();

            try
            {
                mprjtlngmModelo.Projeto = Projeto;
                mprjtlngmModelo.Linguagem = Linguagem;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mprjtlngmModelo));

                if (intResultado < 0)
                    SetMensagem(Mensagens.EXCLUSAO_ERRO + excExecucao.Mensagem);
                else if (intResultado == 0)
                    SetMensagem(Mensagens.EXCLUSAO_FALHA + excExecucao.Mensagem);
                else
                    SetMensagem(Mensagens.EXCLUSAO_SUCESSO);

                return intResultado > 0;
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.EXCLUSAO_ERRO + E.Message);
                return false;
            }
        }

        private List<M_Projeto_Linguagem> GerarLista(SqlDataReader Leitor)
        {
            List<M_Projeto_Linguagem> lstLista = new List<M_Projeto_Linguagem>();

            try
            {
                while (Leitor.Read())
                {
                    M_Projeto_Linguagem mprjtlngmModelo = new M_Projeto_Linguagem();

                    mprjtlngmModelo.Projeto = (int)Leitor["Projeto"];
                    mprjtlngmModelo.Linguagem = (int)Leitor["Linguagem"];
                    mprjtlngmModelo.NomeLinguagem = (string)Leitor["Nome"];

                    lstLista.Add(mprjtlngmModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Projeto_Linguagem> Selecionar(int Projeto, bool Disponivel)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                if (Disponivel)
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarProjetoDisponivel(Projeto));
                else
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarProjeto(Projeto));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem("Não foi possível encontrar a Linguagem no projeto desejado");
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem("Erro ao processar a seleção. " + E.Message);
                return null;
            }
        }

        public virtual List<M_Projeto> CarregarProjetos()
        {
            return (new N_Projeto()).Carregar();
        }
    }
}

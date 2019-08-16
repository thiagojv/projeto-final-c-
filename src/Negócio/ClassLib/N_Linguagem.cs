using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Linguagem : Ancestral
    {
        private string GerarStringInserir(M_Linguagem Linguagem)
        {
            return String.Format("INSERT INTO Linguagem (Equivalente_PF, Nome) VALUES ({0}, '{1}')", Linguagem.Equivalente_PF, Linguagem.Nome);
        }

        private string GerarStringAlterar(M_Linguagem Linguagem)
        {
            return string.Format("UPDATE Linguagem SET Equivalente_PF = {0}, Nome = '{1}' WHERE Codigo = {2}", Linguagem.Equivalente_PF, Linguagem.Nome, Linguagem.Codigo);
        }

        private string GerarStringExcluir(M_Linguagem Linguagem)
        {
            return string.Format("DELETE FROM Linguagem WHERE Codigo = {0}", Linguagem.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Linguagem WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Nome)
        {
            return string.Format("SELECT * FROM Linguagem WHERE UPPER(Nome) = UPPER('{0}')", Nome);
        }

        private string GerarStringSelecionarDescricaoParcial(string Nome)
        {
            return string.Format("SELECT * FROM Linguagem WHERE UPPER(Nome) like UPPER('{0}%')", Nome);
        }

        public bool Inserir(int Equivalente_PF, string Nome)
        {
            Execucao excExecucao = new Execucao();
            M_Linguagem mlngmModelo = new M_Linguagem();

            try
            {
                mlngmModelo.Equivalente_PF = Equivalente_PF;
                mlngmModelo.Nome = Nome;

                int intResultado = excExecucao.Executar(GerarStringInserir(mlngmModelo));

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

        public bool Alterar(int Codigo, int Equivalente_PF, string Nome)
        {
            Execucao excExecucao = new Execucao();
            M_Linguagem mlngmModelo = new M_Linguagem();

            try
            {
                mlngmModelo.Codigo = Codigo;
                mlngmModelo.Equivalente_PF = Equivalente_PF;
                mlngmModelo.Nome = Nome;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mlngmModelo));

                if (intResultado < 0)
                    SetMensagem(Mensagens.ALTERACAO_ERRO + excExecucao.Mensagem);
                else if (intResultado == 0)
                    SetMensagem(Mensagens.ALTERACAO_FALHA + excExecucao.Mensagem);
                else
                    SetMensagem(Mensagens.ALTERACAO_SUCESSO);

                return intResultado > 0;
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.ALTERACAO_ERRO + E.Message);
                return false;
            }
        }

        public bool Excluir(int Codigo)
        {
            Execucao excExecucao = new Execucao();
            M_Linguagem mlngmModelo = new M_Linguagem();

            try
            {
                mlngmModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mlngmModelo));

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

        private List<M_Linguagem> GerarLista(SqlDataReader Leitor)
        {
            List<M_Linguagem> lstLista = new List<M_Linguagem>();

            try
            {
                while (Leitor.Read())
                {
                    M_Linguagem mlngmModelo = new M_Linguagem();

                    mlngmModelo.Codigo = (int)Leitor["Codigo"];
                    mlngmModelo.Equivalente_PF = (double)Leitor["Equivalente_PF"];
                    mlngmModelo.Nome = (string)Leitor["Nome"];

                    lstLista.Add(mlngmModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Linguagem> Selecionar(int Codigo)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarCodigo(Codigo));

                if (sqldtrdrLeitor.HasRows)
                {
                    return GerarLista(sqldtrdrLeitor);
                }
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Linguagem"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Linguagem> Selecionar(string Nome, bool Parcial)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                if (Parcial)
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarDescricaoParcial(Nome));
                else
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarDescricao(Nome));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem("Não foi possível encontrar o Tipo de Distribuição desejado");
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem("Erro ao processar a seleção. " + E.Message);
                return null;
            }
        }
    }
}

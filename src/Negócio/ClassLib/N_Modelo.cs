using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Modelo : Ancestral
    {
        private string GerarStringInserir(M_Modelo Modelo)
        {
            return String.Format("INSERT INTO Modelo (Descricao) VALUES ('{0}')", Modelo.Nome);
        }

        private string GerarStringAlterar(M_Modelo Modelo)
        {
            return string.Format("UPDATE Modelo SET Nome = '{0}' WHERE Codigo = {1}", Modelo.Nome, Modelo.Codigo);
        }

        private string GerarStringExcluir(M_Modelo Modelo)
        {
            return string.Format("DELETE FROM Modelo WHERE Codigo = {0}", Modelo.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Modelo WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Nome)
        {
            return string.Format("SELECT * FROM Modelo WHERE UPPER(Nome) = UPPER('{0}')", Nome);
        }

        private string GerarStringSelecionarDescricaoParcial(string Nome)
        {
            return string.Format("SELECT * FROM Modelo WHERE UPPER(Nome) like UPPER('{0}%')", Nome);
        }

        private string GerarStringCarregarModelos()
        {
            return "SELECT * FROM Modelo ORDER BY Nome";
        }

        public bool Inserir(string Nome)
        {
            Execucao excExecucao = new Execucao();
            M_Modelo mdlModelo = new M_Modelo();

            try
            {
                mdlModelo.Nome = Nome;

                int intResultado = excExecucao.Executar(GerarStringInserir(mdlModelo));

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

        public bool Alterar(int Codigo, string Nome)
        {
            Execucao excExecucao = new Execucao();
            M_Modelo mdlModelo = new M_Modelo();

            try
            {
                mdlModelo.Codigo = Codigo;
                mdlModelo.Nome = Nome;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mdlModelo));

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
            M_Modelo mdlModelo = new M_Modelo();

            try
            {
                mdlModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mdlModelo));

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

        private List<M_Modelo> GerarLista(SqlDataReader Leitor)
        {
            List<M_Modelo> lstLista = new List<M_Modelo>();

            try
            {
                while (Leitor.Read())
                {
                    M_Modelo mdlModelo = new M_Modelo();

                    mdlModelo.Codigo = (int)Leitor["Codigo"];
                    mdlModelo.Nome = (string)Leitor["Nome"];

                    lstLista.Add(mdlModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Modelo> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Modelo"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Modelo> Selecionar(string Nome, bool Parcial)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Modelo"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Modelo> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarModelos());

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                    return null;
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }
    }
}

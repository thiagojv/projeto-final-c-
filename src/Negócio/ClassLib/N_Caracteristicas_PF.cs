using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class N_Caracteristicas_PF : Ancestral
    {
        private string GerarStringInserir(M_Caracteristicas_PF Caracteristicas)
        {
            return String.Format("INSERT INTO PF_Caracteristicas (Descricao) VALUES ('{0}')", Caracteristicas.Descricao);
        }

        private string GerarStringAlterar(M_Caracteristicas_PF Caracteristicas)
        {
            return string.Format("UPDATE PF_Caracteristicas SET Descricao = '{0}' WHERE Codigo = {1}", Caracteristicas.Descricao, Caracteristicas.Codigo);
        }

        private string GerarStringExcluir(M_Caracteristicas_PF Caracteristicas)
        {
            return string.Format("DELETE FROM PF_Caracteristicas WHERE Codigo = {0}", Caracteristicas.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM PF_Caracteristicas WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Descricao)
        {
            return string.Format("SELECT * FROM PF_Caracteristicas WHERE UPPER(Descricao) = UPPER('{0}')", Descricao);
        }

        private string GerarStringSelecionarDescricaoParcial(string Descricao)
        {
            return string.Format("SELECT * FROM PF_Caracteristicas WHERE UPPER(Descricao) like UPPER('{0}%')", Descricao);
        }

        private string GerarStringCarregarCaracteristicas()
        {
            return string.Format("SELECT * FROM PF_Caracteristicas ORDER BY Descricao");
        }

        public bool Inserir(string Descricao)
        {
            Execucao excExecucao = new Execucao();
            M_Caracteristicas_PF mcrctrstcspfModelo = new M_Caracteristicas_PF();

            try
            {
                mcrctrstcspfModelo.Descricao = Descricao;

                int intResultado = excExecucao.Executar(GerarStringInserir(mcrctrstcspfModelo));

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

        public bool Alterar(int Codigo, string Descricao)
        {
            Execucao excExecucao = new Execucao();
            M_Caracteristicas_PF mcrctrstcspfModelo = new M_Caracteristicas_PF();

            try
            {
                mcrctrstcspfModelo.Codigo = Codigo;
                mcrctrstcspfModelo.Descricao = Descricao;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mcrctrstcspfModelo));

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
            M_Caracteristicas_PF mcrctrstcspfModelo = new M_Caracteristicas_PF();

            try
            {
                mcrctrstcspfModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mcrctrstcspfModelo));

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

        private List<M_Caracteristicas_PF> GerarLista(SqlDataReader Leitor)
        {
            List<M_Caracteristicas_PF> lstLista = new List<M_Caracteristicas_PF>();

            try
            {
                while (Leitor.Read())
                {
                    M_Caracteristicas_PF mcrctrstcspfModelo = new M_Caracteristicas_PF();

                    mcrctrstcspfModelo.Codigo = (int)Leitor["Codigo"];
                    mcrctrstcspfModelo.Descricao = (string)Leitor["Descricao"];

                    lstLista.Add(mcrctrstcspfModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Caracteristicas_PF> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Atributo"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Caracteristicas_PF> Selecionar(string Descricao, bool Parcial)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                if (Parcial)
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarDescricaoParcial(Descricao));
                else
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarDescricao(Descricao));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Atributo"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Caracteristicas_PF> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarCaracteristicas());

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

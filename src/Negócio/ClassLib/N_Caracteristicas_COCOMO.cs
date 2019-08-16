using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Persistencia;
using Modelo;

namespace Negocio
{
    public class N_Caracteristicas_COCOMO : Ancestral
    {
        private string GerarStringInserir(M_Caracteristicas_COCOMO Caracteristicas)
        {
            return String.Format("INSERT INTO COCOMO_Caracteristicas (Descricao, Sigla, Ancestral) VALUES ('{0}', '{1}', {2})", Caracteristicas.Descricao, Caracteristicas.Sigla, Caracteristicas.Ancestral);
        }

        private string GerarStringAlterar(M_Caracteristicas_COCOMO Caracteristicas)
        {
            return string.Format("UPDATE COCOMO_Caracteristicas SET Descricao = '{0}', Sigla = '{1}', Ancestral = {2} WHERE Codigo = {3}", Caracteristicas.Descricao, Caracteristicas.Sigla, Caracteristicas.Ancestral, Caracteristicas.Codigo);
        }

        private string GerarStringExcluir(M_Caracteristicas_COCOMO Caracteristicas)
        {
            return string.Format("DELETE FROM COCOMO_Caracteristicas WHERE Codigo = {0}", Caracteristicas.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM COCOMO_Caracteristicas WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Descricao)
        {
            return string.Format("SELECT * FROM COCOMO_Caracteristicas WHERE UPPER(Descricao) = UPPER('{0}')", Descricao);
        }

        private string GerarStringSelecionarDescricaoParcial(string Descricao)
        {
            return string.Format("SELECT * FROM COCOMO_Caracteristicas WHERE UPPER(Descricao) like UPPER('{0}%')", Descricao);
        }

        private string GerarStringCarregarCaracteristicas()
        {
            return string.Format("SELECT * FROM COCOMO_Caracteristicas ORDER BY Descricao");
        }

        public bool Inserir(string Descricao, string Sigla, int Ancestral)
        {
            Execucao excExecucao = new Execucao();
            M_Caracteristicas_COCOMO mcrctrstcscmModelo = new M_Caracteristicas_COCOMO();

            try
            {
                mcrctrstcscmModelo.Descricao = Descricao;
                mcrctrstcscmModelo.Sigla = Sigla;
                mcrctrstcscmModelo.Ancestral = Ancestral;

                int intResultado = excExecucao.Executar(GerarStringInserir(mcrctrstcscmModelo));

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

        public bool Alterar(int Codigo, string Descricao, string Sigla, int Ancestral)
        {
            Execucao excExecucao = new Execucao();
            M_Caracteristicas_COCOMO mcrctrstcscmModelo = new M_Caracteristicas_COCOMO();

            try
            {
                mcrctrstcscmModelo.Codigo = Codigo;
                mcrctrstcscmModelo.Descricao = Descricao;
                mcrctrstcscmModelo.Sigla = Sigla;
                mcrctrstcscmModelo.Ancestral = Ancestral;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mcrctrstcscmModelo));

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
            M_Caracteristicas_COCOMO mcrctrstcscmModelo = new M_Caracteristicas_COCOMO();

            try
            {
                mcrctrstcscmModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mcrctrstcscmModelo));

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

        private List<M_Caracteristicas_COCOMO> GerarLista(SqlDataReader Leitor)
        {
            List<M_Caracteristicas_COCOMO> lstLista = new List<M_Caracteristicas_COCOMO>();

            try
            {
                while (Leitor.Read())
                {
                    M_Caracteristicas_COCOMO mcrctrstcscmModelo = new M_Caracteristicas_COCOMO();

                    mcrctrstcscmModelo.Codigo = (int)Leitor["Codigo"];
                    mcrctrstcscmModelo.Descricao = (string)Leitor["Descricao"];
                    mcrctrstcscmModelo.Sigla = (string)Leitor["Sigla"];
                    if (Leitor["Ancestral"] == DBNull.Value)
                        mcrctrstcscmModelo.Ancestral = 0;
                    else
                        mcrctrstcscmModelo.Ancestral = (int)Leitor["Ancestral"];

                    lstLista.Add(mcrctrstcscmModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Caracteristicas_COCOMO> Selecionar(int Codigo)
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

        public List<M_Caracteristicas_COCOMO> Selecionar(string Descricao, bool Parcial)
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

        public virtual List<M_Caracteristicas_COCOMO> Carregar()
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

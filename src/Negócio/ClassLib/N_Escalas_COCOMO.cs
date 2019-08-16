using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Escalas_COCOMO : Ancestral
    {
        private string GerarStringInserir(M_Escalas_COCOMO EscalasCOCOMO)
        {
            return String.Format("INSERT INTO COCOMO_Escala (Descricao) VALUES ('{0}')", EscalasCOCOMO.Descricao);
        }

        private string GerarStringAlterar(M_Escalas_COCOMO EscalasCOCOMO)
        {
            return string.Format("UPDATE COCOMO_Escala SET Descricao = '{0}' WHERE Codigo = {1}", EscalasCOCOMO.Descricao, EscalasCOCOMO.Codigo);
        }

        private string GerarStringExcluir(M_Escalas_COCOMO EscalasCOCOMO)
        {
            return string.Format("DELETE FROM COCOMO_Escala WHERE Codigo = {0}", EscalasCOCOMO.Descricao);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM COCOMO_Escala WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Descricao)
        {
            return string.Format("SELECT * FROM COCOMO_Escala WHERE UPPER(Descricao) = UPPER('{0}')", Descricao);
        }

        private string GerarStringSelecionarDescricaoParcial(string Descricao)
        {
            return string.Format("SELECT * FROM COCOMO_Escala WHERE UPPER(Descricao) like UPPER('{0}%')", Descricao);
        }

        private string GerarStringCarregarEscalas()
        {
            return string.Format("SELECT * FROM COCOMO_Escala ORDER BY Descricao");
        }

        public bool Inserir(string Descricao)
        {
            Execucao excExecucao = new Execucao();
            M_Escalas_COCOMO msclscmModelo = new M_Escalas_COCOMO();

            try
            {
                msclscmModelo.Descricao = Descricao;

                int intResultado = excExecucao.Executar(GerarStringInserir(msclscmModelo));

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
            M_Escalas_COCOMO msclscmModelo = new M_Escalas_COCOMO();

            try
            {
                msclscmModelo.Codigo = Codigo;
                msclscmModelo.Descricao = Descricao;

                int intResultado = excExecucao.Executar(GerarStringAlterar(msclscmModelo));

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
            M_Escalas_COCOMO msclscmModelo = new M_Escalas_COCOMO();

            try
            {
                msclscmModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(msclscmModelo));

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

        private List<M_Escalas_COCOMO> GerarLista(SqlDataReader Leitor)
        {
            List<M_Escalas_COCOMO> lstLista = new List<M_Escalas_COCOMO>();

            try
            {
                while (Leitor.Read())
                {
                    M_Escalas_COCOMO msclscmModelo = new M_Escalas_COCOMO();

                    msclscmModelo.Codigo = (int)Leitor["Codigo"];
                    msclscmModelo.Descricao = (string)Leitor["Descricao"];

                    lstLista.Add(msclscmModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Escalas_COCOMO> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tipo de Distribuição"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Escalas_COCOMO> Selecionar(string Descricao, bool Parcial)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tipo de Distribuição"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Escalas_COCOMO> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarEscalas());

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

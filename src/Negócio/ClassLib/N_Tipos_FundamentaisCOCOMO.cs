using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Tipos_FundamentaisCOCOMO : Ancestral
    {
        private string GerarStringInserir(M_Tipos_FundamentaisCOCOMO Tipos_Fundamentais)
        {
            return String.Format("INSERT INTO Tipo_Fundamental (Nome, Prazo_Fator_Multiplicacao, Prazo_Exponencial) VALUES ('{0}', {1}, {2})", Tipos_Fundamentais.Nome, Tipos_Fundamentais.PrazoFatorMultiplicacao, Tipos_Fundamentais.PrazoExponencial);
        }

        private string GerarStringAlterar(M_Tipos_FundamentaisCOCOMO Tipos_Fundamentais)
        {
            return string.Format("UPDATE Tipo_Fundamental SET Nome = '{0}', Prazo_Fator_Multiplicacao = {1}, Prazo_Exponencial = {2} WHERE Codigo = {3}", Tipos_Fundamentais.Nome, Tipos_Fundamentais.PrazoFatorMultiplicacao, Tipos_Fundamentais.PrazoExponencial, Tipos_Fundamentais.Codigo);
        }

        private string GerarStringExcluir(M_Tipos_FundamentaisCOCOMO Tipos_Fundamentais)
        {
            return string.Format("DELETE FROM Tipo_Fundamental WHERE Codigo = {0}", Tipos_Fundamentais.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Tipo_Fundamental WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Nome)
        {
            return string.Format("SELECT * FROM Tipo_Fundamental WHERE UPPER(Nome) = UPPER('{0}')", Nome);
        }

        private string GerarStringSelecionarDescricaoParcial(string Nome)
        {
            return string.Format("SELECT * FROM Tipo_Fundamental WHERE UPPER(Nome) like UPPER('{0}%')", Nome);
        }

        private string GerarStringCarregarTiposFundamentais()
        {
            return "SELECT * FROM Tipo_Fundamental ORDER BY Nome";
        }

        public bool Inserir(string Nome, double Prazo_Fator_Multiplicacao, double Prazo_Exponencial)
        {
            Execucao excExecucao = new Execucao();
            M_Tipos_FundamentaisCOCOMO mtpsfndmntsModelo = new M_Tipos_FundamentaisCOCOMO();

            try
            {
                mtpsfndmntsModelo.Nome = Nome;
                mtpsfndmntsModelo.PrazoFatorMultiplicacao = Prazo_Fator_Multiplicacao;
                mtpsfndmntsModelo.PrazoExponencial = Prazo_Exponencial;

                int intResultado = excExecucao.Executar(GerarStringInserir(mtpsfndmntsModelo));

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

        public bool Alterar(int Codigo, string Nome, double Prazo_Fator_Multiplicacao, double Prazo_Exponencial)
        {
            Execucao excExecucao = new Execucao();
            M_Tipos_FundamentaisCOCOMO mtpsfndmntsModelo = new M_Tipos_FundamentaisCOCOMO();

            try
            {
                mtpsfndmntsModelo.Codigo = Codigo;
                mtpsfndmntsModelo.Nome = Nome;
                mtpsfndmntsModelo.PrazoFatorMultiplicacao = Prazo_Fator_Multiplicacao;
                mtpsfndmntsModelo.PrazoExponencial = Prazo_Exponencial;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mtpsfndmntsModelo));

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
            M_Tipos_FundamentaisCOCOMO mtpsfndmntsModelo = new M_Tipos_FundamentaisCOCOMO();

            try
            {
                mtpsfndmntsModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mtpsfndmntsModelo));

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

        private List<M_Tipos_FundamentaisCOCOMO> GerarLista(SqlDataReader Leitor)
        {
            List<M_Tipos_FundamentaisCOCOMO> lstLista = new List<M_Tipos_FundamentaisCOCOMO>();

            try
            {
                while (Leitor.Read())
                {
                    M_Tipos_FundamentaisCOCOMO mtpsfndmntsModelo = new M_Tipos_FundamentaisCOCOMO();

                    mtpsfndmntsModelo.Codigo = (int)Leitor["Codigo"];
                    mtpsfndmntsModelo.Nome = (string)Leitor["Nome"];
                    mtpsfndmntsModelo.PrazoFatorMultiplicacao = (double)Leitor["Prazo_Fator_Multiplicacao"];
                    mtpsfndmntsModelo.PrazoExponencial = (double)Leitor["Prazo_Exponencial"];


                    lstLista.Add(mtpsfndmntsModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Tipos_FundamentaisCOCOMO> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tipo Fundamental"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Tipos_FundamentaisCOCOMO> Selecionar(string Nome, bool Parcial)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tipo Fundamental"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Tipos_FundamentaisCOCOMO> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarTiposFundamentais());

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

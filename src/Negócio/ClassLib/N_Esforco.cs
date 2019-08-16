using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class N_Esforco : Ancestral
    {
        private string GerarStringInserir(M_Esforco Esforco)
        {
            return String.Format("INSERT INTO Esforco_Modelo_Tipo (Modelo, Tipo_Fundamental, Esforco_Fator_Multiplicacao, Esforco_Exponencial)" +
                                    "VALUES ({0}, {1}, {2}, {3})", Esforco.Modelo, Esforco.TipoFundamental, Esforco.EsforcoFatorMultiplicacao, Esforco.EsforcoExponencial);
        }

        private string GerarStringAlterar(M_Esforco Esforco)
        {
            return String.Format("UPDATE Esforco_Modelo_Tipo SET Esforco_Fator_Multiplicacao = {0}, Esforco_Exponencial = {1}" +
                                    "WHERE Modelo = {2}, Tipo_Fundamental = {3}", Esforco.EsforcoFatorMultiplicacao, Esforco.EsforcoExponencial, Esforco.Modelo, Esforco.TipoFundamental);
        }

        private string GerarStringExcluir(M_Esforco Esforco)
        {
            return String.Format("DELETE FROM Esforco_Modelo_Tipo WHERE Modelo = {0}, Tipo_Fundamental = {1}", Esforco.Modelo, Esforco.TipoFundamental);
        }

        private string GerarStringSelecionarTipo(int Tipo_Fundamental)
        {
            return string.Format("SELECT * FROM Esforco_Modelo_Tipo WHERE Tipo_Fundamental = {0}", Tipo_Fundamental);
        }

        public bool Inserir(int Modelo, int Tipo_Fundamental, double Esforco_Fator_Multiplicacao, double Esforco_Exponencial)
        {
            Execucao excExecucao = new Execucao();
            M_Esforco msfrcModelo = new M_Esforco();

            try
            {
                msfrcModelo.Modelo = Modelo;
                msfrcModelo.TipoFundamental = Tipo_Fundamental;
                msfrcModelo.EsforcoFatorMultiplicacao = Esforco_Fator_Multiplicacao;
                msfrcModelo.EsforcoExponencial = Esforco_Exponencial;

                int intResultado = excExecucao.Executar(GerarStringInserir(msfrcModelo));

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

        public bool Alterar(int Modelo, int Tipo_Fundamental, double Esforco_Fator_Multiplicacao, double Esforco_Exponencial)
        {
            Execucao excExecucao = new Execucao();
            M_Esforco msfrcModelo = new M_Esforco();

            try
            {
                msfrcModelo.Modelo = Modelo;
                msfrcModelo.TipoFundamental = Tipo_Fundamental;
                msfrcModelo.EsforcoFatorMultiplicacao = Esforco_Fator_Multiplicacao;
                msfrcModelo.EsforcoExponencial = Esforco_Exponencial;

                int intResultado = excExecucao.Executar(GerarStringAlterar(msfrcModelo));

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

        public bool Excluir(int Modelo, int Tipo_Fundamental)
        {
            Execucao excExecucao = new Execucao();
            M_Esforco msfrcModelo = new M_Esforco();

            try
            {
                msfrcModelo.Modelo = Modelo;
                msfrcModelo.TipoFundamental = Tipo_Fundamental;

                int intResultado = excExecucao.Executar(GerarStringExcluir(msfrcModelo));

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

        private List<M_Esforco> GerarLista(SqlDataReader Leitor)
        {
            List<M_Esforco> lstLista = new List<M_Esforco>();

            try
            {
                while (Leitor.Read())
                {
                    M_Esforco msfrcModelo = new M_Esforco();

                    msfrcModelo.Modelo = (int)Leitor["Modelo"];
                    msfrcModelo.TipoFundamental = (int)Leitor["Tipo_Fundamental"];
                    msfrcModelo.EsforcoFatorMultiplicacao = (double)Leitor["Esforco_Fator_Multiplicacao"];
                    msfrcModelo.EsforcoExponencial = (double)Leitor["Esforco_Exponencial"];

                    lstLista.Add(msfrcModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Esforco> Selecionar(int Tipo_Fundamental)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarTipo(Tipo_Fundamental));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Esforço"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Tipos_FundamentaisCOCOMO> CarregarTiposFundamentais()
        {
            return (new N_Tipos_FundamentaisCOCOMO()).Carregar();
        }

        public virtual List<M_Modelo> CarregarModelos()
        {
            return (new N_Modelo()).Carregar();
        }
    }
}

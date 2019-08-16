using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Persistencia;
using Modelo;

namespace Negocio
{
    public class N_Projeto_Caracteristicas_COCOMO : Ancestral
    {
        private string GerarStringInserir(M_Projeto_Caracteristicas_COCOMO Projeto_Caracteristica_COCOMO)
        {
            return String.Format("INSERT INTO Projeto_Caracteristica_COCOMO (Projeto, COCOMO_Caracteristica, COCOMO_Escala) VALUES ({0}, {1}, {2})", Projeto_Caracteristica_COCOMO.Projeto, Projeto_Caracteristica_COCOMO.COCOMO_Caracteristica, Projeto_Caracteristica_COCOMO.COCOMO_Escala);
        }

        private string GerarStringAlterar(M_Projeto_Caracteristicas_COCOMO Projeto_Caracteristica_COCOMO)
        {
            return String.Format("UPDATE Projeto_Caracteristica_COCOMO SET COCOMO_Escala = {0} WHERE Projeto = {1} AND COCOMO_Caracteristica = {2}", Projeto_Caracteristica_COCOMO.COCOMO_Escala, Projeto_Caracteristica_COCOMO.Projeto, Projeto_Caracteristica_COCOMO.COCOMO_Caracteristica);
        }

        private string GerarStringExcluir(M_Projeto_Caracteristicas_COCOMO Projeto_Caracteristica_COCOMO)
        {
            return String.Format("DELETE FROM Projeto_Caracteristica_COCOMO WHERE Projeto = {0} AND COCOMO_Caracteristica = {1}", Projeto_Caracteristica_COCOMO.Projeto, Projeto_Caracteristica_COCOMO.COCOMO_Caracteristica);
        }

        private string GerarStringSelecionarProjeto(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Caracteristica_COCOMO WHERE Projeto = {0}", Projeto);
        }

        private string GerarStringSelecionarCodigo(int Projeto, int Caracteristica)
        {
            return string.Format("SELECT * FROM Projeto_Caracteristica_COCOMO WHERE Projeto = {0} AND COCOMO_Caracteristica = {1}", Projeto, Caracteristica);
        }

        public bool Inserir(int Projeto, int Caracteristica, int Escala)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Caracteristicas_COCOMO mprjtcrctrstcscmModelo = new M_Projeto_Caracteristicas_COCOMO();

            try
            {
                mprjtcrctrstcscmModelo.Projeto = Projeto;
                mprjtcrctrstcscmModelo.COCOMO_Caracteristica = Caracteristica;
                mprjtcrctrstcscmModelo.COCOMO_Escala = Escala;

                int intResultado = excExecucao.Executar(GerarStringInserir(mprjtcrctrstcscmModelo));

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

        public bool Alterar(int Projeto, int Caracteristica, int Nivel_Influencia)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Caracteristicas_COCOMO mprjtcrctrstcscmModelo = new M_Projeto_Caracteristicas_COCOMO();

            try
            {
                mprjtcrctrstcscmModelo.Projeto = Projeto;
                mprjtcrctrstcscmModelo.COCOMO_Caracteristica = Caracteristica;
                mprjtcrctrstcscmModelo.COCOMO_Escala = Nivel_Influencia;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mprjtcrctrstcscmModelo));

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

        public bool Excluir(int Projeto, int Caracteristica)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Caracteristicas_COCOMO mprjtcrctrstcscmModelo = new M_Projeto_Caracteristicas_COCOMO();

            try
            {
                mprjtcrctrstcscmModelo.Projeto = Projeto;
                mprjtcrctrstcscmModelo.COCOMO_Caracteristica = Caracteristica;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mprjtcrctrstcscmModelo));

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

        private List<M_Projeto_Caracteristicas_COCOMO> GerarLista(SqlDataReader Leitor)
        {
            List<M_Projeto_Caracteristicas_COCOMO> lstLista = new List<M_Projeto_Caracteristicas_COCOMO>();

            try
            {
                while (Leitor.Read())
                {
                    M_Projeto_Caracteristicas_COCOMO mprjtcrctrstcscmModelo = new M_Projeto_Caracteristicas_COCOMO();

                    mprjtcrctrstcscmModelo.Projeto = (int)Leitor["Projeto"];
                    mprjtcrctrstcscmModelo.COCOMO_Caracteristica = (int)Leitor["COCOMO_Caracteristica"];
                    mprjtcrctrstcscmModelo.COCOMO_Escala = (int)Leitor["COCOMO_Escala"];

                    lstLista.Add(mprjtcrctrstcscmModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Projeto_Caracteristicas_COCOMO> Selecionar(int Projeto)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Característica de COCOMO"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Projeto_Caracteristicas_COCOMO> Selecionar(int Projeto, int Caracteristica)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarCodigo(Projeto, Caracteristica));

                if (sqldtrdrLeitor.HasRows)
                {
                    return GerarLista(sqldtrdrLeitor);
                }
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Característica do COCOMO"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Caracteristicas_COCOMO> CarregarCaracteristicas()
        {
            return (new N_Caracteristicas_COCOMO()).Carregar();
        }

        public virtual List<M_Escalas_COCOMO> CarregarEscalas()
        {
            return (new N_Escalas_COCOMO()).Carregar();
        }
    }
}

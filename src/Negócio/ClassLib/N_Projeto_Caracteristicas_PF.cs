using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Projeto_Caracteristicas_PF : Ancestral
    {
        private string GerarStringInserir(M_Projeto_Caracteristicas_PF Projeto_Caracteristica_PF)
        {
            return String.Format("INSERT INTO Projeto_Caracteristicas_PF (Projeto, Caracteristica, Nivel_Influencia) VALUES ({0}, {1}, {2})", Projeto_Caracteristica_PF.Projeto, Projeto_Caracteristica_PF.Caracteristica, Projeto_Caracteristica_PF.Nivel_Influencia);
        }

        private string GerarStringAlterar(M_Projeto_Caracteristicas_PF Projeto_Caracteristica_PF)
        {
            return String.Format("UPDATE Projeto_Caracteristicas_PF SET Nivel_Influencia = {0} WHERE Projeto = {1} AND Caracteristica = {2}", Projeto_Caracteristica_PF.Nivel_Influencia, Projeto_Caracteristica_PF.Projeto, Projeto_Caracteristica_PF.Caracteristica);
        }

        private string GerarStringExcluir(M_Projeto_Caracteristicas_PF Projeto_Caracteristica_PF)
        {
            return String.Format("DELETE FROM Projeto_Caracteristicas_PF WHERE Projeto = {0} AND Caracteristica = {1}", Projeto_Caracteristica_PF.Projeto, Projeto_Caracteristica_PF.Caracteristica);
        }

        private string GerarStringSelecionarProjeto(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Caracteristicas_PF WHERE Projeto = {0}", Projeto);
        }

        private string GerarStringSelecionarCodigo(int Projeto, int Caracteristica)
        {
            return string.Format("SELECT * FROM Projeto_Caracteristicas_PF WHERE Projeto = {0} AND Caracteristica = {1}", Projeto, Caracteristica);
        }

        public bool Inserir(int Projeto, int Caracteristica, int Nivel_Influencia)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Caracteristicas_PF mprjtpfcrctrstcsModelo = new M_Projeto_Caracteristicas_PF();

            try
            {
                mprjtpfcrctrstcsModelo.Projeto = Projeto;
                mprjtpfcrctrstcsModelo.Caracteristica = Caracteristica;
                mprjtpfcrctrstcsModelo.Nivel_Influencia = Nivel_Influencia;

                int intResultado = excExecucao.Executar(GerarStringInserir(mprjtpfcrctrstcsModelo));

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
            M_Projeto_Caracteristicas_PF mprjtpfcrctrstcsModelo = new M_Projeto_Caracteristicas_PF();

            try
            {
                mprjtpfcrctrstcsModelo.Projeto = Projeto;
                mprjtpfcrctrstcsModelo.Caracteristica = Caracteristica;
                mprjtpfcrctrstcsModelo.Nivel_Influencia = Nivel_Influencia;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mprjtpfcrctrstcsModelo));

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
            M_Projeto_Caracteristicas_PF mprjtpfcrctrstcsModelo = new M_Projeto_Caracteristicas_PF();

            try
            {
                mprjtpfcrctrstcsModelo.Projeto = Projeto;
                mprjtpfcrctrstcsModelo.Caracteristica = Caracteristica;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mprjtpfcrctrstcsModelo));

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

        private List<M_Projeto_Caracteristicas_PF> GerarLista(SqlDataReader Leitor)
        {
            List<M_Projeto_Caracteristicas_PF> lstLista = new List<M_Projeto_Caracteristicas_PF>();

            try
            {
                while (Leitor.Read())
                {
                    M_Projeto_Caracteristicas_PF mprjtpfcrctrstcsModelo = new M_Projeto_Caracteristicas_PF();

                    mprjtpfcrctrstcsModelo.Projeto = (int)Leitor["Projeto"];
                    mprjtpfcrctrstcsModelo.Caracteristica = (int)Leitor["Caracteristica"];
                    mprjtpfcrctrstcsModelo.Nivel_Influencia = (int)Leitor["Nivel_Influencia"];

                    lstLista.Add(mprjtpfcrctrstcsModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Projeto_Caracteristicas_PF> Selecionar(int Projeto)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Característica de PF"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Projeto_Caracteristicas_PF> Selecionar(int Projeto, int Caracteristica)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Característica de PF"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Caracteristicas_PF> CarregarCaracteristicas()
        {
            return (new N_Caracteristicas_PF()).Carregar();
        }

        public virtual List<M_Nivel_Influencia_PF> CarregarNiveisInfluencia()
        {
            return (new N_Nivel_Influencia_PF()).Carregar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Projeto_Atributo : Ancestral
    {
        private string GerarStringInserir(M_Projeto_Atributo Projeto_Atributo)
        {
            return String.Format("INSERT Projeto_Atributo (Projeto, Atributo, Descricao, Complexidade, Quantidade_Parametro_1, Quantidade_Parametro_2, Quantidade_Parametro_3, Quantidade_Parametro_4) VALUES ({0}, {1}, '{2}', {3}, {4}, {5}, {6}, {7})", Projeto_Atributo.Projeto, Projeto_Atributo.Atributo, Projeto_Atributo.Descricao, Projeto_Atributo.Complexidade, Projeto_Atributo.QuantidadeParametro1, Projeto_Atributo.QuantidadeParametro2, Projeto_Atributo.QuantidadeParametro3, Projeto_Atributo.QuantidadeParametro4);
        }

        private string GerarStringAlterar(M_Projeto_Atributo Projeto_Atributo)
        {
            return String.Format("UPDATE Projeto_Atributo SET Atributo = {0}, Descricao = '{1}', Complexidade = {2}, Quantidade_Parametro_1 = {3}, Quantidade_Parametro_2 = {4}, Quantidade_Parametro_3 = {5}, Quantidade_Parametro_4 = {6} WHERE Projeto = {7} AND ID = {8}", Projeto_Atributo.Atributo, Projeto_Atributo.Descricao, Projeto_Atributo.Complexidade, Projeto_Atributo.QuantidadeParametro1, Projeto_Atributo.QuantidadeParametro2, Projeto_Atributo.QuantidadeParametro3, Projeto_Atributo.QuantidadeParametro4, Projeto_Atributo.Projeto, Projeto_Atributo.Codigo);
        }

        private string GerarStringExcluir(M_Projeto_Atributo Projeto_Atributo)
        {
            return String.Format("DELETE FROM Projeto_Atributo WHERE Projeto = {0} AND ID = {1}", Projeto_Atributo.Projeto, Projeto_Atributo.Codigo);
        }

        private string GerarStringSelecionarProjeto(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Atributo WHERE Projeto = {0}", Projeto);
        }

        public bool Inserir(int Projeto, int Atributo, string Descricao, int Complexidade, double QuantidadeParametro1, double QuantidadeParametro2, double QuantidadeParametro3, double QuantidadeParametro4)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Atributo mprjtrbtModelo = new M_Projeto_Atributo();

            try
            {
                mprjtrbtModelo.Projeto = Projeto;
                mprjtrbtModelo.Atributo = Atributo;
                mprjtrbtModelo.Descricao = Descricao;
                mprjtrbtModelo.Complexidade = Complexidade;
                mprjtrbtModelo.QuantidadeParametro1 = QuantidadeParametro1;
                mprjtrbtModelo.QuantidadeParametro2 = QuantidadeParametro2;
                mprjtrbtModelo.QuantidadeParametro3 = QuantidadeParametro3;
                mprjtrbtModelo.QuantidadeParametro4 = QuantidadeParametro4;

                int intResultado = excExecucao.Executar(GerarStringInserir(mprjtrbtModelo));

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

        public bool Alterar(int Projeto, int ID, int Atributo, string Descricao, int Complexidade, double QuantidadeParametro1, double QuantidadeParametro2, double QuantidadeParametro3, double QuantidadeParametro4)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Atributo mprjtrbtModelo = new M_Projeto_Atributo();

            try
            {
                mprjtrbtModelo.Projeto = Projeto;
                mprjtrbtModelo.Codigo = ID;
                mprjtrbtModelo.Atributo = Atributo;
                mprjtrbtModelo.Descricao = Descricao;
                mprjtrbtModelo.Complexidade = Complexidade;
                mprjtrbtModelo.QuantidadeParametro1 = QuantidadeParametro1;
                mprjtrbtModelo.QuantidadeParametro2 = QuantidadeParametro2;
                mprjtrbtModelo.QuantidadeParametro3 = QuantidadeParametro3;
                mprjtrbtModelo.QuantidadeParametro4 = QuantidadeParametro4;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mprjtrbtModelo));

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

        public bool Excluir(int Projeto, int Codigo)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto_Atributo mprjtrbtModelo = new M_Projeto_Atributo();

            try
            {
                mprjtrbtModelo.Projeto = Projeto;
                mprjtrbtModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mprjtrbtModelo));

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

        private List<M_Projeto_Atributo> GerarLista(SqlDataReader Leitor)
        {
            List<M_Projeto_Atributo> lstLista = new List<M_Projeto_Atributo>();

            try
            {
                while (Leitor.Read())
                {
                    M_Projeto_Atributo mprjtrbtModelo = new M_Projeto_Atributo();

                    mprjtrbtModelo.Projeto = (int)Leitor["Projeto"];
                    mprjtrbtModelo.Codigo = (int)Leitor["ID"];
                    mprjtrbtModelo.Atributo = (int)Leitor["Atributo"];
                    mprjtrbtModelo.Descricao = (string)Leitor["Descricao"];
                    mprjtrbtModelo.Complexidade = (int)Leitor["Complexidade"];
                    mprjtrbtModelo.QuantidadeParametro1 = (double)Leitor["Quantidade_Parametro_1"];
                    mprjtrbtModelo.QuantidadeParametro2 = (double)Leitor["Quantidade_Parametro_2"];

                    if (Leitor["Quantidade_Parametro_3"] != DBNull.Value)
                        mprjtrbtModelo.QuantidadeParametro3 = (double)Leitor["Quantidade_Parametro_3"];

                    if (Leitor["Quantidade_Parametro_4"] != DBNull.Value)
                        mprjtrbtModelo.QuantidadeParametro4 = (double)Leitor["Quantidade_Parametro_4"];

                    lstLista.Add(mprjtrbtModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Projeto_Atributo> Selecionar(int Projeto)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarProjeto(Projeto));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem("Não foi possível encontrar o Atributo de projeto desejado");
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem("Erro ao processar a seleção. " + E.Message);
                return null;
            }
        }

        public virtual List<M_Atributos_PF> CarregarAtributos()
        {
            return (new N_Atributos_PF()).Carregar();
        }

        public int SelecionarComplexidade(int Atributo, double QuantidadeParametro1, double QuantidadeParametro2, double QuantidadeParametro3, double QuantidadeParametro4, bool Estendido)
        {
            return (new N_Complexidades_PF()).SelecionarCodigo(Atributo, QuantidadeParametro1, QuantidadeParametro2, QuantidadeParametro3, QuantidadeParametro4, Estendido);
        }
    }
}

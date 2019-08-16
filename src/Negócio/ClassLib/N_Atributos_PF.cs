using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class N_Atributos_PF : Ancestral
    {
        private string GerarStringInserir(M_Atributos_PF Atributos)
        {
            return String.Format("INSERT INTO Atributo (Nome, Nome_Parametro_1, Nome_Parametro_2, Nome_Parametro_3, Nome_Parametro_4, Extendido) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5})", Atributos.Nome, Atributos.NomeParametro1, Atributos.NomeParametro2, Atributos.NomeParametro3, Atributos.NomeParametro4, Atributos.Estendido);
        }

        private string GerarStringAlterar(M_Atributos_PF Atributos)
        {
            return string.Format("UPDATE Atributo SET Nome = '{0}', Nome_Parametro_1 = '{1}', Nome_Parametro_2 = '{2}', Nome_Parametro_3 = '{3}', Nome_Parametro_4 = '{4}', Extendido = {5} WHERE Codigo = {6}", Atributos.Nome, Atributos.NomeParametro1, Atributos.NomeParametro2, Atributos.NomeParametro3, Atributos.NomeParametro4, Atributos.Estendido, Atributos.Codigo);
        }

        private string GerarStringExcluir(M_Atributos_PF Atributos)
        {
            return string.Format("DELETE FROM Atributo WHERE Codigo = {0}", Atributos.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Atributo WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Nome)
        {
            return string.Format("SELECT * FROM Atributo WHERE UPPER(Nome) = UPPER('{0}')", Nome);
        }

        private string GerarStringSelecionarDescricaoParcial(string Nome)
        {
            return string.Format("SELECT * FROM Atributo WHERE UPPER(Nome) like UPPER('{0}%')", Nome);
        }

        private string GerarStringCarregarAtributos()
        {
            return "SELECT * FROM Atributo ORDER BY Nome";
        }

        public bool Inserir(string Nome, string NomeParametro1, string NomeParametro2, string NomeParametro3, string NomeParametro4, bool Extendido)
        {
            Execucao excExecucao = new Execucao();
            M_Atributos_PF mtrbtspfModelo = new M_Atributos_PF();

            try
            {
                mtrbtspfModelo.Nome = Nome;
                mtrbtspfModelo.Nome = NomeParametro1;
                mtrbtspfModelo.Nome = NomeParametro2;
                mtrbtspfModelo.Nome = NomeParametro3;
                mtrbtspfModelo.Nome = NomeParametro4;
                mtrbtspfModelo.Estendido = Extendido;

                int intResultado = excExecucao.Executar(GerarStringInserir(mtrbtspfModelo));

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

        public bool Alterar(int Codigo, string Nome, string NomeParametro1, string NomeParametro2, string NomeParametro3, string NomeParametro4, bool Extendido)
        {
            Execucao excExecucao = new Execucao();
            M_Atributos_PF mtrbtspfModelo = new M_Atributos_PF();

            try
            {
                mtrbtspfModelo.Codigo = Codigo;
                mtrbtspfModelo.Nome = Nome;
                mtrbtspfModelo.Nome = NomeParametro1;
                mtrbtspfModelo.Nome = NomeParametro2;
                mtrbtspfModelo.Nome = NomeParametro3;
                mtrbtspfModelo.Nome = NomeParametro4;
                mtrbtspfModelo.Estendido = Extendido;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mtrbtspfModelo));

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
            M_Atributos_PF mtrbtspfModelo = new M_Atributos_PF();

            try
            {
                mtrbtspfModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mtrbtspfModelo));

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

        private List<M_Atributos_PF> GerarLista(SqlDataReader Leitor)
        {
            List<M_Atributos_PF> lstLista = new List<M_Atributos_PF>();

            try
            {
                while (Leitor.Read())
                {
                    M_Atributos_PF mtrbtspfModelo = new M_Atributos_PF();

                    mtrbtspfModelo.Codigo = (int)Leitor["Codigo"];
                    mtrbtspfModelo.Nome = (string)Leitor["Nome"];
                    mtrbtspfModelo.NomeParametro1 = (string)Leitor["Nome_Parametro_1"];
                    mtrbtspfModelo.NomeParametro2 = (string)Leitor["Nome_Parametro_2"];

                    if ((Leitor["Nome_Parametro_3"] != DBNull.Value) || (Leitor["Nome_Parametro_4"] != DBNull.Value))
                    {
                        mtrbtspfModelo.NomeParametro3 = (string)Leitor["Nome_Parametro_3"];
                        mtrbtspfModelo.NomeParametro4 = (string)Leitor["Nome_Parametro_4"];
                    }
                    mtrbtspfModelo.Estendido = (bool)Leitor["Extendido"];

                    lstLista.Add(mtrbtspfModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Atributos_PF> Selecionar(int Codigo)
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

        public List<M_Atributos_PF> Selecionar(string Descricao, bool Parcial)
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

        public virtual List<M_Atributos_PF> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarAtributos());

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

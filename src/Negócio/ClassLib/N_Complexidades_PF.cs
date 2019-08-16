using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Complexidades_PF : Ancestral
    {
        private string GerarStringInserir(M_Complexidades_PF Complexidades)
        {
            return String.Format("INSERT INTO Complexidade " +
                                    "(Atributo, " + 
                                    "Parametro1Min, Parametro1Max, " +
                                    "Parametro2Min, Parametro2Max, " + 
                                    "Parametro3Min, Parametro3Max, " +
                                    "Parametro4Min, Parametro4Max, " +
                                    "Nivel, Peso) VALUES " +
                                    "('{0}', " + 
                                    "{1}, {2}, " +
                                    "{3}, {4}, " + 
                                    "{5}, {6}, " + 
                                    "{7}, {8}, " + 
                                    "{9}, {10})",
                                    Complexidades.Atributo,
                                    Complexidades.Parametro1Min, Complexidades.Parametro1Max,
                                    Complexidades.Parametro2Min, Complexidades.Parametro2Max,
                                    Complexidades.Parametro3Min, Complexidades.Parametro3Max,
                                    Complexidades.Parametro4Min, Complexidades.Parametro4Max,
                                    Complexidades.Nivel, Complexidades.Peso);
        }

        private string GerarStringAlterar(M_Complexidades_PF Complexidades)
        {
            return String.Format("UPDATE Complexidade SET " +
                                    "Parametro1Min = {0}, Parametro1Max = {1}, " +
                                    "Parametro2Min = {2}, Parametro2Max = {3}, " +
                                    "Parametro3Min = {4}, Parametro3Max = {5}, " +
                                    "Parametro4Min = {6}, Parametro4Max = {7}, " +
                                    "Nivel = {8}, Peso = {9}" +
                                    "WHERE Atributo = {10} AND Codigo = {11}",
                                    Complexidades.Parametro1Min, Complexidades.Parametro1Max,
                                    Complexidades.Parametro2Min, Complexidades.Parametro2Max,
                                    Complexidades.Parametro3Min, Complexidades.Parametro3Max,
                                    Complexidades.Parametro4Min, Complexidades.Parametro4Max,
                                    Complexidades.Nivel, Complexidades.Peso,
                                    Complexidades.Atributo, Complexidades.Codigo);
        }

        private string GerarStringExcluir(M_Complexidades_PF Complexidades)
        {
            return String.Format("DELETE FROM Complexidade WHERE Atributo = {0} AND Codigo = {1}", Complexidades.Atributo, Complexidades.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Atributo, int Codigo)
        {
            return string.Format("SELECT * FROM Complexidade WHERE Atributo = {0} AND Codigo = {1}", Atributo, Codigo);
        }

        private string GerarStringSelecionarAtributo(int Atributo)
        {
            return string.Format("SELECT * FROM Complexidade WHERE Atributo = {0}", Atributo);
        }

        private string GerarStringSelecionarAtributo(int Atributo, double QuantidadeParametro1, double QuantidadeParametro2, double QuantidadeParametro3, double QuantidadeParametro4, bool Estendido)
        {
            if (Estendido)
            {
                return string.Format("SELECT Codigo " +
                    "FROM Complexidade " +
                    "WHERE Atributo = {0} " +
                    "AND Parametro_1_Minimo <= {1} " +
                    "AND Parametro_1_Maximo >= {1} " +
                    "AND Parametro_2_Minimo <= {2} " +
                    "AND Parametro_2_Maximo >= {2} " +
                    "AND Parametro_3_Minimo <= {3} " +
                    "AND Parametro_3_Maximo >= {3} " +
                    "AND Parametro_4_Minimo <= {4} " +
                    "AND Parametro_4_Maximo >= {4}",
                    Atributo,
                    QuantidadeParametro1,
                    QuantidadeParametro2,
                    QuantidadeParametro3,
                    QuantidadeParametro4);
            }
            else
            {
                return string.Format("SELECT Codigo " +
                    "FROM Complexidade " +
                    "WHERE Atributo = {0} " +
                    "AND Parametro_1_Minimo <= {1} " +
                    "AND Parametro_1_Maximo >= {1} " +
                    "AND Parametro_2_Minimo <= {2} " +
                    "AND Parametro_2_Maximo >= {2} ",
                    Atributo,
                    QuantidadeParametro1,
                    QuantidadeParametro2);
            }

        }

        public bool Inserir(int Atributo,
                                decimal Parametro1Min, decimal Parametro1Max,
                                decimal Parametro2Min, decimal Parametro2Max,
                                decimal Parametro3Min, decimal Parametro3Max, 
                                decimal Parametro4Min, decimal Parametro4Max,
                                string Nivel, decimal Peso)
        {
            Execucao excExecucao = new Execucao();
            M_Complexidades_PF mcmplxdspfModelo = new M_Complexidades_PF();

            try
            {
                mcmplxdspfModelo.Atributo = Atributo;
                mcmplxdspfModelo.Parametro1Min = Parametro1Min;
                mcmplxdspfModelo.Parametro1Max = Parametro1Max;
                mcmplxdspfModelo.Parametro2Min = Parametro2Min;
                mcmplxdspfModelo.Parametro2Max = Parametro2Max;
                mcmplxdspfModelo.Parametro3Min = Parametro3Min;
                mcmplxdspfModelo.Parametro3Max = Parametro3Max;
                mcmplxdspfModelo.Parametro4Min = Parametro4Min;
                mcmplxdspfModelo.Parametro4Max = Parametro4Max;
                mcmplxdspfModelo.Nivel = Nivel;
                mcmplxdspfModelo.Peso = Peso;

                int intResultado = excExecucao.Executar(GerarStringInserir(mcmplxdspfModelo));

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

        public bool Alterar(int Atributo, int Codigo,
                                decimal Parametro1Min, decimal Parametro1Max,
                                decimal Parametro2Min, decimal Parametro2Max,
                                decimal Parametro3Min, decimal Parametro3Max,
                                decimal Parametro4Min, decimal Parametro4Max,
                                string Nivel, decimal Peso)
        {
            Execucao excExecucao = new Execucao();
            M_Complexidades_PF mcmplxdspfModelo = new M_Complexidades_PF();

            try
            {
                mcmplxdspfModelo.Atributo = Atributo;
                mcmplxdspfModelo.Codigo = Codigo;
                mcmplxdspfModelo.Parametro1Min = Parametro1Min;
                mcmplxdspfModelo.Parametro1Max = Parametro1Max;
                mcmplxdspfModelo.Parametro2Min = Parametro2Min;
                mcmplxdspfModelo.Parametro2Max = Parametro2Max;
                mcmplxdspfModelo.Parametro3Min = Parametro3Min;
                mcmplxdspfModelo.Parametro3Max = Parametro3Max;
                mcmplxdspfModelo.Parametro4Min = Parametro4Min;
                mcmplxdspfModelo.Parametro4Max = Parametro4Max;
                mcmplxdspfModelo.Nivel = Nivel;
                mcmplxdspfModelo.Peso = Peso;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mcmplxdspfModelo));

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

        public bool Excluir(int Atributo, int Codigo)
        {
            Execucao excExecucao = new Execucao();
            M_Complexidades_PF mcmplxdspfModelo = new M_Complexidades_PF();

            try
            {
                mcmplxdspfModelo.Atributo = Atributo;
                mcmplxdspfModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mcmplxdspfModelo));

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

        private List<M_Complexidades_PF> GerarLista(SqlDataReader Leitor)
        {
            List<M_Complexidades_PF> lstLista = new List<M_Complexidades_PF>();

            try
            {
                while (Leitor.Read())
                {
                    M_Complexidades_PF mcmplxdspfModelo = new M_Complexidades_PF();

                    mcmplxdspfModelo.Atributo = (int)Leitor["Atributo"];
                    mcmplxdspfModelo.Codigo = (int)Leitor["Codigo"];
                    mcmplxdspfModelo.Parametro1Min = (decimal)Leitor["Parametro_1_Minimo"];
                    mcmplxdspfModelo.Parametro1Max = (decimal)Leitor["Parametro_1_Maximo"];
                    mcmplxdspfModelo.Parametro2Min = (decimal)Leitor["Parametro_2_Minimo"];
                    mcmplxdspfModelo.Parametro2Max = (decimal)Leitor["Parametro_2_Maximo"];
                    mcmplxdspfModelo.Parametro3Min = (decimal)Leitor["Parametro_3_Minimo"];
                    mcmplxdspfModelo.Parametro3Max = (decimal)Leitor["Parametro_3_Maximo"];
                    mcmplxdspfModelo.Parametro4Min = (decimal)Leitor["Parametro_4_Minimo"];
                    mcmplxdspfModelo.Parametro4Max = (decimal)Leitor["Parametro_4_Maximo"];
                    mcmplxdspfModelo.Nivel = (string)Leitor["Nivel"];
                    mcmplxdspfModelo.Peso = (decimal)Leitor["Peso"];

                    lstLista.Add(mcmplxdspfModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Complexidades_PF> Selecionar(int Atributo, int Codigo)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarCodigo(Atributo, Codigo));

                if (sqldtrdrLeitor.HasRows)
                {
                    return GerarLista(sqldtrdrLeitor);
                }
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Complexidade"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Complexidades_PF> Selecionar(int Atributo)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarAtributo(Atributo));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Complexidade"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Atributos_PF> CarregarAtributos()
        {
            return (new N_Atributos_PF()).Carregar();
        }

        public virtual int SelecionarCodigo(int Atributo, double QuantidadeParametro1, double QuantidadeParametro2, double QuantidadeParametro3, double QuantidadeParametro4, bool Estendido)
        {
            Selecao slcSelecao = new Selecao();

            try
            {
                return (int)slcSelecao.Buscar(GerarStringSelecionarAtributo(Atributo, QuantidadeParametro1, QuantidadeParametro2, QuantidadeParametro3, QuantidadeParametro4, Estendido));
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return 0;
            }
        }
    }
}

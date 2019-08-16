using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Calculo_COCOMO : Ancestral
    {
        private string GerarStringCalculoInstrucoes(int Projeto)
        {
            return string.Format("SELECT SUM(Linguagem.Equivalente_PF) AS Equivalencia " +
                                 "FROM Projeto_Linguagem                               " +
	                             "INNER JOIN Linguagem                                 " +
                                 "  ON Projeto_Linguagem.Linguagem = Linguagem.Codigo  " +
                                 "WHERE (Projeto_Linguagem.Projeto = {0})              ",
                                 Projeto.ToString());
        }

        private string GerarStringCalculoEsforco(int Projeto)
        {
            return string.Format("SELECT Esforco_Modelo_Tipo.Esforco_Fator_Multiplicacao,               " +
                                 "       Esforco_Modelo_Tipo.Esforco_Exponencial                        " +
                                 "FROM Projeto                                                          " +
	                             "INNER JOIN Esforco_Modelo_Tipo                                        " +
                                 "  ON Projeto.Modelo = Esforco_Modelo_Tipo.Modelo                      " +
                                 "  AND Projeto.Tipo_Fundamental = Esforco_Modelo_Tipo.Tipo_Fundamental " +
                                 "WHERE (Projeto.Codigo = {0})                                          ",
                                 Projeto.ToString());
        }

        private string GerarStringCalculoPrazo(int Projeto)
        {
            return string.Format("SELECT                                                  " +
                                 "          Tipo_Fundamental.Prazo_Fator_Multiplicacao,   " +
                                 "          Tipo_Fundamental.Prazo_Exponencial            " +
                                 "FROM Tipo_Fundamental                                   " +
                                 "INNER JOIN Projeto                                      " +
                                 "  ON Tipo_Fundamental.Codigo = Projeto.Tipo_Fundamental " +
                                 "WHERE (Projeto.Codigo = {0})                            ", Projeto.ToString());
        }

        private string GerarStringCalculoFatorAjusteAncestral(int Projeto)
        {
            return string.Format("SELECT COCOMO_Caracteristica_Escala.Fator_Ajuste                                                              " +
                                 "FROM Projeto_Caracteristica_COCOMO                                                                            " +
                                 "INNER JOIN COCOMO_Caracteristica_Escala                                                                       " + 
                                 "  ON Projeto_Caracteristica_COCOMO.COCOMO_Caracteristica = COCOMO_Caracteristica_Escala.COCOMO_Caracteristica " + 
                                 "  AND Projeto_Caracteristica_COCOMO.COCOMO_Escala = COCOMO_Caracteristica_Escala.COCOMO_Escala                " + 
                                 "INNER JOIN COCOMO_Caracteristicas                                                                             " +
                                 "  ON COCOMO_Caracteristica_Escala.COCOMO_Caracteristica = COCOMO_Caracteristicas.Codigo                       " +
                                 "WHERE (Projeto_Caracteristica_COCOMO.Projeto = {0})                                                           " +
                                 "AND (COCOMO_Caracteristicas.Ancestral IS NULL)                                                                ",
                                 Projeto.ToString());
        }

        private string GerarStringCalculoFatorAjusteHerdeiro(int Projeto)
        {
            return string.Format("SELECT                                                                                                        " + 
                                 "          COCOMO_Caracteristica_Escala.Fator_Ajuste,                                                          " +
                                 "          Projeto_Caracteristica_COCOMO.COCOMO_Escala,                                                        " +
                                 "          COUNT(*) AS Quantidade                                                                              " +
                                 "FROM Projeto_Caracteristica_COCOMO                                                                            " +
                                 "INNER JOIN COCOMO_Caracteristica_Escala                                                                       " +
                                 "  ON Projeto_Caracteristica_COCOMO.COCOMO_Caracteristica = COCOMO_Caracteristica_Escala.COCOMO_Caracteristica " +
                                 "  AND Projeto_Caracteristica_COCOMO.COCOMO_Escala = COCOMO_Caracteristica_Escala.COCOMO_Escala                " +
                                 "INNER JOIN COCOMO_Caracteristicas                                                                             " +
                                 "  ON COCOMO_Caracteristica_Escala.COCOMO_Caracteristica = COCOMO_Caracteristicas.Codigo                       " +
                                 "WHERE (Projeto_Caracteristica_COCOMO.Projeto = {0})                                                           " +
                                 "AND (COCOMO_Caracteristicas.Ancestral IS NOT NULL)                                                            " +
                                 "GROUP BY                                                                                                      " +
                                 "          COCOMO_Caracteristica_Escala.Fator_Ajuste,                                                          " +
                                 "          Projeto_Caracteristica_COCOMO.COCOMO_Escala                                                         " +
                                 "ORDER BY Quantidade DESC, Fator_Ajuste DESC                                                                   ",
                                 Projeto.ToString());
        }

        private string GerarStringValidarLinguagem(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Linguagem WHERE Projeto = {0}", Projeto);
        }

        private string GerarStringValidarCaracteristicas(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Caracteristica_COCOMO WHERE Projeto = {0}", Projeto);
        }

        private double CalcularKDSI(int Projeto, double PF)
        {
            double dblInstrucoes = (double)(new Selecao()).Buscar(GerarStringCalculoInstrucoes(Projeto));

            return (PF * dblInstrucoes) / 1000;
        }

        private double CalcularFatorAjusteAncestrais(int Projeto)
        {
            double dblFatorAjuste = 1;
            SqlDataReader sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringCalculoFatorAjusteAncestral(Projeto));

            while (sqldtrdrLeitor.Read())
                dblFatorAjuste = dblFatorAjuste * (double)sqldtrdrLeitor["Fator_Ajuste"];

            return dblFatorAjuste;
        }

        private double CalcularFatorAjusteHerdeiros(int Projeto)
        {
            double dblFatorAjuste = 1;
            SqlDataReader sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringCalculoFatorAjusteHerdeiro(Projeto));

            if (sqldtrdrLeitor.HasRows)
            {
                sqldtrdrLeitor.Read();
                dblFatorAjuste = (double)sqldtrdrLeitor["Fator_Ajuste"];
            }

            return dblFatorAjuste;
        }

        private double CalcularFatorAjuste(int Projeto)
        {
            return CalcularFatorAjusteAncestrais(Projeto) * CalcularFatorAjusteHerdeiros(Projeto);
        }

        private double CalcularEsforco(int Projeto, double KDSI)
        {
            SqlDataReader sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringCalculoEsforco(Projeto));

            sqldtrdrLeitor.Read();

            double dblFatorMultiplicacao = (double)sqldtrdrLeitor["Esforco_Fator_Multiplicacao"];
            double dblExponencial = (double)sqldtrdrLeitor["Esforco_Exponencial"];
            double dblEsforco = dblFatorMultiplicacao * Math.Pow(KDSI, dblExponencial);
            double dblFatorAjuste = CalcularFatorAjuste(Projeto);

            return dblEsforco * dblFatorAjuste;
        }

        private double CalcularPrazo(int Projeto, double Esforco)
        {
            SqlDataReader sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringCalculoPrazo(Projeto));

            sqldtrdrLeitor.Read();

            double dblFatorMultiplicacao = (double)sqldtrdrLeitor["Prazo_Fator_Multiplicacao"];
            double dblExponencial = (double)sqldtrdrLeitor["Prazo_Exponencial"];

            return dblFatorMultiplicacao * Math.Pow(Esforco, dblExponencial);
        }

        private bool VerificarDados(int Projeto)
        {
            SqlDataReader sqldtrdrLeitor;

            sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringValidarLinguagem(Projeto));
            if (!sqldtrdrLeitor.HasRows)
            {
                SetMensagem("Não há linguagens associadas ao projeto");
                return false;
            }

            sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringValidarCaracteristicas(Projeto));
            if (!sqldtrdrLeitor.HasRows)
            {
                SetMensagem("Não há características associadas ao projeto");
                return false;
            }

            return true;
        }

        public M_Calculo_COCOMO Calcular(int Projeto, double PF)
        {
            if (VerificarDados(Projeto))
            {
                try
                {
                    M_Calculo_COCOMO mclclcmModelo = new M_Calculo_COCOMO();

                    mclclcmModelo.KDSI = Biblioteca.FormatarDecimais(CalcularKDSI(Projeto, PF));
                    mclclcmModelo.Esforco = Biblioteca.FormatarDecimais(CalcularEsforco(Projeto, mclclcmModelo.KDSI));
                    mclclcmModelo.Prazo = Biblioteca.FormatarDecimais(CalcularPrazo(Projeto, mclclcmModelo.Esforco));

                    return mclclcmModelo;
                }
                catch (Exception Ex)
                {
                    SetMensagem(Mensagens.CALCULO_ERRO + Ex.Message);
                    return null;
                }
            }
            else
                return null;
        }

        public List<M_Projeto_Historico> CarregarHistorico(int Projeto)
        {
            return (new N_Projeto_Historico()).Selecionar(Projeto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Calculo_Rayleigh : Ancestral
    {
        private string GerarStringCalculoRayleighEsforco(int Projeto, double KDSI)
        {
            return string.Format("SELECT Fases.Descricao as Fase, Distribuicao_Esforco_Fase_Tipo.Percentual / 100 as Valor " +
                                 "FROM Projeto                                                                             " +
                                 "INNER JOIN Distribuicao_Esforco_Fase_Tipo                                                " +
                                 "  ON Projeto.Tipo_Fundamental = Distribuicao_Esforco_Fase_Tipo.Tipo_Fundamental          " +
                                 "INNER JOIN Tamanho_Projeto                                                               " +
                                 "  ON Distribuicao_Esforco_Fase_Tipo.Tamanho_Projeto = Tamanho_Projeto.Codigo             " +
                                 "INNER JOIN Fases                                                                         " +
                                 "  ON Distribuicao_Esforco_Fase_Tipo.Fase = Fases.Codigo                                  " +
                                 "INNER JOIN Tipo_Distribuicao                                                             " +
                                 "  ON Distribuicao_Esforco_Fase_Tipo.Tipo_Distribuicao = Tipo_Distribuicao.Codigo         " +
                                 "WHERE (Tamanho_Projeto.Tamanho_Min <= {0})                                               " +
                                 "AND (Tamanho_Projeto.Tamanho_Max >= {0})                                                 " +
                                 "AND (Distribuicao_Esforco_Fase_Tipo.Tipo_Distribuicao = 1)                               " +
                                 "AND (Projeto.Codigo = {1})                                                               ", 
                                 Biblioteca.FormatarNumero(KDSI), Projeto);
        }

        private string GerarStringCalculoRayleighPrazo(int Projeto, double KDSI)
        {
            return string.Format("SELECT Fases.Descricao as Fase, Distribuicao_Esforco_Fase_Tipo.Percentual / 100 as Valor " +
                                 "FROM Projeto                                                                             " +
                                 "INNER JOIN Distribuicao_Esforco_Fase_Tipo                                                " +
                                 "  ON Projeto.Tipo_Fundamental = Distribuicao_Esforco_Fase_Tipo.Tipo_Fundamental          " +
                                 "INNER JOIN Tamanho_Projeto                                                               " +
                                 "  ON Distribuicao_Esforco_Fase_Tipo.Tamanho_Projeto = Tamanho_Projeto.Codigo             " +
                                 "INNER JOIN Fases                                                                         " +
                                 "  ON Distribuicao_Esforco_Fase_Tipo.Fase = Fases.Codigo                                  " +
                                 "INNER JOIN Tipo_Distribuicao                                                             " +
                                 "  ON Distribuicao_Esforco_Fase_Tipo.Tipo_Distribuicao = Tipo_Distribuicao.Codigo         " +
                                 "WHERE (Tamanho_Projeto.Tamanho_Min <= {0})                                               " +
                                 "AND (Tamanho_Projeto.Tamanho_Max >= {0})                                                 " +
                                 "AND (Distribuicao_Esforco_Fase_Tipo.Tipo_Distribuicao = 2)                               " +
                                 "AND (Projeto.Codigo = {1})                                                               ",
                                 Biblioteca.FormatarNumero(KDSI), Projeto);
        }

        public List<M_Calculo_Rayleigh> CalcularDistribuicaoEsforco(int Projeto, double Esforco, double KDSI)
        {
            try
            {
                List<M_Calculo_Rayleigh> lstLista = new List<M_Calculo_Rayleigh>();
                SqlDataReader sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringCalculoRayleighEsforco(Projeto, KDSI));

                while (sqldtrdrLeitor.Read())
                {
                    M_Calculo_Rayleigh mclclrylghModelo = new M_Calculo_Rayleigh();

                    mclclrylghModelo.Fase = (string)sqldtrdrLeitor["Fase"];
                    mclclrylghModelo.Percentual = Biblioteca.FormatarDecimais((double)sqldtrdrLeitor["Valor"] * Esforco);

                    lstLista.Add(mclclrylghModelo);
                }

                return lstLista;
            }
            catch (Exception Ex)
            {
                SetMensagem(Mensagens.CALCULO_ERRO + Ex.Message);
                return null;
            }
        }

        public List<M_Calculo_Rayleigh> CalcularDistribuicaoPrazo(int Projeto, double Prazo, double KDSI)
        {
            try
            {
                List<M_Calculo_Rayleigh> lstLista = new List<M_Calculo_Rayleigh>();
                SqlDataReader sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringCalculoRayleighPrazo(Projeto, KDSI));

                while (sqldtrdrLeitor.Read())
                {
                    M_Calculo_Rayleigh mclclrylghModelo = new M_Calculo_Rayleigh();

                    mclclrylghModelo.Fase = (string)sqldtrdrLeitor["Fase"];
                    mclclrylghModelo.Percentual = Biblioteca.FormatarDecimais((double)sqldtrdrLeitor["Valor"] * Prazo);

                    lstLista.Add(mclclrylghModelo);
                }

                return lstLista;
            }
            catch (Exception Ex)
            {
                SetMensagem(Mensagens.CALCULO_ERRO + Ex.Message);
                return null;
            }
        }
    }
}

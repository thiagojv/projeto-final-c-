using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Calculo_PF : Ancestral
    {
        private string GerarStringCalculoSPFNA(int Projeto)
        {
            return string.Format("SELECT SUM(Calculo) AS SPFNA " +
                                 "FROM (SELECT Complexidade.Peso * COUNT(Projeto_Atributo.ID) AS Calculo " +
                                 "       FROM Projeto_Atributo " +
                                 "       INNER JOIN Complexidade " +
                                 "           ON Projeto_Atributo.Atributo = Complexidade.Atributo " +
                                 "   		AND Projeto_Atributo.Complexidade = Complexidade.Codigo " +
                                 "       WHERE (Projeto_Atributo.Projeto = {0}) " +
                                 "       GROUP BY Projeto_Atributo.Atributo, Complexidade.Nivel, Complexidade.Peso) Tabela", Projeto.ToString());
        }

        private string GerarStringCalculoSNI(int Projeto)
        {
            return string.Format("SELECT SUM(PF_Nivel_Influencia.Nota) AS SNI                                    " +
                                 "FROM Projeto_Caracteristicas_PF                                                " +
                                 "INNER JOIN PF_Nivel_Influencia                                                 " +
                                 "   ON Projeto_Caracteristicas_PF.Nivel_Influencia = PF_Nivel_Influencia.Codigo " +
                                 "WHERE (Projeto_Caracteristicas_PF.Projeto = {0})                               ",
                                 Projeto.ToString());
        }

        private string GerarStringValidarAtributos(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Atributo WHERE Projeto = {0}", Projeto);
        }

        private string GerarStringValidarCaracteristicas(int Projeto)
        {
            return string.Format("SELECT * FROM Projeto_Caracteristicas_PF WHERE Projeto = {0}", Projeto);
        }

        private double CalcularSPFNA(int Projeto)
        {
            return (double)(new Selecao()).Buscar(GerarStringCalculoSPFNA(Projeto));
        }

        private int CalcularSNI(int Projeto)
        {
            return (int)(new Selecao()).Buscar(GerarStringCalculoSNI(Projeto));
        }

        private double CalcularFA(double SNI)
        {
            return 0.65 + (0.01 * SNI);
        }

        private double CalcularPF(double SPFNA, double FA)
        {
            return SPFNA * FA;
        }

        private bool VerificarDados(int Projeto)
        {
            SqlDataReader sqldtrdrLeitor;

            sqldtrdrLeitor = (new Selecao()).Selecionar(GerarStringValidarAtributos(Projeto));
            if (!sqldtrdrLeitor.HasRows)
            {
                SetMensagem("Não há atributos associados ao projeto");
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

        public M_Calculo_PF Calcular(int Projeto)
        {
            if (VerificarDados(Projeto))
            {
                try
                {
                    M_Calculo_PF mclclpfModelo = new M_Calculo_PF();

                    mclclpfModelo.SPFNA = Biblioteca.FormatarDecimais(CalcularSPFNA(Projeto));
                    mclclpfModelo.SNI = Biblioteca.FormatarDecimais(CalcularSNI(Projeto));
                    mclclpfModelo.PF = Biblioteca.FormatarDecimais(CalcularPF(mclclpfModelo.SPFNA, CalcularFA(mclclpfModelo.SNI)));

                    return mclclpfModelo;
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

        public bool GravarHistorico(int Projeto, double PF)
        {
            N_Projeto_Historico nprjthstrcNegocio = new N_Projeto_Historico();
            
            bool blResultado = nprjthstrcNegocio.Inserir(Projeto, DateTime.Now, PF);

            SetMensagem(nprjthstrcNegocio.Mensagem);

            return blResultado;
        }
    }
}

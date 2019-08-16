using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Tamanho : Ancestral
    {
        private string GerarStringInserir(M_Tamanho Tamanho)
        {
            return String.Format("INSERT INTO Tamanho_Projeto (Descricao, Tamanho_Min, Tamanho_Max) VALUES ('{0}', {1}, {2})", Tamanho.Descricao, Tamanho.Tamanho_Min, Tamanho.Tamanho_Max);
        }

        private string GerarStringAlterar(M_Tamanho Tamanho)
        {
            return string.Format("UPDATE Tamanho_Projeto SET Descricao = '{0}', Tamanho_Min = {1}, Tamanho_Max = {2} WHERE Codigo = {3}", Tamanho.Descricao, Tamanho.Tamanho_Min, Tamanho.Tamanho_Max, Tamanho.Codigo);
        }

        private string GerarStringExcluir(M_Tamanho Tamanho)
        {
            return string.Format("DELETE FROM Tamanho_Projeto WHERE Codigo = {0}", Tamanho.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Tamanho_Projeto WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Descricao)
        {
            return string.Format("SELECT * FROM Tamanho_Projeto WHERE UPPER(Descricao) = UPPER('{0}')", Descricao);
        }

        private string GerarStringSelecionarDescricaoParcial(string Descricao)
        {
            return string.Format("SELECT * FROM Tamanho_Projeto WHERE UPPER(Descricao) like UPPER('{0}%')", Descricao);
        }

        public bool Inserir(string Descricao, double Tamanho_Min, double Tamanho_Max)
        {
            Execucao excExecucao = new Execucao();
            M_Tamanho mtmnhModelo = new M_Tamanho();

            try
            {
                mtmnhModelo.Descricao = Descricao;
                mtmnhModelo.Tamanho_Min = Tamanho_Min;
                mtmnhModelo.Tamanho_Max = Tamanho_Max;

                int intResultado = excExecucao.Executar(GerarStringInserir(mtmnhModelo));

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

        public bool Alterar(int Codigo, string Descricao, double Tamanho_Min, double Tamanho_Max)
        {
            Execucao excExecucao = new Execucao();
            M_Tamanho mtmnhModelo = new M_Tamanho();

            try
            {
                mtmnhModelo.Codigo = Codigo;
                mtmnhModelo.Descricao = Descricao;
                mtmnhModelo.Tamanho_Min = Tamanho_Min;
                mtmnhModelo.Tamanho_Max = Tamanho_Max;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mtmnhModelo));

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
            M_Tamanho mtmnhModelo = new M_Tamanho();

            try
            {
                mtmnhModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mtmnhModelo));

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

        private List<M_Tamanho> GerarLista(SqlDataReader Leitor)
        {
            List<M_Tamanho> lstLista = new List<M_Tamanho>();

            try
            {
                while (Leitor.Read())
                {
                    M_Tamanho mtmnhModelo = new M_Tamanho();

                    mtmnhModelo.Codigo = (int)Leitor["Codigo"];
                    mtmnhModelo.Descricao = (string)Leitor["Descricao"];
                    mtmnhModelo.Tamanho_Min = (double)Leitor["Tamanho_Min"];
                    mtmnhModelo.Tamanho_Max = (double)Leitor["Tamanho_Max"];

                    lstLista.Add(mtmnhModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Tamanho> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tamanho"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Tamanho> Selecionar(string Descricao, bool Parcial)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tamanho"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }
    }
}

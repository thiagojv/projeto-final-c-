using System;
using Modelo;
using System.Text;
using System.Data;
using Persistencia;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Negocio
{
    public class N_Tipo_Distribuicao : Ancestral
    {
        private string GerarStringInserir(M_Tipo_Distribuicao Tipo_Distribuicao)
        {
            return String.Format("INSERT INTO Tipo_Distribuicao (Descricao) VALUES ('{0}')", Tipo_Distribuicao.Descricao);
        }

        private string GerarStringAlterar(M_Tipo_Distribuicao Tipo_Distribuicao)
        {
            return string.Format("UPDATE Tipo_Distribuicao SET Descricao = '{0}' WHERE Codigo = {1}", Tipo_Distribuicao.Descricao, Tipo_Distribuicao.Codigo);
        }

        private string GerarStringExcluir(M_Tipo_Distribuicao Tipo_Distribuicao)
        {
            return string.Format("DELETE FROM Tipo_Distribuicao WHERE Codigo = {0}", Tipo_Distribuicao.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Tipo_Distribuicao WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Descricao)
        {
            return string.Format("SELECT * FROM Tipo_Distribuicao WHERE UPPER(Descricao) = UPPER('{0}')", Descricao);
        }

        private string GerarStringSelecionarDescricaoParcial(string Descricao)
        {
            return string.Format("SELECT * FROM Tipo_Distribuicao WHERE UPPER(Descricao) like UPPER('{0}%')", Descricao);
        }

        public bool Inserir(string Descricao)
        {
            Execucao excExecucao = new Execucao();
            M_Tipo_Distribuicao mtpdstrbcModelo = new M_Tipo_Distribuicao();

            try
            {
                mtpdstrbcModelo.Descricao = Descricao;
                
                int intResultado = excExecucao.Executar(GerarStringInserir(mtpdstrbcModelo));

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

        public bool Alterar(int Codigo, string Descricao)
        {
            Execucao excExecucao = new Execucao();
            M_Tipo_Distribuicao mtpdstrbcModelo = new M_Tipo_Distribuicao();

            try
            {
                mtpdstrbcModelo.Codigo = Codigo;
                mtpdstrbcModelo.Descricao = Descricao;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mtpdstrbcModelo));

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
            M_Tipo_Distribuicao mtpdstrbcModelo = new M_Tipo_Distribuicao();

            try
            {
                mtpdstrbcModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mtpdstrbcModelo));

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

        private List<M_Tipo_Distribuicao> GerarLista(SqlDataReader Leitor)
        {
            List<M_Tipo_Distribuicao> lstLista = new List<M_Tipo_Distribuicao>();

            try
            {
                while (Leitor.Read())
                {
                    M_Tipo_Distribuicao mtpdstrbcModelo = new M_Tipo_Distribuicao();

                    mtpdstrbcModelo.Codigo = (int)Leitor["Codigo"];
                    mtpdstrbcModelo.Descricao = (string)Leitor["Descricao"];

                    lstLista.Add(mtpdstrbcModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Tipo_Distribuicao> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tipo de Distribuição"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Tipo_Distribuicao> Selecionar(string Descricao, bool Parcial)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Tipo de Distribuição"));
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

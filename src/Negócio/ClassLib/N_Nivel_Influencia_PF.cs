using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class N_Nivel_Influencia_PF : Ancestral
    {
        private string GerarStringInserir(M_Nivel_Influencia_PF Nivel_Influencia)
        {
            return String.Format("INSERT INTO PF_Nivel_Influencia (Descricao, Nota) VALUES ('{0}', {1})", Nivel_Influencia.Descricao, Nivel_Influencia.Nota);
        }

        private string GerarStringAlterar(M_Nivel_Influencia_PF Nivel_Influencia)
        {
            return string.Format("UPDATE PF_Nivel_Influencia SET Descricao = '{0}', Nota = {1} WHERE Codigo = {2}", Nivel_Influencia.Descricao, Nivel_Influencia.Nota, Nivel_Influencia.Codigo);
        }

        private string GerarStringExcluir(M_Nivel_Influencia_PF Nivel_Influencia)
        {
            return string.Format("DELETE FROM PF_Nivel_Influencia WHERE Codigo = {0}", Nivel_Influencia.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM PF_Nivel_Influencia WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarDescricao(string Descricao)
        {
            return string.Format("SELECT * FROM PF_Nivel_Influencia WHERE UPPER(Descricao) = UPPER('{0}')", Descricao);
        }

        private string GerarStringSelecionarDescricaoParcial(string Descricao)
        {
            return string.Format("SELECT * FROM PF_Nivel_Influencia WHERE UPPER(Descricao) like UPPER('{0}%')", Descricao);
        }

        private string GerarStringCarregarNiveisInfluencia()
        {
            return string.Format("SELECT * FROM PF_Nivel_Influencia ORDER BY Nota");
        }

        public bool Inserir(string Descricao, decimal Nota)
        {
            Execucao excExecucao = new Execucao();
            M_Nivel_Influencia_PF mnvlnflncModelo = new M_Nivel_Influencia_PF();

            try
            {
                mnvlnflncModelo.Descricao = Descricao;
                mnvlnflncModelo.Nota = (int)Nota;

                int intResultado = excExecucao.Executar(GerarStringInserir(mnvlnflncModelo));

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

        public bool Alterar(int Codigo, string Descricao, decimal Nota)
        {
            Execucao excExecucao = new Execucao();
            M_Nivel_Influencia_PF mnvlnflncModelo = new M_Nivel_Influencia_PF();

            try
            {
                mnvlnflncModelo.Codigo = Codigo;
                mnvlnflncModelo.Descricao = Descricao;
                mnvlnflncModelo.Nota = (int)Nota;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mnvlnflncModelo));

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
            M_Nivel_Influencia_PF mnvlnflncModelo = new M_Nivel_Influencia_PF();

            try
            {
                mnvlnflncModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mnvlnflncModelo));

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

        private List<M_Nivel_Influencia_PF> GerarLista(SqlDataReader Leitor)
        {
            List<M_Nivel_Influencia_PF> lstLista = new List<M_Nivel_Influencia_PF>();

            try
            {
                while (Leitor.Read())
                {
                    M_Nivel_Influencia_PF mnvlnflncModelo = new M_Nivel_Influencia_PF();

                    mnvlnflncModelo.Codigo = (int)Leitor["Codigo"];
                    mnvlnflncModelo.Descricao = (string)Leitor["Descricao"];
                    mnvlnflncModelo.Nota = (int)Leitor["Nota"];

                    lstLista.Add(mnvlnflncModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Nivel_Influencia_PF> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Nível de Influência"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Nivel_Influencia_PF> Selecionar(string Descricao, bool Parcial)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_O, "Nível de Influência"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public virtual List<M_Nivel_Influencia_PF> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarNiveisInfluencia());

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

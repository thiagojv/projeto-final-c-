using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Projeto : Ancestral
    {
        private string GerarStringInserir(M_Projeto Projeto)
        {
            return String.Format("INSERT INTO Projeto (Nome, Data_Inicio, Data_Termino, Modelo, Tipo_Fundamental, Status) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5})", Projeto.Nome, Biblioteca.FormatarData(Projeto.Data_Inicio), Biblioteca.FormatarData(Projeto.Data_Termino), Projeto.Modelo, Projeto.Tipo_Fundamental, Biblioteca.ConverterBool2Int(Projeto.Status));
        }

        private string GerarStringAlterar(M_Projeto Projeto)
        {
            return String.Format("UPDATE Projeto SET Nome = '{0}', Data_Inicio = '{1}', Data_Termino = '{2}', Modelo = {3}, Tipo_Fundamental = {4}, Status = {5} WHERE Codigo = {6}", Projeto.Nome, Biblioteca.FormatarData(Projeto.Data_Inicio), Biblioteca.FormatarData(Projeto.Data_Termino), Projeto.Modelo, Projeto.Tipo_Fundamental, Biblioteca.ConverterBool2Int(Projeto.Status), Projeto.Codigo);
        }

        private string GerarStringExcluir(M_Projeto Projeto)
        {
            return String.Format("DELETE FROM Projeto WHERE Codigo = {0}", Projeto.Codigo);
        }

        private string GerarStringSelecionarCodigo(int Codigo)
        {
            return string.Format("SELECT * FROM Projeto WHERE Codigo = {0}", Codigo);
        }

        private string GerarStringSelecionarNome(string Nome)
        {
            return string.Format("SELECT * FROM Projeto WHERE Nome = '{0}'", Nome);
        }

        private string GerarStringSelecionarNomeParcial(string Nome)
        {
            return string.Format("SELECT * FROM Projeto WHERE Nome like '{0}%'", Nome);
        }

        private string GerarStringCarregarProjetos()
        {
            return "SELECT * FROM Projeto ORDER BY Nome";
        }

        public bool Inserir(string Nome, DateTime Data_Inicio, DateTime Data_Termino, int Modelo, int Tipo_Fundamental, bool Status)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto mprjtModelo = new M_Projeto();

            try
            {
                mprjtModelo.Nome = Nome;
                mprjtModelo.Data_Inicio = Data_Inicio;
                mprjtModelo.Data_Termino = Data_Termino;
                mprjtModelo.Modelo = Modelo;
                mprjtModelo.Tipo_Fundamental = Tipo_Fundamental;
                mprjtModelo.Status = Status;

                int intResultado = excExecucao.Executar(GerarStringInserir(mprjtModelo));

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

        public bool Alterar(int Codigo, string Nome, DateTime Data_Inicio, DateTime Data_Termino, int Modelo, int Tipo_Fundamental, bool Status)
        {
            Execucao excExecucao = new Execucao();
            M_Projeto mprjtModelo = new M_Projeto();

            try
            {
                mprjtModelo.Codigo = Codigo;
                mprjtModelo.Nome = Nome;
                mprjtModelo.Data_Inicio = Data_Inicio;
                mprjtModelo.Data_Termino = Data_Termino;
                mprjtModelo.Modelo = Modelo;
                mprjtModelo.Tipo_Fundamental = Tipo_Fundamental;
                mprjtModelo.Status = Status;

                int intResultado = excExecucao.Executar(GerarStringAlterar(mprjtModelo));

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
            M_Projeto mprjtModelo = new M_Projeto();

            try
            {
                mprjtModelo.Codigo = Codigo;

                int intResultado = excExecucao.Executar(GerarStringExcluir(mprjtModelo));

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

        private List<M_Projeto> GerarLista(SqlDataReader Leitor)
        {
            List<M_Projeto> lstLista = new List<M_Projeto>();

            try
            {
                while (Leitor.Read())
                {
                    M_Projeto mprjtModelo = new M_Projeto();

                    mprjtModelo.Codigo = (int)Leitor["Codigo"];
                    mprjtModelo.Nome = (string)Leitor["Nome"];
                    mprjtModelo.Data_Inicio = (DateTime)Leitor["Data_Inicio"];
                    mprjtModelo.Data_Termino = (DateTime)Leitor["Data_Termino"];
                    mprjtModelo.Modelo = (int)Leitor["Modelo"];
                    mprjtModelo.Tipo_Fundamental = (int)Leitor["Tipo_Fundamental"];
                    mprjtModelo.Status = (bool)Leitor["Status"];

                    lstLista.Add(mprjtModelo);
                }

                return lstLista;
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public List<M_Projeto> Selecionar(int Codigo)
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
                    SetMensagem(string.Format(Mensagens.SELECAO_NADA_A, "Projeto"));
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem(Mensagens.SELECAO_ERRO + E.Message);
                return null;
            }
        }

        public List<M_Projeto> Selecionar(string Nome, bool Parcial)
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                if (Parcial)
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarNomeParcial(Nome));
                else
                    sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringSelecionarNome(Nome));

                if (sqldtrdrLeitor.HasRows)
                    return GerarLista(sqldtrdrLeitor);
                else
                {
                    SetMensagem("Não foi possível encontrar o Projeto desejado");
                    return null;
                }
            }
            catch (Exception E)
            {
                SetMensagem("Erro ao processar a seleção. " + E.Message);
                return null;
            }
        }

        public virtual List<M_Modelo> CarregarModelos()
        {
            return (new N_Modelo()).Carregar();
        }

        public virtual List<M_Tipos_FundamentaisCOCOMO> CarregarTiposFundamentais()
        {
            return (new N_Tipos_FundamentaisCOCOMO()).Carregar();
        }

        public virtual List<M_Projeto> Carregar()
        {
            SqlDataReader sqldtrdrLeitor;
            Selecao slcSelecao = new Selecao();

            try
            {
                sqldtrdrLeitor = slcSelecao.Selecionar(GerarStringCarregarProjetos());

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

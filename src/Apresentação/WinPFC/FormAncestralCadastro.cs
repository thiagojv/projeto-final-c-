using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmAncestralCadastro : FrmAncestral
    {
        public FrmAncestralCadastro()
        {
            InitializeComponent();
        }

        private void tlstrpbtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void tlstrpbtnProcurar_Click(object sender, EventArgs e)
        {
            Procurar();
        }

        private void tlstrpbtnInserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void tlstrpbtnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void tlstrpbtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void tlstrpbtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        protected virtual void Novo()
        {
            LimparFormulario();
            tlstrpbtnNovo.Enabled = false;
            tlstrpbtnProcurar.Enabled = false;
            tlstrpbtnInserir.Enabled = true;
            tlstrpbtnAlterar.Enabled = false;
            tlstrpbtnExcluir.Enabled = false;
            tlstrpbtnCancelar.Enabled = true;
        }

        protected virtual void Procurar()
        {
            if (CarregarDados())
            {
                tlstrpbtnNovo.Enabled = false;
                tlstrpbtnProcurar.Enabled = false;
                tlstrpbtnInserir.Enabled = false;
                tlstrpbtnAlterar.Enabled = true;
                tlstrpbtnExcluir.Enabled = true;
                tlstrpbtnCancelar.Enabled = true;
            }
        }

        protected virtual void Inserir()
        {
            tlstrpbtnNovo.Enabled = true;
            tlstrpbtnProcurar.Enabled = true;
            tlstrpbtnInserir.Enabled = false;
            tlstrpbtnAlterar.Enabled = false;
            tlstrpbtnExcluir.Enabled = false;
            tlstrpbtnCancelar.Enabled = false;
        }

        protected virtual void Alterar()
        {
            tlstrpbtnNovo.Enabled = true;
            tlstrpbtnProcurar.Enabled = true;
            tlstrpbtnInserir.Enabled = false;
            tlstrpbtnAlterar.Enabled = false;
            tlstrpbtnExcluir.Enabled = false;
            tlstrpbtnCancelar.Enabled = false;
        }

        protected virtual void Excluir()
        {
            tlstrpbtnNovo.Enabled = true;
            tlstrpbtnProcurar.Enabled = true;
            tlstrpbtnInserir.Enabled = false;
            tlstrpbtnAlterar.Enabled = false;
            tlstrpbtnExcluir.Enabled = false;
            tlstrpbtnCancelar.Enabled = false;
        }

        protected virtual void Cancelar()
        {        
            tlstrpbtnNovo.Enabled = true;
            tlstrpbtnProcurar.Enabled = true;
            tlstrpbtnInserir.Enabled = false;
            tlstrpbtnAlterar.Enabled = false;
            tlstrpbtnExcluir.Enabled = false;
            tlstrpbtnCancelar.Enabled = false;

            LimparFormulario();
        }

        protected virtual bool CarregarDados()
        {
            return true;
        }

        protected virtual void CarregarFormulario()
        {

        }

        private void FrmAncestralCadastro_Load(object sender, EventArgs e)
        {
            tlstrpbtnNovo.Enabled = true;
            tlstrpbtnProcurar.Enabled = true;
            tlstrpbtnInserir.Enabled = false;
            tlstrpbtnAlterar.Enabled = false;
            tlstrpbtnExcluir.Enabled = false;
            tlstrpbtnCancelar.Enabled = false;

            CarregarFormulario();
        }

    }
}
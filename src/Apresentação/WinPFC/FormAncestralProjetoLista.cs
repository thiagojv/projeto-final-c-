using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmAncestralProjetoLista : WinPFC.FrmAncestralProjeto
    {
        public FrmAncestralProjetoLista()
        {
            InitializeComponent();
        }

        protected object Selecionado
        {
            get { return lstbxCaracteristicas.SelectedItem; }
        }

        private void lstbxCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarRegistro();
        }

        protected virtual void SelecionarRegistro()
        {

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

        protected virtual void Inserir()
        {
        }

        protected virtual void Alterar()
        {
        }

        protected virtual void Excluir()
        {
        }

        protected virtual void Cancelar()
        {
        }
    }
}


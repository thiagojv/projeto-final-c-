using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmAncestralProcuraIndice : WinPFC.FrmAncestralProcura
    {
        public FrmAncestralProcuraIndice()
        {
            InitializeComponent();
        }

        protected virtual void CarregarIndice()
        {

        }

        protected override void LimparFormulario()
        {
            base.LimparFormulario();
            cmbxIndice.SelectedIndex = -1;
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();
            CarregarIndice();
            dtgrdvwProcura.BringToFront();
        }

        protected virtual void Procurar(int Indice)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbxIndice.SelectedValue != null)
                Procurar((int)cmbxIndice.SelectedValue);
        }
    }
}


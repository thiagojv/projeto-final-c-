using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmAncestralProcuraProjeto : WinPFC.FrmAncestralProcura
    {
        private int intProjeto;

        public int Projeto
        {
            get { return intProjeto; }
            set { intProjeto = value; }
        }

        public FrmAncestralProcuraProjeto()
        {
            InitializeComponent();
            Projeto = -1;
        }
    }
}


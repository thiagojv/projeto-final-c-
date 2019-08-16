using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Modelo;

namespace WinPFC
{
    public partial class FrmManutencaoProjetoHistorico : WinPFC.FrmAncestralProjeto
    {
        public FrmManutencaoProjetoHistorico()
        {
            InitializeComponent();
        }

        protected override void ExecutarAcao()
        {
            base.ExecutarAcao();
            dtgrdvwHistorico.DataSource = (new N_Projeto_Historico()).Selecionar(Projeto_Selecionado);
        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinPFC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(FrmAncestral Formulario)
        {
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void tlstrpmntmCadastrosDistribuicaoTipoDistribuicao_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroTipo_Distribuicao());
        }

        private void tlstrpmntmCadastrosCOCOMOLinguagem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroLinguagem());
        }

        private void tlstrpmntmCadastrosCOCOMOEscalas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroEscalasCOCOMO());
        }

        private void tlstrpmntmCadastrosPontosFuncaoAtributos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroAtributos_PF());
        }

        private void tlstrpmntmCadastrosPontosFuncaoCaracteristicas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroCaracteristicas_PF());
        }

        private void tlstrpmntmCadastrosPontosFuncaoNiveisInfluencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroNivel_Influencia_PF());
        }

        private void tlstrpmntmCadastrosDistribuicaoTamanhos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroTamanho());
        }

        private void tlstrpmntmCadastrosPontosFuncaoComplexidades_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroComplexidades_PF());
        }

        private void tlstrpmntmCadastrosCOCOMOModelos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroModelo());
        }

        private void tlstrpmntmCadastrosCOCOMOTipos_Fundamentais_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroTipos_FundamentaisCOCOMO());
        }

        private void tlstrpmntmCadastroEsforco_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCadastroEsforco());
        }

        private void tlstrpmntmProjetosDados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManutencaoProjeto());
        }

        private void tlstrpmntmProjetosLinguagens_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManutencaoProjetoLinguagem());
        }

        private void tlstrpmntmProjetosAtributos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManutencaoProjetoAtributos());
        }

        private void tlstrpmntmProjetosCaracteristicasCOCOMO_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManutencaoProjetoCaracteristicaCOCOMO());
        }

        private void tlstrpmntmProjetosCaracteristicasPF_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManutencaoProjetoCaracteristicaPF());
        }

        private void tlstrpmntmProjetosHistorico_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManutencaoProjetoHistorico());
        }

        private void tlstrpmntmCalculoMedicao_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCalculo_PF());
        }

        private void tlstrpmntmCalculoEstimativas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCalculo_COCOMO());
        }
    }
}
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
    public partial class FrmCalculo_COCOMO : WinPFC.FrmAncestralProjeto
    {
        private M_Calculo_COCOMO mclclcmModelo;
        private M_Calculo_Rayleigh mclclrylghModelo;

        public M_Calculo_COCOMO Calculo_COCOMO
        {
            get { return mclclcmModelo; }
            set { mclclcmModelo = value; }
        }

        public M_Calculo_Rayleigh Calculo_Rayleigh
        {
            get { return mclclrylghModelo; }
            set { mclclrylghModelo = value; }
        }

        public FrmCalculo_COCOMO()
        {
            InitializeComponent();
        }

        protected override void ExecutarAcao()
        {
            base.ExecutarAcao();

            cmbxHistorico.DataSource = (new N_Calculo_COCOMO()).CarregarHistorico(Projeto_Selecionado);
            cmbxHistorico.DisplayMember = "Display";
            cmbxHistorico.ValueMember = "Tamanho_PF";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            N_Calculo_COCOMO nclclcmNegocio = new N_Calculo_COCOMO();
            N_Calculo_Rayleigh nclclrylghNegocio = new N_Calculo_Rayleigh();

            Calculo_COCOMO = nclclcmNegocio.Calcular(Projeto_Selecionado, (double)((M_Projeto_Historico)cmbxHistorico.SelectedItem).Tamanho_PF);

            if (Calculo_COCOMO != null)
            {
                lblValorKDSI.Text = Calculo_COCOMO.KDSI.ToString() + " KDSI";
                lblValorEsforco.Text = Calculo_COCOMO.Esforco.ToString() + " Homens/Mês";
                lblValorPrazo.Text = Calculo_COCOMO.Prazo.ToString() + " Mês";
                lblValorEquipe.Text = Calculo_COCOMO.Equipe.ToString() + " Pessoas";

                dtgrdvwEsforco.DataSource = nclclrylghNegocio.CalcularDistribuicaoEsforco(Projeto_Selecionado, Calculo_COCOMO.Esforco, Calculo_COCOMO.KDSI);
                if (dtgrdvwEsforco.DataSource == null)
                    MessageBox.Show(nclclrylghNegocio.Mensagem);

                dtgrdvwPrazo.DataSource = nclclrylghNegocio.CalcularDistribuicaoPrazo(Projeto_Selecionado, Calculo_COCOMO.Prazo, Calculo_COCOMO.KDSI);
                if (dtgrdvwPrazo.DataSource == null)
                    MessageBox.Show(nclclrylghNegocio.Mensagem);
            }
            else
                MessageBox.Show(nclclcmNegocio.Mensagem);
        }
    }
}


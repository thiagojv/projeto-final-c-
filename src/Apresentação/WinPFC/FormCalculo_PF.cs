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
    public partial class FrmCalculo_PF : WinPFC.FrmAncestralProjeto
    {
        M_Calculo_PF mclclpfModelo;

        public M_Calculo_PF Calculo_PF
        {
            get { return mclclpfModelo; }
            set { mclclpfModelo = value; }
        }

        public FrmCalculo_PF()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            N_Calculo_PF nclclpfNegocio = new N_Calculo_PF();
            
            Calculo_PF = nclclpfNegocio.Calcular(Projeto_Selecionado);

            if (Calculo_PF != null)
            {
                lblValorSPFNA.Text = Calculo_PF.SPFNA.ToString() + " PF";
                lblValorSNI.Text = Calculo_PF.SNI.ToString();
                lblValorPF.Text = Calculo_PF.PF.ToString() + " PF";
            }
            else
                MessageBox.Show(nclclpfNegocio.Mensagem);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            N_Calculo_PF nclclpfNegocio = new N_Calculo_PF();

            nclclpfNegocio.GravarHistorico(Projeto_Selecionado, Calculo_PF.PF);
            MessageBox.Show(nclclpfNegocio.Mensagem);
        }

    }
}


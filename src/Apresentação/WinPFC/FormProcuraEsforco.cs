using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace WinPFC
{
    public partial class FrmProcuraEsforco : WinPFC.FrmAncestralProcuraIndice
    {
        M_Esforco msfrcEsforco;

        public M_Esforco Esforco
        {
            get { return msfrcEsforco; }
        }

        public FrmProcuraEsforco()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            msfrcEsforco = (M_Esforco)ObterSelecao();
            if (msfrcEsforco == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Linguagem"));
            else
                base.Selecionar();
        }

        protected override void Procurar(int Codigo)
        {
            List<M_Esforco> lstLista;
            N_Esforco nsfrcNegocio = new N_Esforco();

            try
            {
                lstLista = nsfrcNegocio.Selecionar(Codigo);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(nsfrcNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }

        protected override void CarregarFormulario()
        {
            base.CarregarFormulario();

            N_Esforco nsfrcNegocio = new N_Esforco();
            List<M_Tipos_FundamentaisCOCOMO> lstLista = nsfrcNegocio.CarregarTiposFundamentais();
            M_Tipos_FundamentaisCOCOMO mtpsfndmntscmModelo = new M_Tipos_FundamentaisCOCOMO();

            mtpsfndmntscmModelo.Codigo = -1;

            lstLista.Insert(0, mtpsfndmntscmModelo);

            cmbxIndice.DataSource = lstLista;
            cmbxIndice.DisplayMember = "Nome";
            cmbxIndice.ValueMember = "Codigo";
        }
    }
}


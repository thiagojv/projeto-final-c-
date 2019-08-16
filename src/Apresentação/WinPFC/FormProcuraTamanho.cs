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
    public partial class FrmProcuraTamanho : WinPFC.FrmAncestralProcuraNome
    {
        M_Tamanho mtmnhModelo;

        public M_Tamanho Tamanho
        {
            get { return mtmnhModelo; }
        }

        public FrmProcuraTamanho()
        {
            InitializeComponent();
        }

        protected override void Selecionar()
        {
            mtmnhModelo = (M_Tamanho)ObterSelecao();
            if (mtmnhModelo == null)
                MessageBox.Show(String.Format(Mensagens.PROCURAR_FALHA, "Tamanho"));
            else
                base.Selecionar();
        }

        protected override void Procurar(string Nome, bool Parcial)
        {
            List<M_Tamanho> lstLista;
            N_Tamanho ntmnhNegocio = new N_Tamanho();

            try
            {
                lstLista = ntmnhNegocio.Selecionar(Nome, Parcial);

                if (lstLista != null)
                    dtgrdvwProcura.DataSource = lstLista;
                else
                    MessageBox.Show(ntmnhNegocio.Mensagem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Mensagens.PROCURAR_FALHA + Ex.Message);
            }
        }
    }
}


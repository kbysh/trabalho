using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetods
{
    public partial class frmcontareceber : Form
    {
        private void Habilita()
        {
            sd_contaTextBox.Enabled = false;
            ds_contaTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            bntAnterior.Enabled = false;
            bntProximo.Enabled = false;
            bntNovo.Enabled = false;
            bntExcluir.Enabled = false;
            bntSalvar.Enabled = true;
            bntCancelar.Enabled = true;
            bntPesquisar.Enabled = false;
            bntImprimir.Enabled = false;
            bntSair.Enabled = false;

        }
        private void Desabilita()
        {
            sd_contaTextBox.Enabled = true;
            ds_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            bntAnterior.Enabled = true;
            bntProximo.Enabled = true;
            bntNovo.Enabled = true;
            bntExcluir.Enabled = true;
            bntSalvar.Enabled = false;
            bntCancelar.Enabled = false;
            bntPesquisar.Enabled = true;
            bntImprimir.Enabled = true;
            bntSair.Enabled = true;
        }
            public frmcontareceber()
        {
            InitializeComponent();
        }

        private void TbcontareceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbcontareceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void Frmcontareceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbcontareceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbcontareceberTableAdapter.Fill(this.cadastroDataSet.tbcontareceber);

        }

        private void BntAnterior_Click(object sender, EventArgs e)
        {
            
        }

        private void BntAnterior_Click_1(object sender, EventArgs e)
        {
            tbcontareceberBindingSource.MovePrevious();
        }

        private void BntNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbcontareceberBindingSource.AddNew();
        }

        private void BntExcluir_Click(object sender, EventArgs e)
        {
            tbcontareceberBindingSource.RemoveCurrent();
            tbcontareceberTableAdapter.Update(cadastroDataSet.tbcontareceber);
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void BntSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbcontareceberBindingSource.EndEdit();
            tbcontareceberTableAdapter.Update(cadastroDataSet.tbcontareceber);
        }

        private void BntAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BntProximo_Click(object sender, EventArgs e)
        {
            tbcontareceberBindingSource.MoveNext();
        }

        private void BntSair_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}

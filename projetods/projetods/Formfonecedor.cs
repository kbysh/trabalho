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
    public partial class Formfonecedor : Form
    {
        private void Habilita()
        {
            _cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
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
            _cd_fornecedorTextBox.Enabled = true;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
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
        public Formfonecedor()
        {
            InitializeComponent();
        }

        private void Formfonecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.cadastroDataSet.Tb_fornecedor);
        }

        private void Tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
        
        }

        private void _cd_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void _cd_fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ds_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Ds_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_bairroLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_bairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sg_estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Sg_estadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cepLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_cepTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cnpjLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_cnpjTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_ieLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_ieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntAnterior_Click(object sender, EventArgs e)
        {
           
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void BntPróximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void BntNovo_Click(object sender, EventArgs e)
        {
           
            tb_fornecedorBindingSource.AddNew();
        }

        private void BntExcluir_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(cadastroDataSet.Tb_fornecedor);
        }

        private void BntAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BntSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_fornecedorBindingSource.EndEdit();
            tb_fornecedorTableAdapter.Update(cadastroDataSet.Tb_fornecedor);
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }
    }
}

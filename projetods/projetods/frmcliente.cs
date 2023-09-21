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
    public partial class frmcliente : Form
    {
        private void Habilita()
        {
            cd_cliesteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
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
            cd_cliesteTextBox.Enabled = true;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
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
        public frmcliente()

        {
            InitializeComponent();
        }

        private void TbclienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbclienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void Frmcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbclienteTableAdapter.Fill(this.cadastroDataSet.tbcliente);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveNext();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.AddNew( );       }

        private void BntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntAnterior_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MovePrevious();
        }

        private void BntExcluir_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.RemoveCurrent();
            tbclienteTableAdapter.Update(cadastroDataSet.tbcliente);
           
        }

        private void Nm_cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_cliesteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BntSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbclienteBindingSource.EndEdit();
            tbclienteTableAdapter.Update(cadastroDataSet.tbcliente);
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }
    }
}

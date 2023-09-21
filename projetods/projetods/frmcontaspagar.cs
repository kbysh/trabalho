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
    public partial class frmcontaspagar : Form
    {
        private void Habilita()
        {
            cd_contaTextBox.Enabled = false;
            ds_contaTextBox.Enabled = true;
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
            cd_contaTextBox.Enabled = true;
            ds_contaTextBox.Enabled = false;
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
        public frmcontaspagar()
        {
            InitializeComponent();
        }

        private void TbcontaspagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbcontaspagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void Frmcontaspagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbcontaspagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbcontaspagarTableAdapter.Fill(this.cadastroDataSet.tbcontaspagar);

        }

        private void TbcontaspagarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BntAnterior_Click(object sender, EventArgs e)
        {
            tbcontaspagarBindingSource.MovePrevious();
        }

        private void BntNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbcontaspagarBindingSource.AddNew();
        }

        private void BntExcluir_Click(object sender, EventArgs e)
        {
            tbcontaspagarBindingSource.RemoveCurrent();
            tbcontaspagarTableAdapter.Update(cadastroDataSet.tbcontaspagar);

        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void BntSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbcontaspagarBindingSource.EndEdit();
            tbcontaspagarTableAdapter.Update(cadastroDataSet.tbcontaspagar);
        }

        private void BntAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void BntProximo_Click(object sender, EventArgs e)
        {
            tbcontaspagarBindingSource.MoveNext();
        }

        private void BntSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

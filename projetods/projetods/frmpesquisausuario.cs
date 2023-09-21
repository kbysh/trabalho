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
    public partial class frmpesquisausuario : Form
    {
        private int codigo;

        public int getCodigo() {
            return codigo;
        }
        public frmpesquisausuario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.Tbusuario);
            }
            else
            {
                this.tbusuarioTableAdapter.FillByNome(this.cadastroDataSet.Tbusuario, "%" + txtNome.Text + "%");
            }
        }

        private void TbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void TbusuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void Frmpesquisausuario_Load(object sender, EventArgs e)
        {   
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.Tbusuario);

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void TbusuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbusuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

    }
}

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
    public partial class frmUsuario : Form
    {
        private void Habilita()
        {
            _cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            bntAnterior.Enabled = false;
            bntProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            bntPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;

        }
        private void Desabilita()
        {
            _cd_usuarioTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            bntAnterior.Enabled = true;
            bntProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            bntPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
            public frmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.Tbusuario);
            Desabilita();
        }


        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void _cd_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void TbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void _cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void _cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sg_nivelLabel_Click(object sender, EventArgs e)
        {

        }

        private void Sg_nivelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            frmpesquisausuario fpu = new frmpesquisausuario();
            fpu.ShowDialog();
            int cod = fpu.getCodigo();
            if (cod > 0)
            {
                int reg = tbusuarioBindingSource.Find("cd_usuario", cod);
                tbusuarioBindingSource.Position = reg;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void BntAnterior_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MovePrevious();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbusuarioBindingSource.AddNew();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.RemoveCurrent();
            tbusuarioTableAdapter.Update(cadastroDataSet.Tbusuario);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbusuarioBindingSource.EndEdit();
            tbusuarioTableAdapter.Update(cadastroDataSet.Tbusuario);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }
    }
}

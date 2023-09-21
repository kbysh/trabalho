namespace projetods
{
    partial class frmcontaspagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_contaLabel;
            System.Windows.Forms.Label ds_contaLabel;
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.tbcontaspagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new projetods.CadastroDataSet();
            this.ds_contaTextBox = new System.Windows.Forms.TextBox();
            this.bntAnterior = new System.Windows.Forms.Button();
            this.bntProximo = new System.Windows.Forms.Button();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.bntImprimir = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.tbcontaspagarTableAdapter = new projetods.CadastroDataSetTableAdapters.tbcontaspagarTableAdapter();
            this.tableAdapterManager = new projetods.CadastroDataSetTableAdapters.TableAdapterManager();
            cd_contaLabel = new System.Windows.Forms.Label();
            ds_contaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontaspagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_contaLabel.Location = new System.Drawing.Point(46, 46);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(74, 20);
            cd_contaLabel.TabIndex = 1;
            cd_contaLabel.Text = "cd conta:";
            // 
            // ds_contaLabel
            // 
            ds_contaLabel.AutoSize = true;
            ds_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_contaLabel.Location = new System.Drawing.Point(46, 106);
            ds_contaLabel.Name = "ds_contaLabel";
            ds_contaLabel.Size = new System.Drawing.Size(74, 20);
            ds_contaLabel.TabIndex = 3;
            ds_contaLabel.Text = "ds conta:";
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontaspagarBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_contaTextBox.Location = new System.Drawing.Point(138, 43);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(316, 26);
            this.cd_contaTextBox.TabIndex = 2;
            // 
            // tbcontaspagarBindingSource
            // 
            this.tbcontaspagarBindingSource.DataMember = "tbcontaspagar";
            this.tbcontaspagarBindingSource.DataSource = this.cadastroDataSet;
            this.tbcontaspagarBindingSource.CurrentChanged += new System.EventHandler(this.TbcontaspagarBindingSource_CurrentChanged);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_contaTextBox
            // 
            this.ds_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontaspagarBindingSource, "ds_conta", true));
            this.ds_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_contaTextBox.Location = new System.Drawing.Point(138, 103);
            this.ds_contaTextBox.Name = "ds_contaTextBox";
            this.ds_contaTextBox.Size = new System.Drawing.Size(316, 26);
            this.ds_contaTextBox.TabIndex = 4;
            // 
            // bntAnterior
            // 
            this.bntAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAnterior.Location = new System.Drawing.Point(23, 327);
            this.bntAnterior.Name = "bntAnterior";
            this.bntAnterior.Size = new System.Drawing.Size(108, 38);
            this.bntAnterior.TabIndex = 5;
            this.bntAnterior.Text = "Anterior";
            this.bntAnterior.UseVisualStyleBackColor = true;
            this.bntAnterior.Click += new System.EventHandler(this.BntAnterior_Click);
            // 
            // bntProximo
            // 
            this.bntProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntProximo.Location = new System.Drawing.Point(191, 327);
            this.bntProximo.Name = "bntProximo";
            this.bntProximo.Size = new System.Drawing.Size(108, 38);
            this.bntProximo.TabIndex = 6;
            this.bntProximo.Text = "Próximo";
            this.bntProximo.UseVisualStyleBackColor = true;
            this.bntProximo.Click += new System.EventHandler(this.BntProximo_Click);
            // 
            // bntNovo
            // 
            this.bntNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNovo.Location = new System.Drawing.Point(346, 327);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(108, 38);
            this.bntNovo.TabIndex = 7;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.BntNovo_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAlterar.Location = new System.Drawing.Point(501, 327);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(108, 38);
            this.bntAlterar.TabIndex = 8;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.BntAlterar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.Location = new System.Drawing.Point(662, 327);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(108, 38);
            this.bntExcluir.TabIndex = 9;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.BntExcluir_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvar.Location = new System.Drawing.Point(23, 390);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(108, 38);
            this.bntSalvar.TabIndex = 10;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.BntSalvar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(191, 390);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(108, 38);
            this.bntCancelar.TabIndex = 11;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquisar.Location = new System.Drawing.Point(346, 390);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(108, 38);
            this.bntPesquisar.TabIndex = 12;
            this.bntPesquisar.Text = "Pesquisar";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            // 
            // bntImprimir
            // 
            this.bntImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImprimir.Location = new System.Drawing.Point(501, 390);
            this.bntImprimir.Name = "bntImprimir";
            this.bntImprimir.Size = new System.Drawing.Size(108, 38);
            this.bntImprimir.TabIndex = 13;
            this.bntImprimir.Text = "Imprimir";
            this.bntImprimir.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(662, 390);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(108, 38);
            this.bntSair.TabIndex = 14;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.BntSair_Click);
            // 
            // tbcontaspagarTableAdapter
            // 
            this.tbcontaspagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tbclienteTableAdapter = null;
            this.tableAdapterManager.tbcontareceberTableAdapter = null;
            this.tableAdapterManager.tbcontaspagarTableAdapter = this.tbcontaspagarTableAdapter;
            this.tableAdapterManager.TbusuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projetods.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmcontaspagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntImprimir);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntAlterar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.bntProximo);
            this.Controls.Add(this.bntAnterior);
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(ds_contaLabel);
            this.Controls.Add(this.ds_contaTextBox);
            this.Name = "frmcontaspagar";
            this.Text = "Contas a pagar";
            this.Load += new System.EventHandler(this.Frmcontaspagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbcontaspagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbcontaspagarBindingSource;
        private CadastroDataSetTableAdapters.tbcontaspagarTableAdapter tbcontaspagarTableAdapter;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.TextBox ds_contaTextBox;
        private System.Windows.Forms.Button bntAnterior;
        private System.Windows.Forms.Button bntProximo;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.Button bntImprimir;
        private System.Windows.Forms.Button bntSair;
    }
}
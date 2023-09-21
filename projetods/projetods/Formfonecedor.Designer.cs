namespace projetods
{
    partial class Formfonecedor
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
            System.Windows.Forms.Label _cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            this.cadastroDataSet = new projetods.CadastroDataSet();
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorTableAdapter = new projetods.CadastroDataSetTableAdapters.Tb_fornecedorTableAdapter();
            this._cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.cd_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.cd_ieTextBox = new System.Windows.Forms.TextBox();
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
            _cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _cd_fornecedorLabel
            // 
            _cd_fornecedorLabel.AutoSize = true;
            _cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _cd_fornecedorLabel.Location = new System.Drawing.Point(25, 29);
            _cd_fornecedorLabel.Name = "_cd_fornecedorLabel";
            _cd_fornecedorLabel.Size = new System.Drawing.Size(59, 20);
            _cd_fornecedorLabel.TabIndex = 1;
            _cd_fornecedorLabel.Text = "Código";
            _cd_fornecedorLabel.Click += new System.EventHandler(this._cd_fornecedorLabel_Click);
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(25, 91);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(51, 20);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome";
            nm_fornecedorLabel.Click += new System.EventHandler(this.Nm_fornecedorLabel_Click);
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Location = new System.Drawing.Point(27, 146);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(78, 20);
            ds_enderecoLabel.TabIndex = 5;
            ds_enderecoLabel.Text = "Endereço";
            ds_enderecoLabel.Click += new System.EventHandler(this.Ds_enderecoLabel_Click);
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(34, 203);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(51, 20);
            nm_bairroLabel.TabIndex = 7;
            nm_bairroLabel.Text = "Bairro";
            nm_bairroLabel.Click += new System.EventHandler(this.Nm_bairroLabel_Click);
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(27, 258);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(59, 20);
            nm_cidadeLabel.TabIndex = 9;
            nm_cidadeLabel.Text = "Cidade";
            nm_cidadeLabel.Click += new System.EventHandler(this.Nm_cidadeLabel_Click);
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(433, 26);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(60, 20);
            sg_estadoLabel.TabIndex = 11;
            sg_estadoLabel.Text = "Estado";
            sg_estadoLabel.Click += new System.EventHandler(this.Sg_estadoLabel_Click);
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(433, 88);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(38, 20);
            cd_cepLabel.TabIndex = 13;
            cd_cepLabel.Text = "Cep";
            cd_cepLabel.Click += new System.EventHandler(this.Cd_cepLabel_Click);
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.Location = new System.Drawing.Point(433, 146);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(49, 20);
            cd_cnpjLabel.TabIndex = 15;
            cd_cnpjLabel.Text = "CNPJ";
            cd_cnpjLabel.Click += new System.EventHandler(this.Cd_cnpjLabel_Click);
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ieLabel.Location = new System.Drawing.Point(447, 200);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(21, 20);
            cd_ieLabel.TabIndex = 17;
            cd_ieLabel.Text = "ie";
            cd_ieLabel.Click += new System.EventHandler(this.Cd_ieLabel_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "Tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // _cd_fornecedorTextBox
            // 
            this._cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, " cd_fornecedor", true));
            this._cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cd_fornecedorTextBox.Location = new System.Drawing.Point(90, 26);
            this._cd_fornecedorTextBox.Name = "_cd_fornecedorTextBox";
            this._cd_fornecedorTextBox.Size = new System.Drawing.Size(157, 26);
            this._cd_fornecedorTextBox.TabIndex = 2;
            this._cd_fornecedorTextBox.TextChanged += new System.EventHandler(this._cd_fornecedorTextBox_TextChanged);
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(90, 88);
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(157, 26);
            this.nm_fornecedorTextBox.TabIndex = 4;
            this.nm_fornecedorTextBox.TextChanged += new System.EventHandler(this.Nm_fornecedorTextBox_TextChanged);
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(105, 146);
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(142, 26);
            this.ds_enderecoTextBox.TabIndex = 6;
            this.ds_enderecoTextBox.TextChanged += new System.EventHandler(this.Ds_enderecoTextBox_TextChanged);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(91, 200);
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(156, 26);
            this.nm_bairroTextBox.TabIndex = 8;
            this.nm_bairroTextBox.TextChanged += new System.EventHandler(this.Nm_bairroTextBox_TextChanged);
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(90, 258);
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(157, 26);
            this.nm_cidadeTextBox.TabIndex = 10;
            this.nm_cidadeTextBox.TextChanged += new System.EventHandler(this.Nm_cidadeTextBox_TextChanged);
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(477, 85);
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(160, 26);
            this.sg_estadoTextBox.TabIndex = 12;
            this.sg_estadoTextBox.TextChanged += new System.EventHandler(this.Sg_estadoTextBox_TextChanged);
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepTextBox.Location = new System.Drawing.Point(499, 23);
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(138, 26);
            this.cd_cepTextBox.TabIndex = 14;
            this.cd_cepTextBox.TextChanged += new System.EventHandler(this.Cd_cepTextBox_TextChanged);
            // 
            // cd_cnpjTextBox
            // 
            this.cd_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cnpjTextBox.Location = new System.Drawing.Point(488, 140);
            this.cd_cnpjTextBox.Name = "cd_cnpjTextBox";
            this.cd_cnpjTextBox.Size = new System.Drawing.Size(149, 26);
            this.cd_cnpjTextBox.TabIndex = 16;
            this.cd_cnpjTextBox.TextChanged += new System.EventHandler(this.Cd_cnpjTextBox_TextChanged);
            // 
            // cd_ieTextBox
            // 
            this.cd_ieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_ie", true));
            this.cd_ieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_ieTextBox.Location = new System.Drawing.Point(474, 194);
            this.cd_ieTextBox.Name = "cd_ieTextBox";
            this.cd_ieTextBox.Size = new System.Drawing.Size(163, 26);
            this.cd_ieTextBox.TabIndex = 18;
            this.cd_ieTextBox.TextChanged += new System.EventHandler(this.Cd_ieTextBox_TextChanged);
            // 
            // bntAnterior
            // 
            this.bntAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAnterior.Location = new System.Drawing.Point(29, 331);
            this.bntAnterior.Name = "bntAnterior";
            this.bntAnterior.Size = new System.Drawing.Size(99, 37);
            this.bntAnterior.TabIndex = 19;
            this.bntAnterior.Text = "Anterior";
            this.bntAnterior.UseVisualStyleBackColor = true;
            this.bntAnterior.Click += new System.EventHandler(this.BntAnterior_Click);
            // 
            // bntProximo
            // 
            this.bntProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntProximo.Location = new System.Drawing.Point(175, 331);
            this.bntProximo.Name = "bntProximo";
            this.bntProximo.Size = new System.Drawing.Size(99, 37);
            this.bntProximo.TabIndex = 20;
            this.bntProximo.Text = "Próximo";
            this.bntProximo.UseVisualStyleBackColor = true;
            this.bntProximo.Click += new System.EventHandler(this.BntPróximo_Click);
            // 
            // bntNovo
            // 
            this.bntNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNovo.Location = new System.Drawing.Point(328, 331);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(99, 37);
            this.bntNovo.TabIndex = 21;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.BntNovo_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAlterar.Location = new System.Drawing.Point(495, 331);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(99, 37);
            this.bntAlterar.TabIndex = 22;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.BntAlterar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.Location = new System.Drawing.Point(637, 331);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(99, 37);
            this.bntExcluir.TabIndex = 23;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.BntExcluir_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalvar.Location = new System.Drawing.Point(29, 401);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(99, 37);
            this.bntSalvar.TabIndex = 24;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.BntSalvar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(175, 401);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(99, 37);
            this.bntCancelar.TabIndex = 25;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquisar.Location = new System.Drawing.Point(328, 401);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(99, 37);
            this.bntPesquisar.TabIndex = 26;
            this.bntPesquisar.Text = "Pesquisar";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            // 
            // bntImprimir
            // 
            this.bntImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImprimir.Location = new System.Drawing.Point(495, 401);
            this.bntImprimir.Name = "bntImprimir";
            this.bntImprimir.Size = new System.Drawing.Size(99, 37);
            this.bntImprimir.TabIndex = 27;
            this.bntImprimir.Text = "Imprimir";
            this.bntImprimir.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(637, 401);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(99, 37);
            this.bntSair.TabIndex = 28;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.BntSair_Click);
            // 
            // Formfonecedor
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
            this.Controls.Add(_cd_fornecedorLabel);
            this.Controls.Add(this._cd_fornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.cd_cnpjTextBox);
            this.Controls.Add(cd_ieLabel);
            this.Controls.Add(this.cd_ieTextBox);
            this.Name = "Formfonecedor";
            this.Text = "Formfonecedor";
            this.Load += new System.EventHandler(this.Formfonecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private CadastroDataSetTableAdapters.Tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private System.Windows.Forms.TextBox _cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox cd_cnpjTextBox;
        private System.Windows.Forms.TextBox cd_ieTextBox;
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
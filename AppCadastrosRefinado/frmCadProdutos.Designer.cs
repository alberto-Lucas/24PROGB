namespace AppCadastros
{
    partial class frmCadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUN = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrateleira = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 23);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(244, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(290, 23);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(130, 20);
            this.txtCodBarras.TabIndex = 1;
            this.txtCodBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodBarras_KeyDown);
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            this.txtCodBarras.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodBarras_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UN";
            // 
            // cboUN
            // 
            this.cboUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUN.FormattingEnabled = true;
            this.cboUN.Items.AddRange(new object[] {
            "UN",
            "PC",
            "ML",
            "KG",
            "LT"});
            this.cboUN.Location = new System.Drawing.Point(12, 70);
            this.cboUN.Name = "cboUN";
            this.cboUN.Size = new System.Drawing.Size(72, 21);
            this.cboUN.TabIndex = 3;
            this.cboUN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboUN_KeyDown);
            this.cboUN.Validating += new System.ComponentModel.CancelEventHandler(this.cboUN_Validating);
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "CONGELADOS",
            "FARINHA",
            "BEBIDAS",
            "IORGUTES"});
            this.cboGrupo.Location = new System.Drawing.Point(113, 70);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(102, 21);
            this.cboGrupo.TabIndex = 4;
            this.cboGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboGrupo_KeyDown);
            this.cboGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.cboGrupo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grupo";
            // 
            // txtPrateleira
            // 
            this.txtPrateleira.Location = new System.Drawing.Point(246, 71);
            this.txtPrateleira.Name = "txtPrateleira";
            this.txtPrateleira.Size = new System.Drawing.Size(61, 20);
            this.txtPrateleira.TabIndex = 5;
            this.txtPrateleira.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrateleira_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prateleira";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(338, 71);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(82, 20);
            this.txtPrecoVenda.TabIndex = 6;
            this.txtPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyDown);
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoVenda_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Preço Venda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(276, 121);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 156);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrateleira);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboUN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrateleira;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
    }
}
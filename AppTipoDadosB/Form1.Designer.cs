namespace AppTipoDadosB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ckbBebe = new System.Windows.Forms.CheckBox();
            this.btnProcessarBebida = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.ckbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Processar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe a sua idade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // ckbBebe
            // 
            this.ckbBebe.AutoSize = true;
            this.ckbBebe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbBebe.Location = new System.Drawing.Point(21, 96);
            this.ckbBebe.Name = "ckbBebe";
            this.ckbBebe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbBebe.Size = new System.Drawing.Size(72, 17);
            this.ckbBebe.TabIndex = 4;
            this.ckbBebe.Text = "?Vc bebe";
            this.ckbBebe.UseVisualStyleBackColor = true;
            // 
            // btnProcessarBebida
            // 
            this.btnProcessarBebida.Location = new System.Drawing.Point(26, 119);
            this.btnProcessarBebida.Name = "btnProcessarBebida";
            this.btnProcessarBebida.Size = new System.Drawing.Size(75, 23);
            this.btnProcessarBebida.TabIndex = 5;
            this.btnProcessarBebida.Text = "Processar";
            this.btnProcessarBebida.UseVisualStyleBackColor = true;
            this.btnProcessarBebida.Click += new System.EventHandler(this.btnProcessarBebida_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(239, 42);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.Text = "123";
            this.txtLogin.UseSystemPasswordChar = true;
            // 
            // ckbMostrarSenha
            // 
            this.ckbMostrarSenha.AutoSize = true;
            this.ckbMostrarSenha.Location = new System.Drawing.Point(246, 68);
            this.ckbMostrarSenha.Name = "ckbMostrarSenha";
            this.ckbMostrarSenha.Size = new System.Drawing.Size(95, 17);
            this.ckbMostrarSenha.TabIndex = 7;
            this.ckbMostrarSenha.Text = "Mostrar Senha";
            this.ckbMostrarSenha.UseVisualStyleBackColor = true;
            this.ckbMostrarSenha.CheckedChanged += new System.EventHandler(this.ckbMostrarSenha_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(239, 91);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(239, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 284);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.ckbMostrarSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnProcessarBebida);
            this.Controls.Add(this.ckbBebe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckbBebe;
        private System.Windows.Forms.Button btnProcessarBebida;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.CheckBox ckbMostrarSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}


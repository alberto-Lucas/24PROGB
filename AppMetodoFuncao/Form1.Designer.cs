namespace AppMetodoFuncao
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
            this.cbxOpcao = new System.Windows.Forms.ComboBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFuncao = new System.Windows.Forms.Button();
            this.btnMetodo = new System.Windows.Forms.Button();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.lstFor = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxOpcao
            // 
            this.cbxOpcao.FormattingEnabled = true;
            this.cbxOpcao.Items.AddRange(new object[] {
            "GOL",
            "UP",
            "ONIX",
            "FUSCA",
            "MOBI",
            "UNO",
            "CRETA",
            "OMEGA",
            "CHEVETTE",
            "MAREA"});
            this.cbxOpcao.Location = new System.Drawing.Point(12, 12);
            this.cbxOpcao.Name = "cbxOpcao";
            this.cbxOpcao.Size = new System.Drawing.Size(121, 21);
            this.cbxOpcao.TabIndex = 0;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(12, 39);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(75, 23);
            this.btnIF.TabIndex = 1;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 68);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "SWITCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor1";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(12, 132);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 20);
            this.txtV1.TabIndex = 4;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(12, 178);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 20);
            this.txtV2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor2";
            // 
            // btnFuncao
            // 
            this.btnFuncao.Location = new System.Drawing.Point(12, 233);
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnFuncao.TabIndex = 8;
            this.btnFuncao.Text = "FUNCAO";
            this.btnFuncao.UseVisualStyleBackColor = true;
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // btnMetodo
            // 
            this.btnMetodo.Location = new System.Drawing.Point(12, 204);
            this.btnMetodo.Name = "btnMetodo";
            this.btnMetodo.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo.TabIndex = 7;
            this.btnMetodo.Text = "METODO";
            this.btnMetodo.UseVisualStyleBackColor = true;
            this.btnMetodo.Click += new System.EventHandler(this.btnMetodo_Click);
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(118, 132);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(100, 20);
            this.txtOperador.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Operador";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(118, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(118, 186);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 12;
            this.btnSomar.Text = "SOMAR";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(118, 215);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 13;
            this.btnTeste.Text = "TESTE";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // lstFor
            // 
            this.lstFor.FormattingEnabled = true;
            this.lstFor.Location = new System.Drawing.Point(236, 7);
            this.lstFor.Name = "lstFor";
            this.lstFor.Size = new System.Drawing.Size(120, 173);
            this.lstFor.TabIndex = 14;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(236, 186);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 15;
            this.btnFor.Text = "FOR";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(236, 215);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 16;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(236, 244);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 17;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "O Lucas é Melhor Proessor?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "SIM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(438, 78);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 20;
            this.btnNao.Text = "NÃO";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 290);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lstFor);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFuncao);
            this.Controls.Add(this.btnMetodo);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.cbxOpcao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOpcao;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFuncao;
        private System.Windows.Forms.Button btnMetodo;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.ListBox lstFor;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNao;
    }
}


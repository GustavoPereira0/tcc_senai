namespace Tcc_senai
{
    partial class cadastrodesign
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
			this.btneditar = new System.Windows.Forms.Button();
			this.btnexcluir = new System.Windows.Forms.Button();
			this.btncadastrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtcpf = new System.Windows.Forms.TextBox();
			this.btnfechar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btneditar
			// 
			this.btneditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btneditar.Location = new System.Drawing.Point(378, 106);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(130, 81);
			this.btneditar.TabIndex = 1;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = false;
			this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
			// 
			// btnexcluir
			// 
			this.btnexcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnexcluir.Location = new System.Drawing.Point(378, 201);
			this.btnexcluir.Name = "btnexcluir";
			this.btnexcluir.Size = new System.Drawing.Size(130, 81);
			this.btnexcluir.TabIndex = 2;
			this.btnexcluir.Text = "Excluir";
			this.btnexcluir.UseVisualStyleBackColor = false;
			this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
			// 
			// btncadastrar
			// 
			this.btncadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncadastrar.Location = new System.Drawing.Point(378, 12);
			this.btncadastrar.Name = "btncadastrar";
			this.btncadastrar.Size = new System.Drawing.Size(130, 81);
			this.btncadastrar.TabIndex = 3;
			this.btncadastrar.Text = "Cadastrar";
			this.btncadastrar.UseVisualStyleBackColor = false;
			this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Email:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Cpf(apenas numeros):";
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(16, 50);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(295, 20);
			this.txtnome.TabIndex = 7;
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(16, 137);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(295, 20);
			this.txtemail.TabIndex = 8;
			// 
			// txtcpf
			// 
			this.txtcpf.Location = new System.Drawing.Point(16, 224);
			this.txtcpf.Name = "txtcpf";
			this.txtcpf.Size = new System.Drawing.Size(295, 20);
			this.txtcpf.TabIndex = 9;
			// 
			// btnfechar
			// 
			this.btnfechar.BackColor = System.Drawing.Color.Red;
			this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnfechar.Location = new System.Drawing.Point(410, 310);
			this.btnfechar.Name = "btnfechar";
			this.btnfechar.Size = new System.Drawing.Size(98, 46);
			this.btnfechar.TabIndex = 10;
			this.btnfechar.Text = "fechar";
			this.btnfechar.UseVisualStyleBackColor = false;
			this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Senha: ";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(16, 304);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(295, 20);
			this.txtSenha.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 327);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Ja possui uma conta?";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkBlue;
			this.label7.Location = new System.Drawing.Point(119, 324);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Entrar";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// cadastrodesign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 391);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnfechar);
			this.Controls.Add(this.txtcpf);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btncadastrar);
			this.Controls.Add(this.btnexcluir);
			this.Controls.Add(this.btneditar);
			this.Name = "cadastrodesign";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.cadastrodesign_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Button btnfechar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
	}
}


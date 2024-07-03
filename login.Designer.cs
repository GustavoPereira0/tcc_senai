namespace Tcc_senai
{
	partial class login
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
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnfechar = new System.Windows.Forms.Button();
			this.txtcpf = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnlogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(16, 297);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(295, 20);
			this.txtSenha.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 274);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 23;
			this.label4.Text = "Senha: ";
			// 
			// btnfechar
			// 
			this.btnfechar.BackColor = System.Drawing.Color.Red;
			this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnfechar.Location = new System.Drawing.Point(377, 265);
			this.btnfechar.Name = "btnfechar";
			this.btnfechar.Size = new System.Drawing.Size(90, 52);
			this.btnfechar.TabIndex = 22;
			this.btnfechar.Text = "Voltar";
			this.btnfechar.UseVisualStyleBackColor = false;
			this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
			// 
			// txtcpf
			// 
			this.txtcpf.Location = new System.Drawing.Point(16, 217);
			this.txtcpf.Name = "txtcpf";
			this.txtcpf.Size = new System.Drawing.Size(295, 20);
			this.txtcpf.TabIndex = 21;
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(16, 130);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(295, 20);
			this.txtemail.TabIndex = 20;
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(16, 43);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(295, 20);
			this.txtnome.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Cpf(apenas numeros):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Email:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "Nome:";
			// 
			// btnlogin
			// 
			this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogin.Location = new System.Drawing.Point(364, 12);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(130, 81);
			this.btnlogin.TabIndex = 15;
			this.btnlogin.Text = "Entrar";
			this.btnlogin.UseVisualStyleBackColor = false;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 366);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnfechar);
			this.Controls.Add(this.txtcpf);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnlogin);
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnfechar;
		private System.Windows.Forms.TextBox txtcpf;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnlogin;
	}
}
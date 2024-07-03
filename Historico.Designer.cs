namespace Tcc_senai
{
	partial class Historico
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
            this.cbxmes = new System.Windows.Forms.ComboBox();
            this.dgvhistorico = new System.Windows.Forms.DataGridView();
            this.lblselecionarhistorico = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxmes
            // 
            this.cbxmes.FormattingEnabled = true;
            this.cbxmes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbxmes.Location = new System.Drawing.Point(56, 35);
            this.cbxmes.Name = "cbxmes";
            this.cbxmes.Size = new System.Drawing.Size(178, 21);
            this.cbxmes.TabIndex = 0;
            this.cbxmes.SelectedIndexChanged += new System.EventHandler(this.cbxmes_SelectedIndexChanged_1);
            // 
            // dgvhistorico
            // 
            this.dgvhistorico.AllowUserToAddRows = false;
            this.dgvhistorico.AllowUserToDeleteRows = false;
            this.dgvhistorico.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvhistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhistorico.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvhistorico.Location = new System.Drawing.Point(56, 90);
            this.dgvhistorico.Name = "dgvhistorico";
            this.dgvhistorico.ReadOnly = true;
            this.dgvhistorico.Size = new System.Drawing.Size(359, 327);
            this.dgvhistorico.TabIndex = 1;
            this.dgvhistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhistorico_CellContentClick);
            // 
            // lblselecionarhistorico
            // 
            this.lblselecionarhistorico.AutoSize = true;
            this.lblselecionarhistorico.Location = new System.Drawing.Point(53, 9);
            this.lblselecionarhistorico.Name = "lblselecionarhistorico";
            this.lblselecionarhistorico.Size = new System.Drawing.Size(99, 13);
            this.lblselecionarhistorico.TabIndex = 2;
            this.lblselecionarhistorico.Text = "Selecionar histórico";
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.Red;
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfechar.Location = new System.Drawing.Point(810, 9);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(111, 58);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.lblselecionarhistorico);
            this.Controls.Add(this.dgvhistorico);
            this.Controls.Add(this.cbxmes);
            this.Name = "Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxmes;
		private System.Windows.Forms.DataGridView dgvhistorico;
		private System.Windows.Forms.Label lblselecionarhistorico;
		private System.Windows.Forms.Button btnfechar;
    }
}
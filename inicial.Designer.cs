namespace Tcc_senai
{
    partial class inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicial));
            this.btncadastro = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadastro
            // 
            this.btncadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastro.Location = new System.Drawing.Point(12, 187);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(130, 81);
            this.btncadastro.TabIndex = 4;
            this.btncadastro.Text = "Cadastro";
            this.btncadastro.UseVisualStyleBackColor = false;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.Location = new System.Drawing.Point(355, 187);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(130, 81);
            this.btnentrar.TabIndex = 5;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 283);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.btncadastro);
            this.Name = "inicial";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Button btnentrar;
    }
}
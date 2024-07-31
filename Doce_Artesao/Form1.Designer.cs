namespace Doce_Artesao
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnsave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.Location = new System.Drawing.Point(152, 75);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(115, 34);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "SALVAR";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NOME COMPLETO";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(15, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(252, 20);
            this.tbxName.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 759);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Doce Artesão";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
    }
}


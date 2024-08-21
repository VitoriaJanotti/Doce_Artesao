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
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.tbxPassworld = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightCoral;
            this.btnsave.Location = new System.Drawing.Point(890, 560);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(115, 47);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "SALVAR";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NOME DE USUARIO ";
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(11, 102);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(156, 23);
            this.tbxCode.TabIndex = 4;
            this.tbxCode.TextChanged += new System.EventHandler(this.tbxCode_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Sitka Banner", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(92, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(86, 35);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "LOGIN ";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("Sitka Banner", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto2.Location = new System.Drawing.Point(381, 31);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(262, 50);
            this.lblTexto2.TabIndex = 10;
            this.lblTexto2.Text = "DOCE ARTESÃO ";
            // 
            // tbxPassworld
            // 
            this.tbxPassworld.Location = new System.Drawing.Point(11, 166);
            this.tbxPassworld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPassworld.Name = "tbxPassworld";
            this.tbxPassworld.PasswordChar = '*';
            this.tbxPassworld.Size = new System.Drawing.Size(156, 23);
            this.tbxPassworld.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 19);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "SENHA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.tbxPassworld);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.tbxCode);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(390, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 237);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1048, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Doce Artesão";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox tbxPassworld;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}


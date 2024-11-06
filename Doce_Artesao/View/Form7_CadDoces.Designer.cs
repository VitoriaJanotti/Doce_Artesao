namespace Doce_Artesao.View
{
    partial class Form7_CadDoces
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txbPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName2 = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Doce_Artesao.Properties.Resources.Captura_de_tela_2024_08_27_144616;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1098, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.txbPassword2);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.btnCadastro);
            this.pnlLogin.Controls.Add(this.lblName);
            this.pnlLogin.Controls.Add(this.tbxName2);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(198, 140);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(723, 403);
            this.pnlLogin.TabIndex = 17;
            // 
            // txbPassword2
            // 
            this.txbPassword2.Location = new System.Drawing.Point(11, 163);
            this.txbPassword2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPassword2.Name = "txbPassword2";
            this.txbPassword2.PasswordChar = '*';
            this.txbPassword2.Size = new System.Drawing.Size(156, 20);
            this.txbPassword2.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 19);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "PREÇO";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.MistyRose;
            this.btnCadastro.Location = new System.Drawing.Point(11, 228);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(136, 24);
            this.btnCadastro.TabIndex = 17;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NOME DO DOCE";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // tbxName2
            // 
            this.tbxName2.Location = new System.Drawing.Point(11, 102);
            this.tbxName2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName2.Name = "tbxName2";
            this.tbxName2.Size = new System.Drawing.Size(256, 20);
            this.tbxName2.TabIndex = 4;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Sitka Banner", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(78, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(235, 35);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "CADASTRO DE DOCES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Doce_Artesao.Properties.Resources.BRIGADEIRO;
            this.pictureBox2.Location = new System.Drawing.Point(388, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 257);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form7_CadDoces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 642);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7_CadDoces";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txbPassword2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
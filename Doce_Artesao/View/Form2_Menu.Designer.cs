namespace Doce_Artesao
{
    partial class Form2_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Menu));
            this.btnView = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.btnMade = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(53, 304);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(230, 36);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "VIZUALIZAR ENCOMENDAS ";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrow.Location = new System.Drawing.Point(408, 303);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(230, 37);
            this.btnThrow.TabIndex = 1;
            this.btnThrow.Text = "LANÇAR ENCOMENDA ";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // btnMade
            // 
            this.btnMade.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMade.Location = new System.Drawing.Point(745, 303);
            this.btnMade.Name = "btnMade";
            this.btnMade.Size = new System.Drawing.Size(230, 37);
            this.btnMade.TabIndex = 2;
            this.btnMade.Text = "ENCOMENDAS REALIZADAS ";
            this.btnMade.UseVisualStyleBackColor = true;
            this.btnMade.Click += new System.EventHandler(this.btnMade_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Sitka Banner", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(479, 221);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(78, 35);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "MENU";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(408, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "VOLTAR";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptbMenu
            // 
            this.ptbMenu.Image = global::Doce_Artesao.Properties.Resources.Captura_de_tela_2024_08_27_144823;
            this.ptbMenu.Location = new System.Drawing.Point(-1, 0);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(1057, 642);
            this.ptbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMenu.TabIndex = 7;
            this.ptbMenu.TabStop = false;
            // 
            // Form2_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1055, 638);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnMade);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.ptbMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_Menu";
            this.Text = "Doce artesão ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Button btnMade;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox ptbMenu;
    }
}
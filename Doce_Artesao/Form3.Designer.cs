namespace Doce_Artesao
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnView = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.btnMade = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(38, 239);
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
            this.btnThrow.Location = new System.Drawing.Point(274, 237);
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
            this.btnMade.Location = new System.Drawing.Point(510, 238);
            this.btnMade.Name = "btnMade";
            this.btnMade.Size = new System.Drawing.Size(230, 37);
            this.btnMade.TabIndex = 2;
            this.btnMade.Text = "ENCOMENDAS REALIZADAS ";
            this.btnMade.UseVisualStyleBackColor = true;
            this.btnMade.Click += new System.EventHandler(this.btnMade_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(746, 239);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(229, 36);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "CADASTRAR PRODUTO ";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Sitka Banner", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(399, 61);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(262, 50);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "DOCE ARTESÃO ";
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Sitka Banner", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(474, 144);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(78, 35);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "MENU";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1055, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnMade);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Doce artesão ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Button btnMade;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button button1;
    }
}
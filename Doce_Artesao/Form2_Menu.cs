using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doce_Artesao
{
    public partial class Form2_Menu : Form
    {
        public Form2_Menu()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3_View tela = new Form3_View();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3_View tela = new Form3_View();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4_Encomenda tela = new Form4_Encomenda();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void btnMade_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5_Pedido tela = new Form5_Pedido();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

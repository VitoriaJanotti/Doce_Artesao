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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 tela = new Form4();

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
            Form4 tela = new Form4();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 tela = new Form5();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void btnMade_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 tela = new Form6();

            tela.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

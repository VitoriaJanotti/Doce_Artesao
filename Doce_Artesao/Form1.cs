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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbxCode.Text;
            MessageBox.Show("NOME: " + name);
            this.Visible = false;
            Form3 tela = new Form3();
           
            tela.ShowDialog();
            this.Visible = true;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tbxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

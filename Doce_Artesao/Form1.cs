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
            string name = tbxName.Text;
            MessageBox.Show("NOME: " + name);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

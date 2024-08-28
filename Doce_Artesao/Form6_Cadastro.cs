using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Doce_Artesao
{
    public partial class Form6_Cadastro : Form
    {
        public Form6_Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbxName2.Text;
            string code = tbxCode2.Text;
            string pass = txbPassword2.Text;
            string password = txbPassword3.Text;

            if (pass != password) 
            {
                MessageBox.Show("SENHA INCORRETA, ESCREVA NOVAMENTE!");
            }
           
            MessageBox.Show(
                "NOME DO VENDEDOR: " + name +
                "\nCÓDIGO DO VENDEDOR: " + code +
                "\nSENHA: " + password);
            this.Visible = false;
            Form2_Menu tela = new Form2_Menu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

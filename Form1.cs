using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSenha
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var log = textBox1.ToString();
            var sen = textBox2.ToString();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro newForm1 = new Cadastro();
            this.Hide();
            newForm1.ShowDialog();
   
        }
    }
}

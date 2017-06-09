using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.CSharp
{
    public partial class frquestão : Form
    {

        public int cont = 0;
        public frquestão()
        {
            InitializeComponent();
        }

        private void Tela1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void a1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void c3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void d2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont == 3)
            {
                MessageBox.Show("ola");


            }
            else
            {
                MessageBox.Show("erro");
                cont = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            cont += 1;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            cont += 1;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            cont += 1;
        }
    }
}

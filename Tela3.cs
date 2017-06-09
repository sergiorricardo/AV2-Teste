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
    public partial class frTeste : Form
    {

        public int cont = 0;
        public frTeste()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblteste2_Click(object sender, EventArgs e)
        {

        }

        private void Tela3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (cont==2)
                {
                    pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.acerto;
                    button1.Visible = false;
                }

            if (cont!=2)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.maisOuMenos;
                
                button1.Visible = false;
            }


        }

        private void rdt2b_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdt1d_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            cont += 1;
        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            cont += 1;
        }
    }
}

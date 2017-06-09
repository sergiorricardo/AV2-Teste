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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tela3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frTeste ts = new frTeste();
            ts.MdiParent = this;
            ts.Show();
            this.statusStrip1.Text = "To batendo nave ?";
        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frquestão tl1 = new frquestão();
            tl1.MdiParent = this;
            tl1.Show();
            this.statustrip1.Text = "Tela de Pergunta";
            
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frcalculo tl2 = new frcalculo();
            tl2.MdiParent = this;
            tl2.Show();
            this.statustrip1.Text = "Somando os Valores";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pegadinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela4 tl4 = new Tela4();
            tl4.MdiParent = this;
            tl4.Show();
            this.statustrip1.Text = "Pegadinha";

        }

        private void nomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nome mn = new Nome();
            mn.MdiParent = this;
            mn.Show();
            this.statustrip1.Text = "nome";
        }
    }
}

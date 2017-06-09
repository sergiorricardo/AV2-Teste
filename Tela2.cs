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
    public partial class frcalculo : Form
    {
        public frcalculo()
        {
            InitializeComponent();
           
        }

        private void Tela2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            int result = num + num2;
            txtresult.Text = Convert.ToString(result) ;

        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {    
             
        }
    }
}

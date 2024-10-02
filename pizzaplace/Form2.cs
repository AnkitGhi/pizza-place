using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaplace
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = Form1.one;
            label3.Text  = Form1.two;
            label4.Text = Form1.three;
            label5.Text = Form1.four;
            label6.Text = Form1.five;
            label7.Text += Form1.total_order; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

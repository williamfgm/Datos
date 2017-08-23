using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d1,d2,d3;
            d1 = float.Parse(textBox1.Text);
            d2 = float.Parse(textBox2.Text);
            d3 = float.Parse(textBox3.Text);
            
            float promedio =( d1 + d2 + d3) * (3) / 7;

            MessageBox.Show("su promedio en la semana es  :"+promedio);

        }
    }
}

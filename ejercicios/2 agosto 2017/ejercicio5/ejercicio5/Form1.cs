using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h = 0, m = 0;
           
            h = float.Parse(textBox1.Text);
            m = float.Parse(textBox2.Text);

            float suma = h + m;

            h =( h* 100) / suma;
            m =( m * 100)/ suma;

            MessageBox.Show("el porcentaje de hombre es"+h+"%");
            MessageBox.Show("el porcentaje de mujeres es" + m+"%");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio9
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
            float presion = 0, volumen=0, temperatura=0;

            presion = float.Parse(textBox1.Text);
            volumen = float.Parse(textBox2.Text);
            temperatura = float.Parse(textBox3.Text);

            float masa = (presion * volumen)/(0.37f*(temperatura+460));

            MessageBox.Show("la masa de air es"+masa);
        }
    }
}

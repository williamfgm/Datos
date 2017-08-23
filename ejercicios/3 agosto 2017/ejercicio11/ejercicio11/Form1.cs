using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salario;
            salario = float.Parse(textBox1.Text);
            float porcentaje= salario * 0.25f;

            float aumento = salario + porcentaje;
            MessageBox.Show("su salario ="+aumento);
        }
    }
}

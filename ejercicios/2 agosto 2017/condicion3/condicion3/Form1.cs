using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //3)	Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea
            //saber cuánto deberá pagar finalmente por su compra
            float valor,total=0;
            valor = float.Parse(textBox1.Text);

            total = valor-0.15f;
            MessageBox.Show("el valor de la compra es"+total);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicional2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //2)	Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas,
            //el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza
            //en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones


            float v1,v2,v3;

            v1 = float.Parse(textBox1.Text);
            v2 = float.Parse(textBox2.Text);
            v3 = float.Parse(textBox3.Text);

            float ventas = v1 + v2 + v3 + 75000;
            float sueldo = ventas * 1.011f;
            MessageBox.Show("su sueldo es"+sueldo);













        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

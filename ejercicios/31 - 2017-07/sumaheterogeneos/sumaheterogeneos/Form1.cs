using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumaheterogeneos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b ,c ,d ,resultado1, result,result2, resultado2, resultado3;
            if (textBox1.Text == "" || textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("debe ingresar un valor");
            }
            else
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                d = double.Parse(textBox4.Text);
                if (b >= 1)
                {
                    if (d >= 1) {

                        resultado1 = (a*b)+(b*c);
                        resultado3 = Math.Pow(resultado1,2);
                        result = resultado1 * 2;


                        resultado2 = (b*d);
                        resultado2 = Math.Pow(resultado2,);

                        textBox5.Text = result.ToString();
                        textBox6.Text = result.ToString();

                    }
                    else
                    {
                        MessageBox.Show("debe ingresar el denominador mayor a 0");
                    }
              }
            }

        }
    }
}
 
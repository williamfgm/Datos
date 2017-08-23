using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_menor_o_igual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (textBox1.Text =="")
            {
                MessageBox.Show("debe ingresar un valor");
            }
            else
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);

                    if (a > b &&  a>c && b>c)
                    {
                     MessageBox.Show("el numero mayor es"+a);
                      MessageBox.Show("el numero menor es" +c);
                    }
                
                    if (b >a && b>c && c>a)
                    {
                    MessageBox.Show("el numero mayor es" + b);
                    MessageBox.Show("el numero menor es" +a);
                }
                    if (c>a && c>b && b>a)
                    {
                    MessageBox.Show("el numero mayor es" + c);
                    MessageBox.Show("el numero menor es" + a);
                }
                    if (b>c && b>c && c>a)
                    {
                    MessageBox.Show("el numero mayor es" + b);
                    MessageBox.Show("el numero menor es" + a);
                }
                    if (a>b && b>c && b>c)
                    {
                    MessageBox.Show("el numero mayor es" + a);
                    MessageBox.Show("el numero menor es" + c);
                }
                    if (c>a && c>b && a>b)
                    {
                    MessageBox.Show("el numero mayor es" + c);
                    MessageBox.Show("el numero menor es" + b);
                }
               


                }

            }
        
        }
    }


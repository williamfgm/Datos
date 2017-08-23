using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A,B;
            A = double.Parse(textBox1.Text);
            B = double.Parse(textBox2.Text);
         


            if (textBox1.Text == " " || textBox2.Text ==" ")
            {
                MessageBox.Show("error debe ingresar un dato");
            }
            else
            {
                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);

                if (A>10.0 || B>10.0)
                {
                    MessageBox.Show("error las notas que ingreso deben estar entre 0 10","error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (A<=2.0 && B<=2.0)
                    {
                        MessageBox.Show("ha reprobado la asognatura","REPROBO",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        if (A >= 9.0 && B >= 9.0)
                        {
                            MessageBox.Show("ha aprobado la mareia, no debe presentar evaluacion final", "APROBO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                     else

                      {
                            MessageBox.Show("usted tiene oprtunidad de aprobar la materia", "APROBO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                      }
                       

                    }
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

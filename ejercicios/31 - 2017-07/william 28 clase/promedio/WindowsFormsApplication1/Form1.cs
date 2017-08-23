using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1

{
    public partial class Form1 : Form
    {
        public object Interaction { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n=0,resultado =0;

            n = double.Parse(textBox1.Text);
            if (n==0)
            {
                MessageBox.Show("error, ingrese un valor valido");
            }
            else
            {
                resultado = promedio_num(n);
                MessageBox.Show("el promedio es :"+resultado);
            }
        }

        public double promedio_num(double n)
        {
     
            double dato, suma=0, promedio;
   

            for (int i  = 1; i  <= n; i ++)
            {
                dato = double.Parse( Microsoft.VisualBasic.Interaction.InputBox("ingrese por favor un numero  ","numero","",3,2));
                suma = suma + dato;
            }

            promedio = suma / n;
            return promedio;
        }
        public int sumatoria(int a)
        {
            int suma = 0;
            for (int i = 1; i <= a; i++)
            {
                suma = suma + i;
               
            }
            return suma;

        }
        public long factorial(long a)
        {
            long
                 factor = 1, i, dato;
            dato = a;
            for ( i = 1; i <= a; i++)
            {
                factor = factor * i;
            }
            return factor;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int a,resultado;
            a = int.Parse(textBox1.Text);
            resultado = sumatoria(a);
            MessageBox.Show("el resultado de la sumatoria es "+ resultado);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            long a1, a;
            a = int.Parse(textBox1.Text);
            a1 = factorial(a);
            MessageBox.Show("el factirial del numero es"+a1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

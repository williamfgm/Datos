using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio10numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numero = new int[52];
        private void button1_Click(object sender, EventArgs e)
        {
           
            int resultado;
            {
                resultado = promedio_num(10);
            }
        }
        public int promedio_num(int n)
        {
            string d1;

            int suma=0, promedio, dada;
            for (int i = 0; i <=10; i++)
            {
                d1 = (Microsoft.VisualBasic.Interaction.InputBox("ingrese un numero","numero","",10,2)).ToString();

                if (d1=="")
                {
                    MessageBox.Show("error ingrese un valor  valido");
                    i = i + 1;
                    
                }
             
                else
                {
                   
                    dada = int.Parse(d1);
                    numero[i] = dada;
                    suma = suma + numero[i];

                }

                promedio = suma / 10;

                MessageBox.Show("el promedio es "+ promedio);

                for ( i = 1; i < 10; i++)
                {
                    if (numero[i]> promedio)
                    {
                        MessageBox.Show("se encuentra po ensima del promedio " +numero[i]);
                    }
              
                }
              
              }
            return n;

            }
              
           
        }
    }


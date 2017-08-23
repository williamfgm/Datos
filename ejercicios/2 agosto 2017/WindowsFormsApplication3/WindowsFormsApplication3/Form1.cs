using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 4)	Un alumno desea saber cuál será su calificación final en la materia de Algoritmos. 
            //Dicha calificación se compone de los siguientes porcentajes:

               //55 % del promedio de sus tres calificaciones parciales.

              //30 % de la calificación del examen final.

              //15 % de la calificación de un trabajo final.


            float c1, c2, c3,total=0;

            c1 = float.Parse(textBox1.Text);
            c2 = float.Parse(textBox2.Text);
            c3 = float.Parse(textBox3.Text);

            c1 = c1*0.55f;
            c2 = c2*0.30f;
            c3 = c3*0.15f; 

            total = c1 + c2 + c3;
            MessageBox.Show("su calificacion total es"+total);
        }
    }
}

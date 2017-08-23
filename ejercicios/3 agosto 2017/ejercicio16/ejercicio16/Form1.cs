using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float examen,t1,t2,t3;

            examen = float.Parse(textBox1.Text);
            t1 = float.Parse(textBox3.Text);
            t2 = float.Parse(textBox4.Text);
            t3 = float.Parse(textBox5.Text);

            float promediot = (t1 + t2 + t3) /3 *(0.10f) ;
            float pexamen = examen * 0.90f;
            float promediototal1 = (promediot + pexamen) ;

         
            MessageBox.Show("el promedio total de matematicas es :"+promediototal1);

           



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            float examen, t1, t2;

            examen = float.Parse(textBox1.Text);
            t1 = float.Parse(textBox3.Text);
            t2 = float.Parse(textBox4.Text);
           

            float promediot = (t1 + t2 ) * (0.20f) / 3;
            float pexamen = examen * 0.80f;
            float promediototal2 = (promediot + pexamen) ;


            MessageBox.Show("el promedio total de fisica es :" +promediototal2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            float examen,t1,t2,t3;

            examen = float.Parse(textBox1.Text);
            t1 = float.Parse(textBox3.Text);
            t2 = float.Parse(textBox4.Text);
            t3 = float.Parse(textBox5.Text);

            float promediot = (t1 + t2 + t3) * (0.15f) / 3;
            float pexamen = examen * 0.85f;
            float promediototal3 = (promediot + pexamen) ;

         
            MessageBox.Show("el promedio total de quimica  es :"+promediototal3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float examen, t1, t2, t3;

            examen = float.Parse(textBox1.Text);
            t1 = float.Parse(textBox3.Text);
            t2 = float.Parse(textBox4.Text);
            t3 = float.Parse(textBox5.Text);

            float promediot = (t1 + t2 + t3) * (0.15f) / 3;
            float pexamen = examen * 0.85f;
            float promediototal3 = (promediot + pexamen);
            float promediototal2 = (promediot + pexamen);
            float promediototal1 = (promediot + pexamen);



            MessageBox.Show("el promedio total   es :" + promediototal1 + promediototal2+ promediototal3);
        }
    }
}

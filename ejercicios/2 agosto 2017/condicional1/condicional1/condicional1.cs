using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicional1
{
    public partial class condicional1 : Form
    {
        public condicional1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1)	Suponga que un individuo desea invertir su capital en un banco 
            //y desea saber cuánto dinero ganara después de un mes si el banco paga a razón de 2% mensual.


            float capital = 0;
             

            capital = float.Parse(textBox1.Text);

            capital = capital * 1.02f;

            MessageBox.Show("su  capital es" + capital);


        }

    }
}
   


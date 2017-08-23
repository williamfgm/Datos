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
            int i=0,suma=0;
            while (i <=9)
            {
                i=i+1;

               suma +44= i;
                    

                MessageBox. Show("los numeros son"+i);
                MessageBox.Show("la suma es" + suma);
            }
        }
    }
}

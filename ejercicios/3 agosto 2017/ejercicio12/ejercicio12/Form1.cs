using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float presupuesto;
            presupuesto = float.Parse(textBox1.Text);

            float ginecologia,traumatologia,pediatria;

            ginecologia = presupuesto * 0.40f ;
            traumatologia = presupuesto * 0.30f ;
            pediatria = presupuesto * 0.30f ;

            MessageBox.Show("presupuesto en el area ginecologia"+ginecologia);
            MessageBox.Show("presupuesto en el area traumatologia" + traumatologia);
            MessageBox.Show("presupuesto en el area pediatria"+pediatria);

        }
    }
}

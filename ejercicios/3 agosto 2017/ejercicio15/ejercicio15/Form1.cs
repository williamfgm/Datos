using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float s1, s2, s3;
            s1 = float.Parse(textBox1.Text);
            s2 = float.Parse(textBox1.Text);
            s3 = float.Parse(textBox1.Text);

            float suma = s1 + s2 + s3;

            float p1 = s1 * 100 / suma;
            float p2 = s2 * 100 / suma;
            float p3 = s3 * 100 / suma;

            MessageBox.Show("la invercion del socio1="+"%"+p1+ ("la invercion del socio2="+"%" + p2)+ ("la invercion del socio3=" + p3));
        }
    }
}

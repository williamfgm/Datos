using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = button3.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)

                pictureBox1.Show();

            else

                if (checkBox1.Checked == false)
            {
                pictureBox1.Visible = false;
            } 
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

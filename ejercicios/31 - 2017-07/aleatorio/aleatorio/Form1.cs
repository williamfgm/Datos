using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)

                MessageBox.Show("felicidades por adivinar el numero");

        else{
	      MessageBox.Show("lo lamento usted no adivino.Intente de nuevo");
         }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random n = new Random();
            int x = n.Next(1,11);
            textBox1.Text = Convert.ToString(x);
        }
    }
    }


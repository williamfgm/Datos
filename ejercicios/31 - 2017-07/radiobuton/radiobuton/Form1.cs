using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobuton
{
    public partial class resolucion : Form
    {
        public resolucion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Height = 480;
                Width = 640;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    Height = 600;
                    Width = 800;
                }
                else
                {
                    
                        Height = 768;
                        Width = 1024;
                    
                }
            }
        }

    }
}

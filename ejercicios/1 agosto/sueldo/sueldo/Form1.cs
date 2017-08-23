using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sueldo=0;
            int hora = 0, horae=0;
       
            hora = int.Parse(textBox1.Text);
            if (hora <= 40)
            {
                sueldo = hora * 5000;
                MessageBox.Show("el seuldo es" + sueldo);



            }
            if (hora > 40)
                {
                    sueldo = 40 * 5000;
                    horae = hora - 40;
                    sueldo= sueldo + horae * 7000;
                }


                MessageBox.Show("el seuldo es" + sueldo);

            }

            
               
            }
        
           }
        
    
 

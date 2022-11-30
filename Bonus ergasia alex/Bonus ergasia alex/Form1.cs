using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonus_ergasia_alex
{
    public partial class Form1 : Form
    {
        int numb;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkViolet;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("Enter the number of Circles:"))
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(textBox1.Text,out numb))
            {
                if(numb >0 && numb <= 15){
                    for(int i = 0; i < numb; i++)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Circle Number\n" + "Enter a valid Number");
                }

            }
            else
            {
                MessageBox.Show("Invalid Circle Number\n" + "Enter a valid Number");
            }

        }

    }
}

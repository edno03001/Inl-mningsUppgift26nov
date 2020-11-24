using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        int b = 0;
        
        int d = 1;

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void bSlumpaTal_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            a = rnd.Next(1, 101);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }   

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void bJämförTal_Click(object sender, EventArgs e)
        {          

            b = Convert.ToInt32(richTextBox1.Text);
            if (b < a)
            {
                richTextBoxSvar.Text = "Ditt tal är för litet, försök igen";
                d++;

            }
            else if (b > a)
            {
                richTextBoxSvar.Text = "Ditt tal är för stort, försök igen";
                d++;
            }
            else
                richTextBoxSvar.Text = ("Rätt svar! Så här många försök tog det: " + d + "stycken");




        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBoxSvar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

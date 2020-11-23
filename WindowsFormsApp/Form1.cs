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
        string stringb;
        int c = 1;
        int d = 0;

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSlumpaTal_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            a = rnd.Next(1, 100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(a);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(a);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(a);
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Text = stringb;
        }
        private void bJämförTal_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(stringb);
            if (b < a)
                Console.WriteLine("Ditt tal är för litet, försök igen");
            else if (b > a)
                Console.WriteLine("Ditt tal är för stort, försök igen");

            d = c++;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBoxSvar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_RPG
{
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 11);

            textBox3.Text = ranbomnumber.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 21);

            textBox1.Text = ranbomnumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 13);

            textBox2.Text = ranbomnumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 9);

            textBox4.Text = ranbomnumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 7);

            textBox5.Text = ranbomnumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 5);

            textBox6.Text = ranbomnumber.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Project_V._2
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 21);

            txtD20.Text = randomnumber.ToString();
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 13);

            txtD12.Text = randomnumber.ToString();
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 11);

            txtD10.Text = randomnumber.ToString();
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 9);

            txtD8.Text = randomnumber.ToString();
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 7);

            txtD6.Text = randomnumber.ToString();
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 5);

            txtD4.Text = randomnumber.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var Menu = new Menu();
            Menu.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

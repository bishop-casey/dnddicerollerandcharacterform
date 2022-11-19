using Simple_RPG.CharacterClasses;
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
    public partial class CharacterInfo : Form
    {
        public CharacterInfo()
        {
            InitializeComponent();
        }

        private void CharacterInfo_Load(object sender, EventArgs e)
        {
            Player pl = new Player();
            pl = filemanagment.LoadPlayer();
            label1.Text = pl.Name;
            label2.Text = pl.Gender.ToString();
            label3.Text = pl.CharClass.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}

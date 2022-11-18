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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnDiceRoller_Click(object sender, EventArgs e)
        {
            var DiceRoller = new DiceRoller();
            DiceRoller.Show();
            this.Close();

        }

        private void BtnCharacterSheet_Click(object sender, EventArgs e)
        {
            var CharacterSheet = new CharacterSheet();
            CharacterSheet.Show();
            this.Close();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

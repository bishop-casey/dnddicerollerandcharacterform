<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            CharacterSheet charsheet = new CharacterSheet();
            charsheet.Show();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            var roller = new DiceRoller();
            roller.Show();
           this.Close();
        }

        
        
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> 8afa7d4ddaa720656a251fed05001709bb3ba9e2


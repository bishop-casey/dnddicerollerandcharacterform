using Simple_RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace Simple_RPG
{
    public partial class CharacterCreator : Form
    {
        public CharacterCreator()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name;

            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text [0] == ' ') 
            {
                MessageBox.Show("Character name please. Note Names Cannot begin with scpaes");
                return;
            }
#pragma warning disable CS0162 // Unreachable code detected
            if (this.RbMale.Checked == false && this.RbFemale.Checked == false)
            {
                MessageBox.Show("Choose a gender.");
                return;
            }
#pragma warning restore CS0162 // Unreachable code detected

            name = this.txtName.Text;

            CreatureGender sex = new CreatureGender();
            if (this.RbMale.Checked)
                sex = CreatureGender.Male;
            else if (this.RbFemale.Checked)
                sex = CreatureGender.Female;
            else
            {
                MessageBox.Show("Please choose gender");
                return;
            }

#pragma warning disable CS0162 // Unreachable code detected
            CreatureClass class_;
#pragma warning restore CS0162 // Unreachable code detected
            if (this.CbClass.Text == "Cleric")
                class_ = CreatureClass.Cleric;
            else if (this.CbClass.Text == "Chicken" )
                class_ = CreatureClass.Chicken;
            else if (this.CbClass.Text == "Paladin")
                class_ = CreatureClass.Paladin;
            else
            {
                MessageBox.Show("You must Choose a class.");
                return;
            }

            Player player1 = new Player(name, sex, class_);

            string output;
            output = String.Format("You created a new Chareacter.\n" + "Your name is: {0}\nYour gender is: {1}\n" + "Your class is: {2}.", player1.Name, player1.Gender.ToString(), player1.CharClass.ToString());
            MessageBox.Show(output, "Success");
            StoreCharacter(player1);
            this.Close();

                

        }

        public void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(PlayerSettingFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);  
            }
        }
       public static String SettingFolder
        {
            get
            { 
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "RPGCharacter");
                folder = Path.Combine(folder, "character settings");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }
        public static String PlayerSettingFile
        {
            get
            {
                return Path.Combine(SettingFolder, "Player.xml");
            }
        }

    }
}

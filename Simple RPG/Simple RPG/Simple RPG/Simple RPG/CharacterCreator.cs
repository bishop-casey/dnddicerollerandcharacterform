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
            name = this.txtName.Text;


            CreatureGender sex;
            if (this.RbMale.Checked)
                sex = CreatureGender.Male;
            else if (this.RbFemale.Checked)
                sex = CreatureGender.Female;
            else
            {
                MessageBox.Show("Please choose gender");
                return;
            }

            CreatureClass cclass;
            if (this.CbClass.Text == "Cleric")
                cclass = CreatureClass.Cleric;
            else if (this.CbClass.Text == "Chicken" )
                cclass = CreatureClass.Chicken;
            else if (this.CbClass.Text == "Paladin")
                cclass = CreatureClass.Paladin;
            else
            {
                MessageBox.Show("You must Choose a class.");
                return;
            }

            Player player1 = new(name, sex, cclass);  

            string output;
            output = String.Format("You created a new Chareacter.\n" +
                "Your name is: {0}\nYour gender is: {1}\n" 
                + "Your class is: {2}.", player1.Name, player1.Gender.ToString(), player1.CharClass.ToString());
            MessageBox.Show(output, "Success");
            filemanagment.StoreCharacter(player1);
            CharacterInfo info = new CharacterInfo();
            info.Show();
            this.Close();

                

        }

       
       
       
        
        

    }
}

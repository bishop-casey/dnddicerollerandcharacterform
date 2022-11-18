namespace Simple_RPG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void BtnCharacter_Click(object sender, EventArgs e)
        {
            CharacterCreator creator = new CharacterCreator();
            creator.Show();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            dice.Show();
        }
    }
}
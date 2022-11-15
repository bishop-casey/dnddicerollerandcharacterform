namespace WinFormsApp1
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ranbomnumber = rnd.Next(1, 7);

            D6Text.Text = ranbomnumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 11);

            D10Text.Text = randomnumber.ToString();
        }

        private void RollD20_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();  
            int randomnumber = rnd.Next(1, 21);  
            
            D20Text.Text = randomnumber.ToString(); 
        }

        private void D20Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void RollD12_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 13);

            D12Text.Text = randomnumber.ToString(); 
        }

        private void RollD8_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 9);
            
            D8Text.Text = randomnumber.ToString();  

        }

        private void RollD4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 5);

            D4Text.Text = randomnumber.ToString();
        }
    }
}
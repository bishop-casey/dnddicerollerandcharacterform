using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Project_V._2;

public partial class CharacterSheet : Form
 {
    public CharacterSheet()
    {
        InitializeComponent();
    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void label16_Click(object sender, EventArgs e)
    {

    }

    private void textBox17_TextChanged(object sender, EventArgs e)
    {

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

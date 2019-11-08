using System;
using System.Windows.Forms;


namespace GenericRPG
{
    public partial class Frm_Menu : Form
    {
        Frm_credits creditScreen;
        Frm_CharacterSelect charSelect;

        public Frm_Menu()
        {
            creditScreen = new Frm_credits();
            charSelect = new Frm_CharacterSelect();
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RPG_title_Click(object sender, EventArgs e)
        {

        }

        private void Btn_quitgame_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Btn_startgame_Click(object sender, EventArgs e)
        {
            FrmMap newgame = new FrmMap("level-1");
            newgame.Show();
        }

        private void Btn_credits_Click(object sender, EventArgs e)
        {
            
            creditScreen.Show();
        }

        private void btnCharSelect_Click(object sender, EventArgs e)
        {
            charSelect.Show();
        }
    }
}

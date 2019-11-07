using System;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
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
    }
}

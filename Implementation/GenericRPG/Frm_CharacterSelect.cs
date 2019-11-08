using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRPG

{
    public partial class Frm_CharacterSelect : Form
    {
        public Bitmap Character = Properties.Resources.character;
        static public string charFile = "character";


        public Frm_CharacterSelect()
        {
            InitializeComponent();
        }

        private void Character1Select_Click(object sender, EventArgs e)
        {
            charFile = "character";
 
        }

        private void Character2Select_Click(object sender, EventArgs e)
        {
            charFile = "AltCharacter";
        }

        private void Btn_Menu1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

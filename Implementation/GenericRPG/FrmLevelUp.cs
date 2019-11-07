using GameLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace GenericRPG {
    public partial class FrmLevelUp : Form {
        public FrmLevelUp() {
            InitializeComponent();
        }

        /// <summary>
        /// Function that loads information into labels and plays sounds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLevelUp_Load(object sender, EventArgs e) {
            SoundPlayer sp = new SoundPlayer(@"Resources\levelup.wav");
            sp.Play();

            Character character = Game.GetGame().Character;
            character.RefillHealthAndMana();

            // Old Health, Mana, Level
            lblOldLevel.Text  = character.Level.ToString();
            lblOldHealth.Text = ((float)Math.Round(character.Health)).ToString();
            lblOldMana.Text   = ((float)Math.Round(character.Mana)).ToString();
      
            // Old Stats
            lblOldStr.Text = ((float)Math.Round(character.Strength)).ToString();
            lblOldDex.Text = ((float)Math.Round(character.Dexterity)).ToString();
            lblOldInt.Text = ((float)Math.Round(character.Intelligence)).ToString();
            lblOldWis.Text = ((float)Math.Round(character.Wisdom)).ToString();
            lblOldCon.Text = ((float)Math.Round(character.Constitution)).ToString();
            lblOldChar.Text = ((float)Math.Round(character.Charisma)).ToString();
            lblOldLuck.Text = ((float)Math.Round(character.Luck)).ToString();

            character.LevelUp();
            ptstoAlloc.Text = character.statPoints.ToString();

            // New Health, Mana, Level
            lblNewLevel.Text  = character.Level.ToString();
            lblNewHealth.Text = character.Health.ToString();
            lblNewMana.Text = character.Mana.ToString();

            // New Stats
            lblNewStr.Text = ((float)Math.Round(character.Strength)).ToString();
            lblNewDex.Text = ((float)Math.Round(character.Dexterity)).ToString();
            lblNewInt.Text = ((float)Math.Round(character.Intelligence)).ToString();
            lblNewWis.Text = ((float)Math.Round(character.Wisdom)).ToString();
            lblNewCon.Text = ((float)Math.Round(character.Constitution)).ToString();
            lblNewChar.Text = ((float)Math.Round(character.Charisma)).ToString();
            lblNewLuck.Text = ((float)Math.Round(character.Luck)).ToString();
            }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        private void AbilitySelect_Click(object sender, EventArgs e)
        {
            FrmAbilitySelect ability = new FrmAbilitySelect();
            ability.Show();
        }

        // Allocates str skill pt
        private void button2_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incStrength();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewStr.Text = ((float)Math.Round(character.Strength)).ToString();
        }

        private void dexAlloc_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incDexterity();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewDex.Text = ((float)Math.Round(character.Dexterity)).ToString();
        }

        private void intAlloc_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incIntelligence();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewInt.Text = ((float)Math.Round(character.Intelligence)).ToString();
        }

        private void wisAlloc_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incWisdom();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewWis.Text = ((float)Math.Round(character.Wisdom)).ToString();
        }

        private void conAlloc_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incConstitution();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewCon.Text = ((float)Math.Round(character.Constitution)).ToString();
        }

        private void charAlloc_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incCharisma();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewChar.Text = ((float)Math.Round(character.Charisma)).ToString();
        }

        private void luckAlloc_Click(object sender, EventArgs e)
        {
            Character character = Game.GetGame().Character;
            character.incLuck();

            ptstoAlloc.Text = character.statPoints.ToString();
            lblNewLuck.Text = ((float)Math.Round(character.Luck)).ToString();
        }
    }
}

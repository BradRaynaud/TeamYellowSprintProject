using GameLibrary;
using GenericRPG.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace GenericRPG {
    public partial class FrmArena : Form
    {
        protected Game game;
        protected Character character;
        protected Enemy enemy;
        protected Random rand;
        //public string[] Ability;
        public FrmArena()
        {
            InitializeComponent();
        }
        private void btnEndFight_Click(object sender, EventArgs e)
        {
            EndFight();
        }
        protected void EndFight()
        {
            if (Game.GetGame().State == GameState.FIGHTING)
            {
                Game.GetGame().ChangeState(GameState.ON_MAP);
            }
            Game.GetGame().SetEnemy(null);
            Close();
        }
        protected virtual void FrmArena_Load(object sender, EventArgs e)
        {
            rand = new Random();

            game = Game.GetGame();
            character = game.Character;
            enemy = Game.GetGame().CurrentEnemy;

            // stats
            UpdateStats();

            // pictures
            picCharacter.BackgroundImage = character.Pic.Image;
            picEnemy.BackgroundImage = enemy.Img;

            // names
            lblPlayerName.Text = character.Name;
            lblEnemyName.Text = enemy.Name;
        }
    
        /// <summary>
        /// This function updates the stats on the FrmArena menu
        /// </summary>

        public void UpdateStats() {
                // Update the Player Level and Health
        lblPlayerLevel.Text = character.Level.ToString();
        lblPlayerHealth.Text = Math.Round(character.Health).ToString();
        
        // Update the Player Stats
        lblPlayerStr.Text = Math.Round(character.Strength).ToString();
        lblPlayerDex.Text = Math.Round(character.Dexterity).ToString();
        lblPlayerCon.Text = Math.Round(character.Constitution).ToString();
        lblPlayerInt.Text = Math.Round(character.Intelligence).ToString();
        lblPlayerWis.Text = Math.Round(character.Wisdom).ToString();
        lblPlayerChar.Text = Math.Round(character.Charisma).ToString();
        lblPlayerLuck.Text = Math.Round(character.Luck).ToString();

        // Update Player Mana and XP
        lblPlayerMana.Text = Math.Round(character.Mana).ToString();
        lblPlayerXp.Text = Math.Round(character.XP).ToString();
        
        // Update Enemy level, health, and stats
        lblEnemyLevel.Text = enemy.Level.ToString();
        lblEnemyHealth.Text = Math.Round(enemy.Health).ToString();
        lblEnemyStr.Text = Math.Round(enemy.Str).ToString();
        lblEnemyDef.Text = Math.Round(enemy.Def).ToString();
        lblEnemyMana.Text = Math.Round(enemy.Mana).ToString();

        // Duplicated code that reupdates the player and enemy health
        // This should do nothing but I didnt remove it just in case
        //lblPlayerHealth.Text = Math.Round(character.Health).ToString();
        //lblEnemyHealth.Text = Math.Round(enemy.Health).ToString();
        }

        public void updateAbilities()
        {
        }
        protected virtual void combatStuff()
        {
            if (enemy.Health <= 0)
            {
                character.GainXP(enemy.XpDropped,enemy.Level,character.Level);
                lblEndFightMessage.Text = "You Gained " + Math.Round(enemy.XpDropped * 2.5F) + " xp!";
                lblEndFightMessage.Visible = true;
                character.regenerateHealth();
                character.regenerateMana();
                Refresh();
                Thread.Sleep(1200);
                EndFight();
                if (character.ShouldLevelUp)
                {
                    FrmLevelUp frmLevelUp = new FrmLevelUp();
                    frmLevelUp.Show();
                   
                }
            }
            else
            {
                float prevPlayerHealth = character.Health;
                enemy.EnemyAttack(character);
                float playerDamage = (float)Math.Round(prevPlayerHealth - character.Health);
                lblPlayerDamage.Text = playerDamage.ToString();
                lblPlayerDamage.Visible = true;
                tmrPlayerDamage.Enabled = true;
                if (character.Health <= 0)
                {
                    UpdateStats();
                    game.ChangeState(GameState.DEAD);
                    lblEndFightMessage.Text = "You Were Defeated!";
                    lblEndFightMessage.Visible = true;
                    Refresh();
                    Thread.Sleep(1200);
                    EndFight();
                    FrmGameOver frmGameOver = new FrmGameOver();
                    frmGameOver.Show();
                }
                else
                {
                    UpdateStats();
                }
            }

        }
    /// <summary>
    /// This function executes on simple attack click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// 
    private void btnSimpleAttack_Click(object sender, EventArgs e) {
    float prevEnemyHealth = enemy.Health;
    character.SimpleAttack(enemy);
    float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
    lblEnemyDamage.Text = enemyDamage.ToString();
    lblEnemyDamage.Visible = true;
    tmrEnemyDamage.Enabled = true;
    combatStuff();
    }
     //function for ability 2
    private void btnAttack2_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Attack2(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnSpark_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Spark(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
        }
    private void btnWeakenAttack_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.WeakenAttack(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnHeal_Click(object sender, EventArgs e)
    {
        character.Heal(character);
        combatStuff();
    }
    private void btnFireball_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Fireball(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnSlash_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Slash(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();

    }
    private void btnStab_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Stab(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnBigStab_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.BigStab(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnIceBlast_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.IceBlast(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnMeteor_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Meteor(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnBloodMagic_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.BloodMagic(character,enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnMercy_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.Mercy(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }
    private void btnPocketSand_Click(object sender, EventArgs e)
    {
        float prevEnemyHealth = enemy.Health;
        character.PocketSand(enemy);
        float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
        lblEndFightMessage.Text = "Useless";
        lblEndFightMessage.Visible = true;
        lblEnemyDamage.Text = enemyDamage.ToString();
        lblEnemyDamage.Visible = true;
        tmrEnemyDamage.Enabled = true;
        combatStuff();
    }



        /// <summary>
        /// This function executies on Run button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e) {
        double run;
        run = ((character.Charisma + character.Luck) * .09 + rand.NextDouble());
        //Console.WriteLine(run);
        if (run > .95)
        { 
            lblEndFightMessage.Text = "You Ran Like a Coward!";
            lblEndFightMessage.Visible = true;
            Refresh();
            Thread.Sleep(1200);
            EndFight();
        }
        else {
        combatStuff();
        UpdateStats();
        }
    }

    private void tmrPlayerDamage_Tick(object sender, EventArgs e) {
        lblPlayerDamage.Top -= 2;
        if (lblPlayerDamage.Top < 10) {
            lblPlayerDamage.Visible = false;
            tmrPlayerDamage.Enabled = false;
            lblPlayerDamage.Top = 52;
        }
    }

    private void tmrEnemyDamage_Tick(object sender, EventArgs e) {
        lblEnemyDamage.Top -= 2;
        if (lblEnemyDamage.Top < 10) {
            lblEnemyDamage.Visible = false;
            tmrEnemyDamage.Enabled = false;
            lblEnemyDamage.Top = 52;
        }
    }



    }
}

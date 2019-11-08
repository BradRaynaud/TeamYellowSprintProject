using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameLibrary;
using GenericRPG.Properties;

namespace GenericRPG {
    class FrmBossArena : FrmArena {
        protected Boolean upgrade = false;

        override protected void FrmArena_Load(object sender, EventArgs e) {
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
            lblEnemyName.Text = "Big Boss Bowser";
        }

        protected override void combatStuff() {
            if (enemy.Health <= 0) {
                game.ChangeState(GameState.WIN);
                Refresh();
                Thread.Sleep(1200);
                EndFight();
                FrmGameOver frmGameOver = new FrmGameOver();
                frmGameOver.Show();
            }
            else {
                float prevPlayerHealth = character.Health;
                enemy.SimpleAttack(character);
                float playerDamage = (float)Math.Round(prevPlayerHealth - character.Health);
                lblPlayerDamage.Text = playerDamage.ToString();
                lblPlayerDamage.Visible = true;
                tmrPlayerDamage.Enabled = true;
                if (character.Health <= 0) {
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
                else {
                    UpdateStats();
                }
            }

            if (!upgrade && enemy.Health < 0.5*enemy.MaxHealth) {
                upgrade = true;
                picEnemy.BackgroundImage = Resources.fireBowser;
                for (int i = 0; i < 3; ++i) {
                    enemy.LevelUp();
                }
            }

        }
    }
}

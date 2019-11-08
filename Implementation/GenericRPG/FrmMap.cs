﻿using GameLibrary;
using GenericRPG.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GenericRPG {
    public partial class FrmMap : Form {
        private Character character;
        private Game game;
        private string MapFolder;

        public FrmMap(string mapFolder) {
            MapFolder = mapFolder;
            InitializeComponent();
        }

        private void FrmMap_Load(object sender, EventArgs e) {
            game = Game.GetGame();

            character = Map.InitializeMaps(MapFolder, Frm_CharacterSelect.charFile, grpMap,
              str => Resources.ResourceManager.GetObject(str) as Bitmap
            );

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Width = grpMap.Width + 25;
            Height = grpMap.Height + 50;
            game.SetCharacter(character);
        }

        private void FrmMap_KeyDown(object sender, KeyEventArgs e) {
            MoveDir dir = MoveDir.NO_MOVE;
            switch (e.KeyCode) {
                case Keys.Left:
                    dir = MoveDir.LEFT;
                    break;
                case Keys.Right:
                    dir = MoveDir.RIGHT;
                    break;
                case Keys.Up:
                    dir = MoveDir.UP;
                    break;
                case Keys.Down:
                    dir = MoveDir.DOWN;
                    break;
            }
            if (dir != MoveDir.NO_MOVE) {
                character.Move(dir);
                if (game.State == GameState.FIGHTING) {
                    FrmArena frmArena = new FrmArena();
                    frmArena.Show();
                }
                if (game.State == GameState.BOSS_FIGHT) {
                    FrmArena frmArena = new FrmBossArena();
                    frmArena.Show();
                }
            }
        }
    }
}

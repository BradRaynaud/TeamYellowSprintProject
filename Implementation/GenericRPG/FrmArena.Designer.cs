﻿using System.Windows.Forms;
using GameLibrary;
namespace GenericRPG {
  partial class FrmArena {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.lblPlayerStr = new System.Windows.Forms.Label();
            this.lblPlayerDex = new System.Windows.Forms.Label();
            this.lblPlayerMana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlayerInt = new System.Windows.Forms.Label();
            this.lblPlayerWis = new System.Windows.Forms.Label();
            this.lblPlayerChar = new System.Windows.Forms.Label();
            this.lblPlayerLuck = new System.Windows.Forms.Label();
            this.lblPlayerCon = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPlayerDamage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerXp = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEnemyDamage = new System.Windows.Forms.Label();
            this.lblEnemyLevel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEnemyStr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEnemyDef = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEnemyMana = new System.Windows.Forms.Label();
            this.btnSimpleAttack = new System.Windows.Forms.Button();
            this.btnWeakenAttack = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblEndFightMessage = new System.Windows.Forms.Label();
            this.tmrPlayerDamage = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyDamage = new System.Windows.Forms.Timer(this.components);
            this.Attack2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            this.SuspendLayout();

            Character character = Game.GetGame().Character;
            #region Settings
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlayerHealth.Location = new System.Drawing.Point(111, 229);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerHealth.TabIndex = 1;
            this.lblPlayerHealth.Text = "label1";
            // 
            // picCharacter
            // 
            this.picCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCharacter.Location = new System.Drawing.Point(24, 43);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(178, 136);
            this.picCharacter.TabIndex = 2;
            this.picCharacter.TabStop = false;
            // 
            // lblPlayerStr
            // 
            this.lblPlayerStr.AutoSize = true;
            this.lblPlayerStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerStr.Location = new System.Drawing.Point(50, 278);
            this.lblPlayerStr.Name = "lblPlayerStr";
            this.lblPlayerStr.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerStr.TabIndex = 3;
            this.lblPlayerStr.Text = "label1";
            // 
            // lblPlayerDex
            // 
            this.lblPlayerDex.AutoSize = true;
            this.lblPlayerDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerDex.Location = new System.Drawing.Point(50, 301);
            this.lblPlayerDex.Name = "lblPlayerDex";
            this.lblPlayerDex.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerDex.TabIndex = 4;
            this.lblPlayerDex.Text = "label1";
            // 
            // lblPlayerMana
            // 
            this.lblPlayerMana.AutoSize = true;
            this.lblPlayerMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlayerMana.Location = new System.Drawing.Point(111, 258);
            this.lblPlayerMana.Name = "lblPlayerMana";
            this.lblPlayerMana.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerMana.TabIndex = 5;
            this.lblPlayerMana.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(48, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mana:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(3, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dex:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(3, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Str:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(39, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Health:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(3, 12);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(178, 24);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlayerInt);
            this.panel1.Controls.Add(this.lblPlayerWis);
            this.panel1.Controls.Add(this.lblPlayerChar);
            this.panel1.Controls.Add(this.lblPlayerLuck);
            this.panel1.Controls.Add(this.lblPlayerCon);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblPlayerDamage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPlayerXp);
            this.panel1.Controls.Add(this.lblPlayerLevel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.lblPlayerHealth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picCharacter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPlayerStr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPlayerDex);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPlayerMana);
            this.panel1.Location = new System.Drawing.Point(48, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 396);
            this.panel1.TabIndex = 11;
            // 
            // lblPlayerInt
            // 
            this.lblPlayerInt.AutoSize = true;
            this.lblPlayerInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerInt.Location = new System.Drawing.Point(170, 281);
            this.lblPlayerInt.Name = "lblPlayerInt";
            this.lblPlayerInt.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerInt.TabIndex = 25;
            this.lblPlayerInt.Text = "label1";
            // 
            // lblPlayerWis
            // 
            this.lblPlayerWis.AutoSize = true;
            this.lblPlayerWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerWis.Location = new System.Drawing.Point(170, 301);
            this.lblPlayerWis.Name = "lblPlayerWis";
            this.lblPlayerWis.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerWis.TabIndex = 24;
            this.lblPlayerWis.Text = "label1";
            // 
            // lblPlayerChar
            // 
            this.lblPlayerChar.AutoSize = true;
            this.lblPlayerChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerChar.Location = new System.Drawing.Point(170, 321);
            this.lblPlayerChar.Name = "lblPlayerChar";
            this.lblPlayerChar.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerChar.TabIndex = 23;
            this.lblPlayerChar.Text = "label1";
            // 
            // lblPlayerLuck
            // 
            this.lblPlayerLuck.AutoSize = true;
            this.lblPlayerLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLuck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerLuck.Location = new System.Drawing.Point(49, 343);
            this.lblPlayerLuck.Name = "lblPlayerLuck";
            this.lblPlayerLuck.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerLuck.TabIndex = 22;
            this.lblPlayerLuck.Text = "label1";
            // 
            // lblPlayerCon
            // 
            this.lblPlayerCon.AutoSize = true;
            this.lblPlayerCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlayerCon.Location = new System.Drawing.Point(50, 321);
            this.lblPlayerCon.Name = "lblPlayerCon";
            this.lblPlayerCon.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerCon.TabIndex = 21;
            this.lblPlayerCon.Text = "label1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(3, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Luck:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(122, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Char:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(122, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Wis:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(122, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Int:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(3, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Con:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerDamage
            // 
            this.lblPlayerDamage.AutoSize = true;
            this.lblPlayerDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDamage.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerDamage.Location = new System.Drawing.Point(138, 52);
            this.lblPlayerDamage.Name = "lblPlayerDamage";
            this.lblPlayerDamage.Size = new System.Drawing.Size(89, 25);
            this.lblPlayerDamage.TabIndex = 15;
            this.lblPlayerDamage.Text = "label10";
            this.lblPlayerDamage.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(63, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "XP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerXp
            // 
            this.lblPlayerXp.AutoSize = true;
            this.lblPlayerXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerXp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPlayerXp.Location = new System.Drawing.Point(111, 372);
            this.lblPlayerXp.Name = "lblPlayerXp";
            this.lblPlayerXp.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerXp.TabIndex = 13;
            this.lblPlayerXp.Text = "label1";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.AutoSize = true;
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPlayerLevel.Location = new System.Drawing.Point(111, 185);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(57, 20);
            this.lblPlayerLevel.TabIndex = 11;
            this.lblPlayerLevel.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(50, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Level:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEnemyDamage);
            this.panel2.Controls.Add(this.lblEnemyLevel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblEnemyName);
            this.panel2.Controls.Add(this.lblEnemyHealth);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.picEnemy);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblEnemyStr);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblEnemyDef);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblEnemyMana);
            this.panel2.Location = new System.Drawing.Point(422, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 363);
            this.panel2.TabIndex = 12;
            // 
            // lblEnemyDamage
            // 
            this.lblEnemyDamage.AutoSize = true;
            this.lblEnemyDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDamage.ForeColor = System.Drawing.Color.Red;
            this.lblEnemyDamage.Location = new System.Drawing.Point(135, 52);
            this.lblEnemyDamage.Name = "lblEnemyDamage";
            this.lblEnemyDamage.Size = new System.Drawing.Size(89, 25);
            this.lblEnemyDamage.TabIndex = 16;
            this.lblEnemyDamage.Text = "label10";
            this.lblEnemyDamage.Visible = false;
            // 
            // lblEnemyLevel
            // 
            this.lblEnemyLevel.AutoSize = true;
            this.lblEnemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEnemyLevel.Location = new System.Drawing.Point(116, 185);
            this.lblEnemyLevel.Name = "lblEnemyLevel";
            this.lblEnemyLevel.Size = new System.Drawing.Size(57, 20);
            this.lblEnemyLevel.TabIndex = 13;
            this.lblEnemyLevel.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(55, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Level:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.ForeColor = System.Drawing.Color.White;
            this.lblEnemyName.Location = new System.Drawing.Point(24, 12);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(178, 24);
            this.lblEnemyName.TabIndex = 10;
            this.lblEnemyName.Text = "Enemy Name";
            this.lblEnemyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEnemyHealth.Location = new System.Drawing.Point(116, 228);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(57, 20);
            this.lblEnemyHealth.TabIndex = 1;
            this.lblEnemyHealth.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(53, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picEnemy
            // 
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.Location = new System.Drawing.Point(24, 43);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(178, 136);
            this.picEnemy.TabIndex = 2;
            this.picEnemy.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(68, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Def:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyStr
            // 
            this.lblEnemyStr.AutoSize = true;
            this.lblEnemyStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEnemyStr.Location = new System.Drawing.Point(116, 301);
            this.lblEnemyStr.Name = "lblEnemyStr";
            this.lblEnemyStr.Size = new System.Drawing.Size(57, 20);
            this.lblEnemyStr.TabIndex = 3;
            this.lblEnemyStr.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(73, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Str:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyDef
            // 
            this.lblEnemyDef.AutoSize = true;
            this.lblEnemyDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEnemyDef.Location = new System.Drawing.Point(116, 329);
            this.lblEnemyDef.Name = "lblEnemyDef";
            this.lblEnemyDef.Size = new System.Drawing.Size(57, 20);
            this.lblEnemyDef.TabIndex = 4;
            this.lblEnemyDef.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(44, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Health:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEnemyMana
            // 
            this.lblEnemyMana.AutoSize = true;
            this.lblEnemyMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyMana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEnemyMana.Location = new System.Drawing.Point(116, 257);
            this.lblEnemyMana.Name = "lblEnemyMana";
            this.lblEnemyMana.Size = new System.Drawing.Size(57, 20);
            this.lblEnemyMana.TabIndex = 5;
            this.lblEnemyMana.Text = "label1";

            // 
            // lblEndFightMessage
            // 
            this.lblEndFightMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndFightMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndFightMessage.ForeColor = System.Drawing.Color.White;
            this.lblEndFightMessage.Location = new System.Drawing.Point(48, 433);
            this.lblEndFightMessage.Name = "lblEndFightMessage";
            this.lblEndFightMessage.Size = new System.Drawing.Size(601, 30);
            this.lblEndFightMessage.TabIndex = 16;
            this.lblEndFightMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEndFightMessage.Visible = false;
            // 
            // tmrPlayerDamage
            // 
            this.tmrPlayerDamage.Interval = 20;
            this.tmrPlayerDamage.Tick += new System.EventHandler(this.tmrPlayerDamage_Tick);
            // 
            // tmrEnemyDamage
            // 
            this.tmrEnemyDamage.Interval = 20;
            this.tmrEnemyDamage.Tick += new System.EventHandler(this.tmrEnemyDamage_Tick);

            // 
            // FrmArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 501);
            this.Controls.Add(this.Attack2);
            this.Controls.Add(this.lblEndFightMessage);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnWeakenAttack);
            this.Controls.Add(this.btnSimpleAttack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmArena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArena";
            this.Load += new System.EventHandler(this.FrmArena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            this.ResumeLayout(false);



            #endregion
           
            // 
            // btnSimpleAttack
            // 
            this.btnSimpleAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSimpleAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleAttack.Location = new System.Drawing.Point(306, 146);
            this.btnSimpleAttack.Name = "btnSimpleAttack";
            this.btnSimpleAttack.Size = new System.Drawing.Size(86, 46);
            this.btnSimpleAttack.TabIndex = 13;
            this.btnSimpleAttack.Text = character.Abilities[0];
            this.btnSimpleAttack.UseVisualStyleBackColor = false;
            this.btnSimpleAttack.Click += new System.EventHandler(this.btnSimpleAttack_Click);
            
            if (character.Abilities[0] == "Simple Attack")
            {
                this.btnSimpleAttack.Click += new System.EventHandler(this.btnSimpleAttack_Click);
            }
            if (character.Abilities[0] == "Slash")
            {
                this.btnSimpleAttack.Click += new System.EventHandler(this.btnSlash_Click);
            }
            if (character.Abilities[0] == "Stab")
            {
                this.btnSimpleAttack.Click += new System.EventHandler(this.btnStab_Click);
            }
            if (character.Abilities[0] == "Big Stab")
            {
                this.btnSimpleAttack.Click += new System.EventHandler(this.btnBigStab_Click);
            }

            // 
            // btnWeakenAttack
            // 
            this.btnWeakenAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWeakenAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeakenAttack.Location = new System.Drawing.Point(306, 198);
            this.btnWeakenAttack.Name = "btnWeakenAttack";
            this.btnWeakenAttack.Size = new System.Drawing.Size(86, 46);
            this.btnWeakenAttack.TabIndex = 14;
            this.btnWeakenAttack.Text = character.Abilities[1];
            this.btnWeakenAttack.UseVisualStyleBackColor = false;
            if (character.Abilities[1] == "Weaken")
            {
                this.btnWeakenAttack.Click += new System.EventHandler(this.btnWeakenAttack_Click);
            }
            if (character.Abilities[1] == "Heal")
            {
                this.btnWeakenAttack.Click += new System.EventHandler(this.btnHeal_Click);
            }
            if (character.Abilities[1] == "Fireball")
            {
                this.btnWeakenAttack.Click += new System.EventHandler(this.btnFireball_Click);
            }
            if (character.Abilities[1] == "Ice Blast")
            {
                this.btnWeakenAttack.Click += new System.EventHandler(this.btnIceBlast_Click);
            }

            // 
            // Attack2
            // 
            this.Attack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Attack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack2.Location = new System.Drawing.Point(306, 250);
            this.Attack2.Name = "Attack2";
            this.Attack2.Size = new System.Drawing.Size(86, 43);
            this.Attack2.TabIndex = 17;
            this.Attack2.Text = character.Abilities[2];
            this.Attack2.UseVisualStyleBackColor = false;
            if (character.Abilities[2] == "BIG MOVE")
            {
                this.Attack2.Click += new System.EventHandler(this.btnAttack2_Click);
            }
            if (character.Abilities[2] == "Meteor")
            {
                this.Attack2.Click += new System.EventHandler(this.btnMeteor_Click);
            }
            if (character.Abilities[2] == "Blood Magic")
            {
                this.Attack2.Click += new System.EventHandler(this.btnBloodMagic_Click);
            }
            if (character.Abilities[2] == "Execution")
            {
                this.Attack2.Click += new System.EventHandler(this.btnMercy_Click);
            }
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(306, 299);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(86, 46);
            this.btnRun.TabIndex = 15;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            

    }
    
    #endregion
    private System.Windows.Forms.Label lblPlayerHealth;
    private System.Windows.Forms.PictureBox picCharacter;
    private System.Windows.Forms.Label lblPlayerStr;
    private System.Windows.Forms.Label lblPlayerDex;
    private System.Windows.Forms.Label lblPlayerMana;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblPlayerName;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lblEnemyName;
    private System.Windows.Forms.Label lblEnemyHealth;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblEnemyStr;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblEnemyDef;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label lblEnemyMana;
    private System.Windows.Forms.Label lblPlayerLevel;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblEnemyLevel;
    private System.Windows.Forms.Label label7;
    public System.Windows.Forms.Button btnSimpleAttack;
    private System.Windows.Forms.Button btnWeakenAttack;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Label lblEndFightMessage;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblPlayerXp;
    private System.Windows.Forms.Label lblPlayerDamage;
    private System.Windows.Forms.Label lblEnemyDamage;
    private System.Windows.Forms.Timer tmrPlayerDamage;
    private System.Windows.Forms.Timer tmrEnemyDamage;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lblPlayerInt;
    private System.Windows.Forms.Label lblPlayerWis;
    private System.Windows.Forms.Label lblPlayerChar;
    private System.Windows.Forms.Label lblPlayerLuck;
    private System.Windows.Forms.Label lblPlayerCon;
    private System.Windows.Forms.Button Attack2;
  

    }
    
}
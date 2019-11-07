namespace WindowsFormsApp1
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.RPG_title = new System.Windows.Forms.Label();
            this.Btn_startgame = new System.Windows.Forms.Button();
            this.Btn_credits = new System.Windows.Forms.Button();
            this.Btn_quitgame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RPG_title
            // 
            this.RPG_title.AutoSize = true;
            this.RPG_title.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPG_title.Location = new System.Drawing.Point(88, 9);
            this.RPG_title.Name = "RPG_title";
            this.RPG_title.Size = new System.Drawing.Size(314, 31);
            this.RPG_title.TabIndex = 0;
            this.RPG_title.Text = "RPG GAMING SERIES\r\n";
            this.RPG_title.Click += new System.EventHandler(this.RPG_title_Click);
            // 
            // Btn_startgame
            // 
            this.Btn_startgame.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_startgame.Location = new System.Drawing.Point(12, 315);
            this.Btn_startgame.Name = "Btn_startgame";
            this.Btn_startgame.Size = new System.Drawing.Size(95, 42);
            this.Btn_startgame.TabIndex = 1;
            this.Btn_startgame.Text = "Start Game";
            this.Btn_startgame.UseVisualStyleBackColor = true;
            // 
            // Btn_credits
            // 
            this.Btn_credits.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_credits.Location = new System.Drawing.Point(307, 315);
            this.Btn_credits.Name = "Btn_credits";
            this.Btn_credits.Size = new System.Drawing.Size(95, 42);
            this.Btn_credits.TabIndex = 3;
            this.Btn_credits.Text = "Credits";
            this.Btn_credits.UseVisualStyleBackColor = true;
            // 
            // Btn_quitgame
            // 
            this.Btn_quitgame.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitgame.Location = new System.Drawing.Point(445, 315);
            this.Btn_quitgame.Name = "Btn_quitgame";
            this.Btn_quitgame.Size = new System.Drawing.Size(95, 42);
            this.Btn_quitgame.TabIndex = 4;
            this.Btn_quitgame.Text = "Quit Game";
            this.Btn_quitgame.UseVisualStyleBackColor = true;
            this.Btn_quitgame.Click += new System.EventHandler(this.Btn_quitgame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 273);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Avatar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_quitgame);
            this.Controls.Add(this.Btn_credits);
            this.Controls.Add(this.Btn_startgame);
            this.Controls.Add(this.RPG_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.Text = "RPGMENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RPG_title;
        private System.Windows.Forms.Button Btn_startgame;
        private System.Windows.Forms.Button Btn_credits;
        private System.Windows.Forms.Button Btn_quitgame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}


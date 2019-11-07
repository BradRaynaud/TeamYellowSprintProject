namespace GenericRPG
{
    partial class Frm_CharacterSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Menu1 = new System.Windows.Forms.Button();
            this.Character1Select = new System.Windows.Forms.Button();
            this.Character2Select = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE YOUR AVATAR";
            // 
            // Btn_Menu1
            // 
            this.Btn_Menu1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu1.Location = new System.Drawing.Point(402, 537);
            this.Btn_Menu1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btn_Menu1.Name = "Btn_Menu1";
            this.Btn_Menu1.Size = new System.Drawing.Size(190, 88);
            this.Btn_Menu1.TabIndex = 1;
            this.Btn_Menu1.Text = "Menu";
            this.Btn_Menu1.UseVisualStyleBackColor = true;
            this.Btn_Menu1.Click += new System.EventHandler(this.Btn_Menu1_Click);
            // 
            // Character1Select
            // 
            this.Character1Select.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character1Select.Location = new System.Drawing.Point(15, 537);
            this.Character1Select.Margin = new System.Windows.Forms.Padding(6);
            this.Character1Select.Name = "Character1Select";
            this.Character1Select.Size = new System.Drawing.Size(190, 88);
            this.Character1Select.TabIndex = 3;
            this.Character1Select.Text = "SELECT";
            this.Character1Select.UseVisualStyleBackColor = true;
            this.Character1Select.Click += new System.EventHandler(this.Character1Select_Click);
            // 
            // Character2Select
            // 
            this.Character2Select.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character2Select.Location = new System.Drawing.Point(779, 543);
            this.Character2Select.Margin = new System.Windows.Forms.Padding(6);
            this.Character2Select.Name = "Character2Select";
            this.Character2Select.Size = new System.Drawing.Size(190, 88);
            this.Character2Select.TabIndex = 4;
            this.Character2Select.Text = "SELECT";
            this.Character2Select.UseVisualStyleBackColor = true;
            this.Character2Select.Click += new System.EventHandler(this.Character2Select_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GenericRPG.Properties.Resources.AltCharacter;
            this.pictureBox2.Location = new System.Drawing.Point(599, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 395);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::GenericRPG.Properties.Resources.character;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 646);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Character2Select);
            this.Controls.Add(this.Character1Select);
            this.Controls.Add(this.Btn_Menu1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_CharacterSelect";
            this.Text = "Avatar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Menu1;
        private System.Windows.Forms.Button Character1Select;
        private System.Windows.Forms.Button Character2Select;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


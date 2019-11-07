namespace WindowsFormsApp3
{
    partial class Frm_Avatar
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
            this.Btn_Select = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Radio_Button2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE YOUR AVATAR";
            // 
            // Btn_Menu1
            // 
            this.Btn_Menu1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu1.Location = new System.Drawing.Point(201, 279);
            this.Btn_Menu1.Name = "Btn_Menu1";
            this.Btn_Menu1.Size = new System.Drawing.Size(95, 46);
            this.Btn_Menu1.TabIndex = 1;
            this.Btn_Menu1.Text = "Menu";
            this.Btn_Menu1.UseVisualStyleBackColor = true;
            // 
            // Btn_Select
            // 
            this.Btn_Select.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Select.Location = new System.Drawing.Point(201, 217);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(95, 46);
            this.Btn_Select.TabIndex = 2;
            this.Btn_Select.Text = "SELECT";
            this.Btn_Select.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(75, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(161, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BLUE NINJA(DEFAULT)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Radio_Button2
            // 
            this.Radio_Button2.AutoSize = true;
            this.Radio_Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button2.Location = new System.Drawing.Point(315, 150);
            this.Radio_Button2.Name = "Radio_Button2";
            this.Radio_Button2.Size = new System.Drawing.Size(81, 17);
            this.Radio_Button2.TabIndex = 4;
            this.Radio_Button2.TabStop = true;
            this.Radio_Button2.Text = "SAMURAI";
            this.Radio_Button2.UseVisualStyleBackColor = true;
            this.Radio_Button2.CheckedChanged += new System.EventHandler(this.Radio_Button2_CheckedChanged);
            // 
            // Frm_Avatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 336);
            this.Controls.Add(this.Radio_Button2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.Btn_Menu1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Avatar";
            this.Text = "Avatar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Menu1;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Radio_Button2;
    }
}


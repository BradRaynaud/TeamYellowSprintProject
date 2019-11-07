namespace WindowsFormsApp1
{
    partial class Frm_credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_credits));
            this.Credit_Label = new System.Windows.Forms.Label();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Credit_Label
            // 
            this.Credit_Label.AutoSize = true;
            this.Credit_Label.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit_Label.Location = new System.Drawing.Point(-2, 41);
            this.Credit_Label.Name = "Credit_Label";
            this.Credit_Label.Size = new System.Drawing.Size(543, 200);
            this.Credit_Label.TabIndex = 1;
            this.Credit_Label.Text = resources.GetString("Credit_Label.Text");
            this.Credit_Label.Click += new System.EventHandler(this.Credit_Label_Click);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu.Location = new System.Drawing.Point(150, 280);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(165, 47);
            this.Btn_Menu.TabIndex = 2;
            this.Btn_Menu.Text = "Back To Menu";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click_1);
            // 
            // Frm_credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 369);
            this.Controls.Add(this.Btn_Menu);
            this.Controls.Add(this.Credit_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Frm_credits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Credit_Label;
        private System.Windows.Forms.Button Btn_Menu;
    }
}
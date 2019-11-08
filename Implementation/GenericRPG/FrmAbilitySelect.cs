using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GenericRPG.Properties;
using GameLibrary;

namespace GenericRPG
{
    
    public partial class FrmAbilitySelect : Form
    {

        private FrmArena frmArena = new FrmArena();
        public string[] box1items;
        public string[] box2items;
        public string[] box3items;
        public string[] selecteditems = new string[3];

        public FrmAbilitySelect()
        {
            InitializeComponent();
            string[] box1items = new string[comboBox1.Items.Count];

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                box1items[i] = comboBox1.Items[i].ToString();
            }
            string[] box2items = new string[comboBox1.Items.Count];

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                box2items[i] = comboBox1.Items[i].ToString();
            }
            string[] box3items = new string[comboBox1.Items.Count];

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                box3items[i] = comboBox1.Items[i].ToString();
            }
        }
        public void getInfo()
        {
            Character character = Game.GetGame().Character;
            selecteditems[0] = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            selecteditems[1] = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            selecteditems[2] = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);
            character.Abilities[0] = selecteditems[0];
            character.Abilities[1] = selecteditems[1];
            character.Abilities[2] = selecteditems[2];

        }
        public void checkLevel()
        {
            Character character = Game.GetGame().Character;
            if (character.Level >= 3)
            {
                this.comboBox1.Items.Add("Stab");
                this.comboBox2.Items.Add("Fireball");
                this.comboBox3.Items.Add("Pocket Sand");
            }
            if (character.Level >= 5)
            {

                this.comboBox1.Items.Add("Slash");
                this.comboBox2.Items.Add("Ice Blast");
                
            }
            if (character.Level >= 8)
            {
                this.comboBox3.Items.Add("Meteor");
                this.comboBox2.Items.Add("Heal");
            }
            if (character.Level >= 10)
            {
                this.comboBox3.Items.Add("Blood Magic");
                this.comboBox1.Items.Add("Big Stab");

            }
            if(character.Level >= 30)
            {
                this.comboBox3.Items.Add("Mercy");
            }
        }
            public void btnComfirm_Click(object sender, EventArgs e)
        {
            
            this.getInfo();
            frmArena.updateAbilities();
            Close();
        }
    }  

        
}

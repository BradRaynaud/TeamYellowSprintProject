using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameLibrary {
    public class Enemy : Mortal {
        private const float MAX_XP_DROP = 35;
        private const float MIN_XP_DROP = 20;
        private const float WEAKEN_MIN = 1.25f;
        private const float WEAKEN_MAX = 1.85f;

        public float HealthTitleMod;
        public float ManaTitleMod;
        public float StrTitleMod;
        public float DefTitleMod;

        public Bitmap Img { get; private set; }
        public float XpDropped { get; private set; }

        private static readonly Random rand = new Random();
        private static readonly List<string> names = new List<string>() {
            "Wily", "Bob", "Dr. Light", "WallCrusher", "BigChungus"
        };
        private static readonly List<string> Titles = new List<string>() {
            "Mighty", "Hidden", "Sneaky", "Quick", "Mild", "Boring", "Tiny", "Huge", "Useless", "Exploding" 
        };

        private static readonly List<float> TitleHModifier = new List<float>() {
            1.2F, 0.9F, 0.7F, .9F, 0.9F, 1F, 0.5F, 1.7F, 0.5F, 1.0F
        };
        private static readonly List<float> TitleMModifier = new List<float>() {
            0.9F, 0.8F, 0.6F, .9F, 0.9F, 1F, 0.5F, 0.7F, 0.5F, 1.0F
        };
        private static readonly List<float> TitleSModifier = new List<float>() {
            1.3F, 1.1F, 1.2F, .9F, 0.9F, 1F, 1.5F, 1.2F, 0.5F, 1.7F
        };
        private static readonly List<float> TitleDModifier = new List<float>() {
            1.2F, .8F, 0.8F, 1.1F, 0.9F, 1F, 0.7F, 0.7F, 0.5F, 0.6F
        };


        /// <summary>
        /// Constructor for Enemy
        /// </summary>
        /// <param name="level">Level of generated enemy</param>
        /// <param name="img">What img to use for enemy</param>
        public Enemy(int level, Bitmap img) : base(RandName(), level) {
            Img = img;
            
            string title = RandTitle();
            Name = "The " + title +" " + Name;

            // Retrive modifier values
            HealthTitleMod = getHealthMod(title);
            ManaTitleMod = getManaMod(title);
            StrTitleMod = getStrMod(title);
            DefTitleMod = getDefMod(title);

            // weaken so player has a chance
            Health /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;
            Mana /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;
            Str /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;
            Def /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;

            // Modify the stats according to title
            
            Health = Health * HealthTitleMod;
            Mana = Mana * ManaTitleMod;
            Str = Str * StrTitleMod;
            Def = Def * DefTitleMod;


            XpDropped = (float)rand.NextDouble() * (MAX_XP_DROP - MIN_XP_DROP) + MIN_XP_DROP;
        }

        public static string RandName() {
            return names[rand.Next(names.Count)];
        }

        /// <summary>
        /// Chooses a random title
        /// </summary>
        /// <returns>returns title</returns>
        public static string RandTitle()
        {
            string title = Titles[rand.Next(Titles.Count)];
            return title;
        }

        /// <summary>
        /// Retrieves the Health modifer for the title
        /// </summary>
        /// <param name="title">current title</param>
        /// <returns>modifier Value</returns>
        private static float getHealthMod(string title)
        {
            int index = Titles.IndexOf(title);
            return TitleHModifier[index];
        }
        /// <summary>
        /// Retrieves the Mana modifer for the title
        /// </summary>
        /// <param name="title">current title</param>
        /// <returns>modifier Value</returns>
        private static float getManaMod(string title)
        {
            int index = Titles.IndexOf(title);
            return TitleMModifier[index];
        }
        /// <summary>
        /// Retrieves the Str modifer for the title
        /// </summary>
        /// <param name="title">current title</param>
        /// <returns>modifier Value</returns>
        private static float getStrMod(string title)
        {
            int index = Titles.IndexOf(title);
            return TitleSModifier[index];
        }
        /// <summary>
        /// Retrieves the Def modifer for the title
        /// </summary>
        /// <param name="title">current title</param>
        /// <returns>modifier Value</returns>
        private static float getDefMod(string title)
        {
            int index = Titles.IndexOf(title);
            return TitleDModifier[index];
        }

    }
}

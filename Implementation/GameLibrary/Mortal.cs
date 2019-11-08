using System;

namespace GameLibrary {      
    public class Mortal 
    {
        #region Constants
  
        private const float INIT_HEALTH = 100;
        private const float INIT_STR = 5;
        private const float INIT_DEF = 5;
        private const float INIT_LUCK = 2;
        private const float INIT_SPEED = 2;
        private const float INIT_MANA = 40;

        // New Stats INIT values
        private const float INIT_STRENGTH = 2;
        private const float INIT_DEXTERITY = 2;
        private const float INIT_CONSTITUTION = 2;
        private const float INIT_INTELLIGENCE = 2;
        private const float INIT_WISDOM = 2;
        private const float INIT_CHARISMA = 2;
        

        private const float LVLINC_HEALTH = 20;
        private const float LVLINC_STR = 3;
        private const float LVLINC_DEF = 2;
        private const float LVLINC_LUCK = 1;
        private const float LVLINC_SPEED = 2;
        private const float LVLINC_MANA = 10;

        // New Stats LVLINC values
        private const float LVLINC_STRENGTH = 1;
        private const float LVLINC_DEXTERITY = 1;
        private const float LVLINC_CONSTITUTION = 1;
        private const float LVLINC_INTELLIGENCE = 1;
        private const float LVLINC_WISDOM = 1;
        private const float LVLINC_CHARISMA = 1;

        private const float SIMPLEATTACK_RANDOM_AMT = 0.25f;
        #endregion
            
        public string Name { get; protected set; }
        public int Level { get; protected set; }
        public float MaxHealth { get; protected set; }
        public virtual float Health { get; protected set; }
        public float MaxMana { get; protected set; }
        public float Mana { get; protected set; }


        public string[] Abilities = { "Simple Attack", "Spark", "" };
        // New Stats
        public float Strength { get; protected set; }
        public float Dexterity { get; protected set; }
        public float Constitution { get; protected set; }
        public float Intelligence { get; protected set; }
        public float Wisdom { get; protected set; }
        public float Charisma { get; protected set; }
        public float Luck { get; protected set; }
        public int statPoints { get; protected set; }

        public float Str { get; protected set; }
        public float Def { get; protected set; }
        
        public float Speed { get; protected set; }

        private Random rand;
    
        public Mortal(string name, int level) {
            Name = name;
            ResetStats();
            SetLevel(level);
            rand = new Random();
        }
        /// <summary>
        /// Reset stats to base values on death
        /// </summary>
        public virtual void ResetStats() {
            Level = 1;
            MaxHealth = INIT_HEALTH;
            Health = MaxHealth;
            MaxMana = INIT_MANA;
            Mana = MaxMana;
            Str = INIT_STR;
            Def = INIT_DEF;
            Luck = INIT_LUCK;
            Speed = INIT_SPEED;

            // New Stat Reset Function
            Strength = INIT_STRENGTH;
            Dexterity = INIT_DEXTERITY;
            Constitution = INIT_CONSTITUTION;
            Intelligence = INIT_INTELLIGENCE;
            Wisdom = INIT_WISDOM;
            Charisma = INIT_CHARISMA;
            Luck = INIT_LUCK;

        }
        /// <summary>
        /// Sets the player's level
        /// </summary>
        /// <param name="level"></param>
        public void SetLevel(int level) {
            for (int i = 1; i < level; i++) {
            LevelUp();
            }
        }
        /// <summary>
        /// Function to handle level ups
        /// </summary>
        public virtual void LevelUp() {
            // level increases
            Level++;

            // health and mana
            MaxHealth += LVLINC_HEALTH;
            MaxMana += LVLINC_MANA;
            Health = MaxHealth;
            Mana = MaxMana;

            statPoints += 7;

            
            Str += LVLINC_STR;
            Def += LVLINC_DEF;
            Speed += LVLINC_SPEED;
            /*
            // Dont need increment value assuming statpoint
            // Alloc is still implemented
            // other stats
            // New stats increment
            Strength += LVLINC_STRENGTH;
            Dexterity += LVLINC_DEXTERITY;
            Constitution += LVLINC_CONSTITUTION;
            Intelligence += LVLINC_INTELLIGENCE;
            Wisdom += LVLINC_WISDOM;
            Charisma += LVLINC_CHARISMA;
            Luck += LVLINC_LUCK;
            */
        }
        // Refill Health and Mana

        public void RefillHealthAndMana() {
            Health = MaxHealth;
            Mana = MaxMana;
        }
        //all methods of attack
        #region Abilities
        public void SimpleAttack(Mortal receiver)
        {
            if (Str <= 0)
            {
                return;
            }
            float baseDamage = Math.Abs(9+(Strength * .9f - receiver.Def));
            float randMax = 1 + SIMPLEATTACK_RANDOM_AMT;
            float randMin = 1 - SIMPLEATTACK_RANDOM_AMT;
            float randMult = (float)(rand.NextDouble() * (randMax - randMin)) + randMin;
            receiver.Health -= (baseDamage * randMult);
        }
        public void EnemyAttack(Mortal receiver)
        {
            if (Str <= 0)
            {
                return;
            }

            float baseDamage = (float)Math.Abs(2.2*receiver.Level+(Str * 1.9f - receiver.Def));
            float randMax = 1 + SIMPLEATTACK_RANDOM_AMT;
            float randMin = 1 - SIMPLEATTACK_RANDOM_AMT;
            float randMult = (float)(rand.NextDouble() * (randMax - randMin)) + randMin;
            receiver.Health -= (baseDamage * randMult);
        }

        public void Stab(Mortal receiver)
        {
            if (Str <= 0)
            {
                return;
            }
            float baseDamage = Math.Abs(9+(Strength * 1.2f - receiver.Def));
            float randMax = 1 + .4f;
            float randMin = 1 - .4f;
            float randMult = (float)(rand.NextDouble() * (randMax - randMin)) + randMin;
            receiver.Health -= (baseDamage * randMult);
        }
        public void Slash(Mortal receiver)
        {
            if (Str <= 0)
            {
                return;
            }
            float baseDamage = Math.Abs((Strength * 1.4f - receiver.Def));
            float randMax = 1 + .5f;
            float randMin = 1 - .4f;
            float randMult = (float)(rand.NextDouble() * (randMax - randMin)) + randMin;
            receiver.Health -= (baseDamage * randMult);
        }
        public void BigStab(Mortal receiver)
        {
            if (Str <= 0)
            {
                return;
            }
            float baseDamage = Math.Abs(4+(Strength * 2.8f - receiver.Def));
            float randMax = 1 + .6f;
            float randMin = 1 - .4f;
            float randMult = (float)(rand.NextDouble() * (randMax - randMin)) + randMin;
            receiver.Health -= (baseDamage * randMult);
        }
        public void Mercy(Mortal receiver)
        {
            Mana = 0;
            receiver.Health = 1;
        }
        public void Attack2(Mortal receiver)
        {
           
            receiver.Health = 0;
        }
        
        public void Fireball(Mortal receiver)
        {
            if(spellCost(20))
            {
                float baseDamage = (float)Math.Abs((5+((Intelligence+Wisdom)*.2))* (rand.NextDouble()+2.7* Level));
                receiver.Health -= baseDamage;
            }                     
        }
        public void Spark(Mortal receiver)
        {
            
           
            if(spellCost(10))
            {
                float baseDamage = (float)Math.Abs(((6+((Intelligence+Wisdom)*.33)*(rand.NextDouble()+2.8*Level))));
                receiver.Health -= baseDamage;
            }
        }
        public void Heal(Mortal character)
        {
            if(spellCost(25))
            {
                character.Health = (float)Math.Abs(character.Intelligence *((rand.NextDouble()+.6) *Level));
            }
        }
        public void Meteor(Mortal receiver)
        {
            if (spellCost(50))
            {
                receiver.Health -= (float)Math.Abs(30 * (Level*.2));
            }
        }
        public void BloodMagic(Mortal character, Mortal receiver)
        {
              if(character.Health-50 >=0)
            {
                character.Health -= 50;
                receiver.Health -= (float)Math.Abs(40 * (Level*.4));
            }
        }
        public void IceBlast(Mortal receiver)
        {
            if (spellCost(30))
            {
                float baseDamage = (float)Math.Abs((6+((Intelligence+Wisdom*.4)) * (rand.NextDouble()*3 + Level)));
                receiver.Health -= baseDamage;
            }
        }
        public bool spellCost(float x)
        {
            if(Mana-x>=0)
            {
                Mana -= x;
             
                return true;
            }
            else
            {
                return false;
            }

        }
        public void WeakenAttack(Mortal receiver)
        {
            if (receiver.Str < 0 )
            {
                return;
            }
            if(spellCost(15))
            {
                receiver.Str -= 1;
            }
             
        }
        public void PocketSand(Mortal receiver)
        {
            receiver.Health -= 1;
        }
        #endregion
        /// <summary>
        /// Increment Strength Value
        /// </summary>
        ///
        public void incStrength()
        {
            if(statPoints > 0)
            {
                Strength += 1;
                statPoints -= 1;
            }
        }
        /// <summary>
        /// Increment Dex Value
        /// </summary>
        public void incDexterity()
        {
            if (statPoints > 0)
            {
                Dexterity += 1;
                statPoints -= 1;
            }
        }
        /// <summary>
        /// Increment Intelligence value
        /// </summary>
        public void incIntelligence()
        {
            if (statPoints > 0)
            {
                Intelligence += 1;
                statPoints -= 1;
            }
        }

        /// <summary>
        /// Increment Wisdom Value
        /// </summary>
        public void incWisdom()
        {
            if (statPoints > 0)
            {
                Wisdom += 1;
                MaxMana += 5;
                statPoints -= 1;
            }
        }

        /// <summary>
        /// Increment Constitution Value
        /// </summary>
        public void incConstitution()
        {
            if (statPoints > 0)
            {
                Constitution += 1;
                MaxHealth+= 5;
                statPoints -= 1;
            }
        }
        /// <summary>
        /// Increment Charisma Value
        /// </summary>
        public void incCharisma()
        {
            if (statPoints > 0)
            {
                Charisma += 1;
                statPoints -= 1;
            }
        }
        /// <summary>
        /// Increment Luck Value
        /// </summary>
        public void incLuck()
        {
            if (statPoints > 0)
            {
                Luck += 1;
                statPoints -= 1;
            }
        }


    public void regenerateHealth() {
        float regenHealth = MaxHealth * 0.1F;
        if(Health+regenHealth<= MaxHealth)
        {
            Health += regenHealth;
        }
        else
        {
            Health = MaxHealth; 
        }
            
    }

    public void regenerateMana() {
        float regenMana = MaxMana * 0.1F;
        if (Mana+ regenMana <= MaxMana)
        {
                Mana += regenMana;
        }
        else
        {
            Mana= MaxMana;
        }
      

    }

    }
}

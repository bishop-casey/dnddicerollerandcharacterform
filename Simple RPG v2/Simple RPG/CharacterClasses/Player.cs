using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_RPG.CharacterClasses
{
    public class Player : Creature
    {
        Random random = new Random();

        public Player()
        {
        }

        public Player(string name, CreatureGender csex, CreatureClass class_) : base()
        {
            Name = name;
            Gender = csex;
            CharClass = class_;
        }
        public Player(string name, CreatureGender csex, CreatureClass class_, int dex, int health, int stre, int wis ) : base()
        {
            Name = name;
            Gender = csex;
            CharClass = class_;
            Dex = dex;
            Health = health;    
            Stre = stre;
            Wis = wis;
        }
    }
}

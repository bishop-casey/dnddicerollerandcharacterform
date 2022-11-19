using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_RPG.CharacterClasses
{
    public enum CreatureGender { Male, Female, Unknown }
    public enum CreatureClass { Cleric, Paladin, Chicken, Unknown }
    public abstract class Creature
    {
        // Field
        CreatureGender gender;
        CreatureClass class_;
        string name;
        int stre;
        int dex;
        int wis;
        int health;
        
       

        //Properties
        public string Name
        { 
            get { return name; }
            set { name = value; } 
        }
        public CreatureGender Gender 
        { 
            get { return gender; } 
             set { gender = value; } 
        }
        public CreatureClass CharClass
        {
            get { return class_; }

            set { class_ = value; }
        }
        public int Stre { get { return stre ; }  set { stre = value; } }
        public int Dex { get { return dex; }  set { dex = value; } }
        public int Wis { get { return wis ; }  set { wis = value; } }
        public int Health { get { return health ; }  set { health = value; } }

        // Constructor
        public Creature()
        {
            name = "";
            Gender = CreatureGender.Unknown;
            CharClass = CreatureClass.Unknown;
            Stre = 0;
            Dex = 0;
            Wis = 0;
            Health = 0;
        }
    }
 }

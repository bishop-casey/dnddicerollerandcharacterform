using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_RPG.CharacterClasses
{
    public enum CreatureGender { Male, Female, Whatisthat }
    public enum CreatureClass { Cleric, Paladin, Chicken, Unknown }
    public abstract class Creature
    {
        // Field
        
        CreatureGender gender;
        CreatureClass? class_;
        int stre, dex, wis, health;
        int strmod;
        int dexmod;
        int wismod;
        int healthmod;

       

        //Properties
        public string Name { get;  set; }
        public CreatureGender Gender { 
            get { return gender; } 
             set { gender = value; } 
                }
        public CreatureClass CharClass
        {
#pragma warning disable CS8629 // Nullable value type may be null.
            get => (CreatureClass)class_;
#pragma warning restore CS8629 // Nullable value type may be null.
             set => class_ = value;
        }
        public int Stre { get { return stre + strmod; }  set { stre = value; } }
        public int Dex { get { return dex + dexmod; }  set { dex = value; } }
        public int Wis { get { return wis + wismod; }  set { wis = value; } }
        public int Health { get { return health + healthmod; }  set { health = value; } }

        // Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Creature()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Name = "";
            Gender = (CreatureGender)CreatureClass.Unknown;
            Stre = 0;
            Dex = 0;
            Wis = 0;
            Health = 0;
        }
    }
 }

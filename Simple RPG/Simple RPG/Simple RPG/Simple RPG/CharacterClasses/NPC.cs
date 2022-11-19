using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simple_RPG.CharacterClasses
{
    public class NPC : Creature
    {
        public NPC()
            : base()
        {
           
        }
        public NPC(string name, CreatureGender csex, CreatureClass class_) : base()
        {
            Name = name;
            Gender = csex;
            CharClass = class_;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Entity.Entities
{
    public class Bot:BaseEntity
    {
        public string Name { get; set; }
        public int ArmorValue { get; set; }
        public int StraightStroke { get; set; }
        public int LifeValue { get; set; }
        public int AbilityID { get; set; }
        public virtual Ability Ability { get; set; }

    }
}

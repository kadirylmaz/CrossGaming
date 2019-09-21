using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Entity.Entities
{
    public class Ability : BaseEntity
    {
        public Ability()
        {
            Players = new HashSet<Player>();
            Bots = new HashSet<Bot>();
        }
        public string AbilityName { get; set; }
        public int AbilityDamage { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Bot> Bots { get; set; }
    }
}

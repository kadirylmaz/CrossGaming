using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrossGaming.API.Models
{
    public class MatchViewModel
    {
        public int PlayerID { get; set; }
        public Player Player { get; set; }
        public Bot Bot { get; set; }
        public int BotID { get; set; }
        public string AbilityName { get; set; }
        public int Damage {get; set; }
        public int StraightStroke { get; set; }
        public int LifeValue { get; set; }
        public int ArmorValue { get; set; }

        public Type Type { get; set; }
    }

    public enum Type
    {
        Hit = 1,
        Ulti = 2
    }

 
}

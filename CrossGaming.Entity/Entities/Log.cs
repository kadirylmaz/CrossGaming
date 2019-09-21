using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Entity.Entities
{
    public class Log:BaseEntity
    {
        public string PlayerName { get; set; }
        public string BotName { get; set; }
        public string AbilityName { get; set; }
        public int Damage { get; set; }
    }
}

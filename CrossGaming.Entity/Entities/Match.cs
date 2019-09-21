using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CrossGaming.Entity.Entities
{
    public class Match:BaseEntity
    {
  
        public string PlayerName { get; set; }
        public string BotName { get; set; }

    }
}

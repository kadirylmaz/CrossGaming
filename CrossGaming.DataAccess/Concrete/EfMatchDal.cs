using CrossGaming.Core.DataAccess.EntityFramework;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossGaming.DataAccess.Concrete
{
    public class EfMatchDal : EfEntityRepositoryBase<Match, CrossGamingContext>, IMatchDal
    {
        public void Hit(Player player, Bot bot)
        {
            using (var context = new CrossGamingContext())
            {
                Log log = new Log();
                var Player = context.Players.FirstOrDefault(x => x.ID == player.ID);
                var Bot = context.Bots.FirstOrDefault(x => x.ID == player.ID);

                if (Player == null)
                    throw new Exception("Player not found");
                if (Bot == null)
                    throw new Exception("Bot not found");

                if (Player.ArmorValue == 0)                
                    Player.LifeValue = Player.LifeValue - Bot.StraightStroke;                
                else                
                    Player.ArmorValue = Player.ArmorValue - Bot.StraightStroke;                   
                
                if (Bot.ArmorValue == 0)                
                    Bot.LifeValue = Bot.LifeValue - Player.StraightStroke;                          
                else
                    Bot.ArmorValue = Bot.ArmorValue - Player.StraightStroke;               
                  
                log.PlayerName = Player.Name;
                log.BotName = Bot.Name;
                log.Damage = Bot.StraightStroke;
                log.CreatedDate = DateTime.Now;
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }

        public void Ulti(Player player, Bot bot)
        {
            using (var context = new CrossGamingContext())
            {
                Log log = new Log();
                var Player = context.Players.Include(x => x.Ability).Where(x => x.ID == player.ID).FirstOrDefault();
                var Bot = context.Bots.Include(x => x.Ability).Where(x => x.ID == bot.ID).FirstOrDefault();

                if (Bot.ArmorValue <= 0)
                    Bot.LifeValue = Bot.LifeValue - Player.Ability.AbilityDamage;                  
                else                
                    Bot.ArmorValue = Bot.ArmorValue - Player.Ability.AbilityDamage;

                if (Player.ArmorValue <= 0)
                    Player.LifeValue = Player.LifeValue - Bot.Ability.AbilityDamage;
                else
                    Player.ArmorValue = Player.ArmorValue - Bot.Ability.AbilityDamage;
                
                                 
                log.AbilityName = Player.Ability.AbilityName;
                log.BotName = Bot.Name;
                log.PlayerName = Player.Name;
                log.Damage = Player.Ability.AbilityDamage;
                log.CreatedDate = DateTime.Now;
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }
    }
}

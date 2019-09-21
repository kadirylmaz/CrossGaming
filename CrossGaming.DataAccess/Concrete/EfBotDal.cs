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
    public class EfBotDal : EfEntityRepositoryBase<Bot, CrossGamingContext>, IBotDal
    {
        public void Edit(int id, Bot bot)
        {
            using (var context = new CrossGamingContext())
            {
                var b = context.Bots.Where(x => x.ID == id).FirstOrDefault();
                b.Name = bot.Name;
                b.StraightStroke = bot.StraightStroke;
                b.LifeValue = bot.LifeValue;
                b.ArmorValue = bot.ArmorValue;
                b.AbilityID = b.AbilityID;
                context.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (var context = new CrossGamingContext())
            {
                var b = context.Bots.Where(x => x.ID == id).FirstOrDefault();
                b.DeletedDate = DateTime.Now;
                b.IsDeleted = true;
                context.SaveChanges();
            }
        }


    }
}

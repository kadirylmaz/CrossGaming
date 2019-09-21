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
    public class EfPlayerDal : EfEntityRepositoryBase<Player, CrossGamingContext>, IPlayerDal
    {
        public void Edit(int id,Player player)
        {
            using (var context = new CrossGamingContext())
            {
                var p = context.Players.Where(x => x.ID == id).FirstOrDefault();
                p.ModifiedDate = DateTime.Now;
                p.Name = player.Name;
                p.AbilityID = player.AbilityID;
                p.StraightStroke = player.StraightStroke;
                p.LifeValue = player.LifeValue;
                p.ArmorValue = player.ArmorValue;
                context.SaveChanges();
            }
        }

        public List<Player> GetByAbility(int abilityId)
        {
            using (var context = new CrossGamingContext())
            {
                var abilities = context.Players.Include(x => x.Ability).Where(x => x.AbilityID == abilityId || abilityId == 0).ToList();
                return abilities;
            }
        }


        public void Remove(int id)
        {
            using (var context = new CrossGamingContext())
            {
                var p = context.Players.Where(x => x.ID == id).FirstOrDefault();               
                p.IsDeleted = true;
                p.DeletedDate = DateTime.Now;
                context.SaveChanges();
            }
        }

       
    }
}

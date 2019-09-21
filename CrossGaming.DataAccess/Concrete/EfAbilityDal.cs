using CrossGaming.Core.DataAccess.EntityFramework;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossGaming.DataAccess.Concrete
{
    public class EfAbilityDal : EfEntityRepositoryBase<Ability, CrossGamingContext>, IAbilityDal
    {
        public void Edit(int id, Ability ability)
        {
            using (var context = new CrossGamingContext())
            {
                var a = context.Abilities.Where(x => x.ID == id).FirstOrDefault();
                a.AbilityName = ability.AbilityName;
                a.ModifiedDate = DateTime.Now;
                a.AbilityDamage = ability.AbilityDamage;
                context.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (var context = new CrossGamingContext())
            {
                var a = context.Abilities.Where(x => x.ID == id).FirstOrDefault();
                a.IsDeleted = true;
                a.DeletedDate = DateTime.Now;
                context.SaveChanges();
            }
        }
    }
}

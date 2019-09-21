using CrossGaming.Core.DataAccess;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.DataAccess.Abstract
{
    public interface IAbilityDal:IEntityRepository<Ability>
    {
        void Edit(int id, Ability ability);
        void Remove(int id);
    }
}

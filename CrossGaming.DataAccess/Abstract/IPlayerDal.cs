using CrossGaming.Core.DataAccess;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.DataAccess.Abstract
{
    public interface IPlayerDal:IEntityRepository<Player>
    {
        void Remove(int id);
        void Edit(int id,Player player);
        List<Player> GetByAbility(int abilityId);

    }
}

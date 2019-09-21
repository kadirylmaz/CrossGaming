using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Business.Abstract
{
    public interface IPlayerService:IBaseService<Player>
    {
        List<Player> GetByAbility(int abilityId);
    }
}

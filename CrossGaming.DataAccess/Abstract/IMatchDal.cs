using CrossGaming.Core.DataAccess;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.DataAccess.Abstract
{
    public interface IMatchDal:IEntityRepository<Match>
    {
        void Hit(Player player, Bot bot);
        void Ulti(Player player, Bot bot);
    }
}

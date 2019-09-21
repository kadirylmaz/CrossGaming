using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Business.Abstract
{
    public interface IMatchService:IBaseService<Match>
    {
        void Hit(Player player, Bot bot);
        void Ulti(Player player, Bot bot);
    }
}

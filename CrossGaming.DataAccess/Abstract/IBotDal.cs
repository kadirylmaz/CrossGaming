using CrossGaming.Core.DataAccess;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.DataAccess.Abstract
{
    public interface IBotDal : IEntityRepository<Bot>
    {
        void Edit(int id, Bot bot);
        void Remove(int id);
    }

}

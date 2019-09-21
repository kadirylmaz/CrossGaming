using CrossGaming.Business.Abstract;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossGaming.Business.Concrete
{
    public class BotManager : IBotService
    {
        private readonly IBotDal _botDal;
        public BotManager(IBotDal botDal)
        {
            _botDal = botDal;
        }
        public void Add(Bot entity)
        {
            _botDal.Add(entity);
        }

        public void Edit(int id, Bot entity)
        {
            _botDal.Edit(id,entity);
        }

        public Bot Get(int id)
        {
            return _botDal.Get(x => !x.IsDeleted && x.ID == id);
        }

        public List<Bot> GetAll()
        {
            return _botDal.GetList(x => !x.IsDeleted).OrderByDescending(x => x.CreatedDate).ToList();
        }


        public void Remove(int id)
        {
            _botDal.Remove(id);
        }

    }
}

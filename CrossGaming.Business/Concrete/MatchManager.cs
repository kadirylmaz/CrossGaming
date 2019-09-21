using CrossGaming.Business.Abstract;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Business.Concrete
{
    public class MatchManager : IMatchService
    {
        private readonly IMatchDal _matchDal;
        public MatchManager(IMatchDal matchDal)
        {
            _matchDal = matchDal;
        }
        public void Add(Match entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Match entity)
        {
            throw new NotImplementedException();
        }

        public Match Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Match> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Hit(Player player, Bot bot)
        {
            _matchDal.Hit(player, bot);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Ulti(Player player, Bot bot)
        {
            _matchDal.Ulti(player, bot);
        }
    }
}

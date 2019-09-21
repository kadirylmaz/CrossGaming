using CrossGaming.Business.Abstract;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossGaming.Business.Concrete
{
   
    public class PlayerManager : IPlayerService
    {
        private readonly IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public void Add(Player entity)
        {
            _playerDal.Add(entity);
        }

        public void Edit(int id,Player entity)
        {
            _playerDal.Edit(id,entity);
        }

        public Player Get(int id)
        {
            return _playerDal.Get(x => x.ID == id && !x.IsDeleted);
        }

        public List<Player> GetAll()
        {
            return _playerDal.GetList(x => !x.IsDeleted).OrderByDescending(x => x.CreatedDate).ToList();
        }

        public List<Player> GetByAbility(int abilityId)
        {
            return _playerDal.GetByAbility(abilityId);
        }



        public void Remove(int id)
        {
            _playerDal.Remove(id);
        }

 
    }
}

using CrossGaming.Business.Abstract;
using CrossGaming.DataAccess.Abstract;
using CrossGaming.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossGaming.Business.Concrete
{
    public class AbilityManager : IAbilityService
    {
        private readonly IAbilityDal _abilityDal;
        public AbilityManager(IAbilityDal abilityDal)
        {
            _abilityDal = abilityDal;
        }
        public void Add(Ability entity)
        {
            _abilityDal.Add(entity);
        }

        public void Edit(int id, Ability entity)
        {
            _abilityDal.Edit(id, entity);
        }

        public Ability Get(int id)
        {
            return _abilityDal.Get(x => !x.IsDeleted && x.ID == id);
        }

        public List<Ability> GetAll()
        {
            return _abilityDal.GetList(x => !x.IsDeleted).OrderByDescending(x => x.CreatedDate).ToList();
        }

        public void Remove(int id)
        {
            _abilityDal.Remove(id);
        }
    }
}

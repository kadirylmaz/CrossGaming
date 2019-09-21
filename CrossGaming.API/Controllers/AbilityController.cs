using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossGaming.Business.Abstract;
using CrossGaming.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrossGaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbilityController : ControllerBase
    {
        private readonly IAbilityService _abilityService;
        public AbilityController(IAbilityService abilityService)
        {
            _abilityService = abilityService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Ability>> Get()
        {
            return _abilityService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Ability> Get(int id)
        {
            return _abilityService.Get(id);
        }

    }
}
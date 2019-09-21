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
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return _playerService.Get(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            return _playerService.GetAll();
        }   
        
        [HttpPost]
        public void Post([FromBody] Player player)
        {
            _playerService.Add(player);
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Player player)
        {

            _playerService.Edit(id,player);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _playerService.Remove(id);
        }

        [HttpGet("ability/{id}")]
        public ActionResult<IEnumerable<Player>> Ability(int id)
        {
           return  _playerService.GetByAbility(id);
        }
    }
}
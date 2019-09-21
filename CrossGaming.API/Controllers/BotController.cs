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
    public class BotController : ControllerBase
    {
        private readonly IBotService _botService;
        public BotController(IBotService botService)
        {
            _botService = botService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bot>> Get()
        {
            return _botService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Bot> Get(int id)
        {
            return _botService.Get(id);
        }



        [HttpPost]
        public void Post([FromBody] Bot bot)
        {
            _botService.Add(bot);
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Bot bot)
        {
            _botService.Edit(id, bot);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _botService.Remove(id);
        }
    }
}
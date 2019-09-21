using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossGaming.API.Models;
using CrossGaming.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrossGaming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] MatchViewModel model)
        {
            if (model == null || !Enum.IsDefined(typeof(Models.Type), model.Type))
                return BadRequest();
            if (model.Type == Models.Type.Hit)
                _matchService.Hit(model.Player, model.Bot);                
            else
                _matchService.Ulti(model.Player, model.Bot);
            return Ok();
        }
    }
}
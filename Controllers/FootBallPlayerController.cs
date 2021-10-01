using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBall;
using Microsoft.AspNetCore.Mvc;
using Opgave4REST.Manager;


namespace Opgave4REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FootBallPlayerController : ControllerBase
    {
        private readonly FootBallPlayerManager _manager = new FootBallPlayerManager();


        [HttpGet]
        public IEnumerable<FootBallPlayer> Get()
        {
            return _manager.GetAll();
        }

        [HttpGet("{id}")]
        public FootBallPlayer Get(int id)
        {
            return _manager.GetById(id);
        }


        [HttpPost]
        public FootBallPlayer Post([FromBody] FootBallPlayer value)
        {
            return _manager.Add(value);
        }


    }
}

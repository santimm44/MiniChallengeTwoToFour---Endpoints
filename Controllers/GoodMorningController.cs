using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour___Endpoints.services;

namespace MiniChallengeTwoToFour___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodMorningController : ControllerBase
    {
        private readonly GoodMorningServices _GoodMorningServices;

        public GoodMorningController(GoodMorningServices goodMorningServices)
        {
            _GoodMorningServices = goodMorningServices;
        }

        [HttpPost]
        [Route("GoodMorning/{time},{name}")]
        public string CallGoodMorning(int time, string name)
        {
            return _GoodMorningServices.GoodMorningMessage(time, name);
        }

    }
}
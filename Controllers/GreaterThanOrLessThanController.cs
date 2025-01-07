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
    public class GreaterThanOrLessThanController : ControllerBase
    {
        private readonly GreaterThanOrLessThanServices _GreaterThanOrLessThanServices;

        public GreaterThanOrLessThanController(GreaterThanOrLessThanServices greaterThanOrLessThanServices)
        {
            _GreaterThanOrLessThanServices = greaterThanOrLessThanServices;
        }

        [HttpPost]
        [Route("GreaterOrLessThan/{userFirstNumber}/{userSecondNumber}")]
        public string GTOLT(int userFirstNumber, int userSecondNumber)
        {
            return _GreaterThanOrLessThanServices.GreaterThanOrLessThanMethod(userFirstNumber, userSecondNumber);
        }
    }
}
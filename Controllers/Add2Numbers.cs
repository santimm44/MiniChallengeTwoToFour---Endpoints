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
    public class Add2Numbers : ControllerBase
    {

        //empty reference to our services
        private readonly Add2NumbersServices _Add2NumbersServices;

        public Add2Numbers(Add2NumbersServices add2NumbersServices)
        {
            _Add2NumbersServices = add2NumbersServices;
        }

        [HttpPost]
        [Route("Add2Numbers/{FirstNumber},{SecondNumber}")]
        public string Add2numbers(int FirstNumber, int SecondNumber){

            return _Add2NumbersServices.Add2numbers(FirstNumber, SecondNumber);
        }
    }
}
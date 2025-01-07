using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwoToFour___Endpoints.services
{
    public class GoodMorningServices
    {
        public string GoodMorningMessage( int time, string name)
        {
            return $"Hello {name}. You woke up at {time} o'clock today.";
        }
    }
}
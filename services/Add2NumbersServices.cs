using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwoToFour___Endpoints.services
{
    public class Add2NumbersServices
    {
        public string Add2numbers(int FirstNumber, int SecondNumber){
            int sum = FirstNumber+SecondNumber;

            return $"The sum of {FirstNumber} and {SecondNumber} is {sum}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwoToFour___Endpoints.services
{
    public class GreaterThanOrLessThanServices
    {
        public string GreaterThanOrLessThanMethod(int userFirstNumber, int userSecondNumber)
        {
            if(userFirstNumber > userSecondNumber) 
            {
                return $"{userFirstNumber} is greater than {userSecondNumber}, and {userSecondNumber} is smaller than {userFirstNumber}";
            }
            else if( userSecondNumber > userFirstNumber)
            {
                return $"{userSecondNumber} is greater than {userFirstNumber}, and {userFirstNumber} is smaller than {userSecondNumber}";
            }

            return $"Both {userFirstNumber} and {userSecondNumber} are equal to eachother";
        }
    }
}
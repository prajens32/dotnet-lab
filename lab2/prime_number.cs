using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class PrimeNumber
    {
       
        public bool prime(int number)
        {   
            int denominator = number;
            int count = 0;
            if (number <= 1) return false; 
            while(denominator != 0)
            {
                if(number% denominator == 0)
                {
                    count++;
                }
                denominator--;
            }
            if (count > 2)
            {
                return false;
            }
            else
            {
                return true;
            }

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class factorial
    {
        int result = 1;
        public int fact(int x)
        {
            while (x != 0)
            {
                result = result * x;
                x--;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class Reverse_Number
    {
        public static int Reverse(int number)
        {
            int remainder = 0, reverse = 0;
            while(number!=0)
            {
                remainder=number % 10;
                reverse = remainder + (reverse * 10);
                number=number/10;
            }
            return reverse;
        }
        

    }
}

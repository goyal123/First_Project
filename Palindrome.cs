using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class Palindrome
    {
        public static void Palindrome_check(int reversed_number,int original_number)
        {
            if(reversed_number== original_number)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
            
    }
}

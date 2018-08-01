using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bouns16
{
    class Validator
    {
        public static int Validator()
        {
            int x = 0;
            while (true)
            {
                Console.WriteLine("How a many cars are you entering?");
                
                try
                {
                    x= int.Parse(Console.ReadLine());
                    if (x > 0)
                    {
                        return x;
                    }

                    else
                    {
                        Console.WriteLine("Value must be greater than zero!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //throw;
                }

                
            }
        }

            
    }
}

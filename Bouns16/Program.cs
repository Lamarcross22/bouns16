using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bouns16
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt
            Console.WriteLine("Welcome to the Grand Circus Motors Admin console!");
            Console.WriteLine("How many cars are you entering");
            int x = Validator.Validator();

            //making a car list
            List<Car> Lotz = new List<Car>();

            //set amount of times from the users input
            for (int i = 0; i < x; i++)
            {
                string str1;
                string str2;
                int int1;
                double dbz;
                Console.WriteLine("Please put your make");
                str1=Console.ReadLine();
                Console.WriteLine("please enter your model");
                str2=Console.ReadLine();
                Console.WriteLine("Please enter your year");
                int1=int.Parse(Console.ReadLine());
                Console.WriteLine("Pleae enter your price");
                dbz=double.Parse(Console.ReadLine());
                Lotz.Add(new Car(str1, str2, int1, dbz));
            }

            foreach ( Car cars in Lotz)
            {
                cars.ToString();
            }




        }
    }
}

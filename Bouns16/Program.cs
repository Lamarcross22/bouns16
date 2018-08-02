using System;
using System.Collections.Generic;

namespace Bouns16
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt
            Console.WriteLine("Which car would you like?");
            
            int x = Validator.Validator();

            //making a car list
            List<Car> stock = new List<Car>();


            stock.Add(new UsedCars());
            stock.Add(new UsedCars());
            stock.Add(new UsedCars(stock[3], 15000));
            stock.Add(new Car("Jaguar", "XF", 2019, 95000));
            stock.Add(new Car());
            stock.Add(new Car("Chevy", "Camero", 2016, 24000));



            // ending prompt
            string continueChoice = Validator.ContinueChoiceValidator("Would you like to buy another one?");



            if (continueChoice.ToLower() == "y" | continueChoice.ToLower() == "yes")

            {

                Console.Clear();

            }
        }



        ////set amount of times from the users input
        //for (int i = 0; i < x; i++)
        //{
        //    string str1;
        //    string str2;
        //    int int1;
        //    double dbz;
        //    Console.WriteLine("Please put your make");
        //    str1=Console.ReadLine();
        //    Console.WriteLine("please enter your model");
        //    str2=Console.ReadLine();
        //    Console.WriteLine("Please enter your year");
        //    int1=int.Parse(Console.ReadLine());
        //    Console.WriteLine("Pleae enter your price");
        //    dbz=double.Parse(Console.ReadLine());
        //    Lotz.Add(new Car(str1, str2, int1, dbz));
        //}

        //foreach ( Car cars in Lotz)
        //{
        //    cars.PrintInfo();
        //}




    }
    }


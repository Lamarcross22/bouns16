using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouns16
{
    class Car
    {
        private string carMake;
        private string carModel;
        private int caryear;
        private double price;

        // Properties
        public string Make { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public double Price { set; get; }
        public double Mileage { get; set; }

        // default constructor (takes no param)

        public Car()
        {
            Make = "not assigned";
            Model = "not assigned";
            Year = 2018;
            Price = 4500.00;
        }

        // overload constructor 

        public Car(string ma, string mo, int yr, double p)
        {
            Make = ma;
            Model = mo;
            Year = yr;
            Price = p;
        }

        // virtual method

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Make,-15} {Model,-15} {Year,-15} {Price,-15}");
        }
    }
}



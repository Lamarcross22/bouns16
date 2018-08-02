using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouns16
{
    class UsedCars : Car
    {
        private double carMileage;

        public double CarMileage
        {
            set => Mileage = value;

            get => Mileage;
        }

        public UsedCars(Car car, int usedmodel)
        {
            carMileage = 1500;
        }

        public UsedCars(string usedcar, string usedmodel, int usedyear, double usedPrice, double usedCarMileage) : base(
            usedcar, usedmodel, usedyear, usedPrice)

        {
            CarMileage = usedCarMileage;
        }

        public UsedCars()
        {
        }

        public override void Printinfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{CarMileage}");
        }
    }




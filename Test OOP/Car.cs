using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    enum Fuel
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid,
    }
    class Car
    {
        public string CarBrand { get; set; }
        public string CarModel {  get; set; }
        public string CarColor {get; set; }
        public int MakeYear { get; set; }
        public Fuel Fuel { get; set; } 
        public Car(string carBrand, string carModel, string carColor,int makeYear,Fuel fuel)
        {
            CarModel = carModel;
            CarBrand = carBrand;
            CarColor = carColor;
            MakeYear = makeYear;
            Fuel = fuel;
        }

    }
}

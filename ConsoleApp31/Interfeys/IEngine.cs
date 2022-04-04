using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31.Interfeys
{
   interface IEngine
    {
        int HorsePower { get; set; }
        double TankSize { get; set; }
        double CurrentOil { get; set; }
        string FuelType { get; set; }
        
        public double RemainOilAmount(double TankSize, double CurrentOil)
        {
            double result = 0;
            result = TankSize - CurrentOil;

            return result;
        }
    }
}

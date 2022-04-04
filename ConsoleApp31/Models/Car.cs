using ConsoleApp31.Interfeys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31.Models
{
   public class Car: ITransmission,IWheel,IEngine
    {
      
        public int DoorCount { get; set; }
        public string WinCode { get; set; }
        
        public string TransmissionKind { get ; set; }
        public int WheelThickness { get ; set ; }

        public int HorsePower { get ; set; }
        public double TankSize { get ; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

       public void ShowInfo()
        {
            Console.WriteLine($"");
        }
    }
}

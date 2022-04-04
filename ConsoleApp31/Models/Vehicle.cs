using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp31.Models
{
   abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }

        public abstract double  AverageSpeed(double driveTime, double drivePath)
        {
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}

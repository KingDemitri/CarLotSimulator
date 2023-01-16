using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        { 
        CarLot.numberOfCars++;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }
    
        public void TheEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{Make} Engine Noise: {engineNoise}");
        }
        public void TheHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{Make} Honk Noise: {honkNoise}");
        }

        public void CanYouDrive(bool isDriveable)
        {
            Console.WriteLine(isDriveable);
        }

           
    }
}
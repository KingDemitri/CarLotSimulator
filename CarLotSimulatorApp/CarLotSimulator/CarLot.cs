using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public CarLot() 
        { 
        }
        public List<Car> ListOfCars { get; set; } = new List<Car>();

        //create a field
        //variable declared inside the class

        public static int numberOfCars = 0;
    }
}

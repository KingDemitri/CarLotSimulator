using CarLotSimulator;
using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //create an instance
            CarLot carLot = new CarLot();   

            Car luxury = new Car();
            luxury.Make = "Lamborghini";
            luxury.Model = "Aventador (LP 700-4)";
            luxury.Year = 2011;
            luxury.EngineNoise = "vroom";
            luxury.HonkNoise = "screech";
            luxury.IsDriveable = "isDriveable";

            carLot.ListOfCars.Add(luxury);

            //dot notation

            Car discontinued = new Car();
            discontinued.Make = "Toyota";
            discontinued.Model = "MR2";
            discontinued.Year = 1991;
            discontinued.EngineNoise = "Boring";
            discontinued.HonkNoise= "Default";
            discontinued.IsDriveable = "isDriveable";

            carLot.ListOfCars.Add(discontinued);

            //Discontinued.TheEngineNoise();

            //object initializer syntax
            //List<int> list = new List<int> { 1,2,3 };
            //list.Add(5);

            Car current = new Car();
            current.Make = "Dynacraft";
            current.Model = "Spider-Man 6V Super Car";
            current.Year = 2022;
            current.EngineNoise = "With Great Power Comes Great Responsibility";
            current.HonkNoise = "*Spiderman Theme Song*";
            current.IsDriveable = "isDriveable";

            carLot.ListOfCars.Add(current);

            foreach (var car in carLot.ListOfCars)
            {
                Console.WriteLine($"Year:{car.Year} \nMake:{car.Make} \nModel:{car.Model}");

                car.TheEngineNoise(car.EngineNoise);
                car.TheHonkNoise(car.HonkNoise);

                Console.WriteLine();
            }
            ////////////////
            ///
            ///////////////

            //Static Keyword - Exercise 2
            Console.WriteLine($"Number of Cars: {CarLot.numberOfCars}");


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
//Static Keyword Exercise 2
//Building on our car lot simulator project, create a CarLot class with a static field called numberOfCars.

//    Have this number only increment when in our program we create a new Car.
//    From there create 3 cars in the Main() and then each time you create a car, do a Console.WriteLine() printing the current number of cars in the car lot. 
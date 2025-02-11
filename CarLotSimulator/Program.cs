﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carlot = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //dot notation
            var chevy = new Car();
            chevy.Make = "Chevy";
            chevy.Model = "Traverse";
            chevy.Year = 2015;
            chevy.IsDriveable = true;
            chevy.EngineNoise = "vroom vroom";
            chevy.HonkNoise = "boom boom";

            carlot.ParkingLot.Add(chevy);

            //Object Initializer Syntax
            var jeep = new Car()
            {
                Make = "Jeep",
                Model = "Grand Cherokee",
                Year = 2017,
                IsDriveable = true,
                EngineNoise = "push to start",
                HonkNoise = "beep beep",
            };

            carlot.ParkingLot.Add(jeep);

            //Custom Constructor
            var nissan = new Car("Nissan","Rogue",2012, true,"vroom vroom","boop boop");

            carlot.ParkingLot.Add(nissan);

            Console.WriteLine("Chevy");
            chevy.MakeEngineNoise(chevy.EngineNoise);
            chevy.MakeHonkNoise(chevy.HonkNoise);
            Console.WriteLine();

            Console.WriteLine("Jeep");
            jeep.MakeEngineNoise(jeep.EngineNoise);
            jeep.MakeHonkNoise(jeep.HonkNoise);
            Console.WriteLine();

            Console.WriteLine("Nissan");
            nissan.MakeEngineNoise(nissan.EngineNoise);
            nissan.MakeHonkNoise(nissan.HonkNoise);
            Console.WriteLine();


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of Cars Created: {CarLot.numberOfCars}");


            foreach (var car in carlot.ParkingLot)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }
        }
    }
}

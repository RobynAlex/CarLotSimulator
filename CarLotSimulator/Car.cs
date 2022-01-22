using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string make, string model,int year, bool isDriveable, string engineNoise, string honkNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }
            
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public bool IsDriveable { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
        


           


            public void MakeEngineNoise (string engineNoise)
             {
                     Console.WriteLine($"{engineNoise}");
             }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{honkNoise}");
        }
        

        
            






        

           
            


































    }
}

using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Console.WriteLine($"Car created: {CarLot._numberOfCars}\n");
            
            var carOne = new Car();
            carOne.Make = "Chevy";
            carOne.Model = "Silverado";
            carOne.Year = 2005;
            carOne.IsDriveable = true;
            carOne.MakeEngineNoise("Good");
            carOne.MakeHonkNoise("Weak");
            
            Console.WriteLine($"Car created: {CarLot._numberOfCars}\n");

            
            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Nissan", 
                Model = "350z", 
                Year = 2004, 
                IsDriveable = false
            };
            carTwo.MakeEngineNoise("MissFire");
            carTwo.MakeHonkNoise("Good");
            carLotOne.ParkingLot.Add(carTwo);
            Console.WriteLine($"Car created: {CarLot._numberOfCars}\n");
            
            var carThree = new Car("Ford", "Mustang", 1964 ,true);
            carThree.MakeEngineNoise("Good");
            carThree.MakeHonkNoise("Good");
            
            Console.WriteLine($"Car created: {CarLot._numberOfCars}\n");

           
            carLotOne.ParkingLot.Add(carThree);



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("List of parking lot items:");
            
            carLotOne.CheckCars();
        }
    }
}

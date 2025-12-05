using System;

namespace CarLotSimulator;

//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property


public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"{Make} - {Model} has an engine noise that sounds : {EngineNoise}.");
    }

    public void MakeHonkNoise(String honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"{Make} {Model} has a honk noise that sounds : {honkNoise}.");
    }

    public Car()
    {
        CarLot._numberOfCars++;
    }

    public Car(string make, string model, int year, bool isDriveable)
    {
        Make = make;
        Model = model;
        Year = year;
        IsDriveable = isDriveable;
        CarLot._numberOfCars++;
        
        
    }
    
}

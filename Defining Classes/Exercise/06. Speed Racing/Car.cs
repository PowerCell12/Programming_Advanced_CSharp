using System;

namespace Final;

public class Car{


    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double Travelleddistance { get; set; }


    public Car(string model, double fuelamount, double fuelcons)
    {
        Model = model;
        FuelAmount = fuelamount;
        FuelConsumptionPerKilometer = fuelcons;
        Travelleddistance = 0;
    }


    public void Drive(double distance)
    {

          if (FuelAmount - FuelConsumptionPerKilometer * distance >= 0) // if error do just >
        {
            FuelAmount -= FuelConsumptionPerKilometer * distance;
            Travelleddistance += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }

    }





}
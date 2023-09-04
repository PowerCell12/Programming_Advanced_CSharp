using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace CarManufacturer
{
 class Car
 {
 
    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;

    public Car(){
      Make = "VW";
      Model = "Golf";
      Year = 2025;
      FuelQuantity = 200;
      FuelConsumption = 10;
    }

    public Car(string make, string model, int year): this()
    {
      this.Make = make;
      this.Model = model;
      this.Year = year;
    
    } 

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption): this(make, model, year)
    {
      this.FuelQuantity = fuelQuantity;
      this.FuelConsumption = fuelConsumption;
    }


    public string Model {get; set;}
    public string  Make {get; set;}
    public int Year {get; set;}
    public double FuelQuantity {get; set;}
    public double FuelConsumption {get; set;}


    public void Drive(double distance){

      if (this.FuelQuantity - distance * this.FuelConsumption > 0){
         this.FuelQuantity -= distance * this.FuelConsumption;
      }
      else{
         Console.WriteLine("Not enough fuel to perform this trip!");
      }
    }


    public string WhoAmI(){
      return $"Make {this.Make}\nModel {this.Model}\nYear {this.Year}\nFuel {this.FuelQuantity:F2}";
    }


 }
}
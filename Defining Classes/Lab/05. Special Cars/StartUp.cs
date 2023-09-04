using Microsoft.VisualBasic;

namespace CarManufacturer
{
 public class StartUp
 {
 static void Main()
 {



    List<List<Tire>> all_tires = new List<List<Tire>>();
    while (true){
        List<string> command = Console.ReadLine().Split().ToList();

        if (command[0] == "No"){
            break;
        }

        List<Tire> tires = new List<Tire>();
        for (int i = 0; i < command.Count; i+=2){
            Tire tire = new Tire(int.Parse(command[i]), double.Parse(command[i+1]));
            tires.Add(tire);
        }
        all_tires.Add(tires);
    }

    List<Engine> all_engines = new List<Engine>();




    while(true){

        List<string> engines = Console.ReadLine().Split().ToList();

        if (engines[0] == "Engines"){
            break;
        }

        Engine engine = new Engine(int.Parse(engines[0]), double.Parse(engines[1]));
        all_engines.Add(engine);

    }




    List<Car> cars = new List<Car>();

    while (true){
        List<string> car = Console.ReadLine().Split().ToList();

        if (car[0] == "Show"){break;}

        Car car_final = new Car(car[0], car[1], int.Parse(car[2]), double.Parse(car[3]), double.Parse(car[4]), all_engines[int.Parse(car[5])], all_tires[int.Parse(car[6])].ToArray());

        cars.Add(car_final);
    }

    foreach(Car car in cars){
        double sum_tire_pressure = 0;
        foreach(var tire in car.Tires){
            sum_tire_pressure += tire.Pressure;
        }

        if (car.Year >= 2017 && car.Engine.HorsePower > 330 && sum_tire_pressure > 9 && sum_tire_pressure < 10){
            double to_give = 20 * 0.01;
            car.Drive(to_give);
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
        }
    }

 }
 }
}
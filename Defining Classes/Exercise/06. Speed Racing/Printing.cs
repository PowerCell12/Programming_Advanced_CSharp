using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final;

public static class Printing
{

   public static void Main(string[] args)
    {

        int lines = int.Parse(Console.ReadLine());
        List<Car> all_cars = new List<Car>();


        for (int i = 0; i < lines; i++)
        {

            List<string> commands = Console.ReadLine().Split(' ').ToList();

            Car car = new Car(commands[0], double.Parse(commands[1]), double.Parse(commands[2]));

            all_cars.Add(car);


        }

        while (true)
        {
            List<string> commands = Console.ReadLine().Split().ToList();

            if (commands[0] == "End")
            {
                break;
            }

            foreach(var car in all_cars)
            {
                if (car.Model == commands[1])
                {
                    car.Drive(double.Parse(commands[2]));
                }
            }
        }


        foreach(var car in all_cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Travelleddistance}");
        }



    }



}


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
        List<Car> cars = new List<Car>();

        for (int i = 0; i < lines; i++){

            List<string> commands = Console.ReadLine().Split().ToList();

            Tire first_tire =  new Tire(double.Parse(commands[5]), int.Parse(commands[6]));
            Tire second_tire = new Tire(double.Parse(commands[7]), int.Parse(commands[8]));
            Tire third_tire = new Tire(double.Parse(commands[9]), int.Parse(commands[10]));
            Tire fourth_tire = new Tire(double.Parse(commands[11]), int.Parse(commands[12]));


            cars.Add(new Car(commands[0], new Engine(int.Parse(commands[1]), int.Parse(commands[2])), new Cargo(int.Parse(commands[3]), commands[4]), new List<Tire>() { first_tire, second_tire, third_tire, fourth_tire }));        
        }

        string type = Console.ReadLine();

        foreach(var car in cars){
            
            if (type == "fragile"){

                bool bool1 = false;
                foreach(var tire in car.Tires){
                    if (tire.pressure < 1){
                        bool1 = true;
                        break;
                    }
                }

                if (bool1 && car.Cargo.type == type){
                    Console.WriteLine(car.Model);
                }

            }
            else{

                if (car.Cargo.type == type && car.Engine.power > 250){
                    Console.WriteLine(car.Model);
                }

            }




        }



    }

}
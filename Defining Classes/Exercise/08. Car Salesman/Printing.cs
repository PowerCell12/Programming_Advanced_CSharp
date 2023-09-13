using System.ComponentModel.Design;
using Final;

int lines = int.Parse(Console.ReadLine());
List<Engine> all_engines = new List<Engine>();

for (int i = 0; i < lines; i++){

    List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

    Engine engine = null;


    if (command.Count == 3){

        if (int.TryParse(command[2], out int a)){
            engine = new Engine(command[0], int.Parse(command[1]), int.Parse(command[2]));
        }
        else{
            engine = new Engine(command[0], int.Parse(command[1]), -10, command[2]);
        }
    }
    else if (command.Count == 4){
        engine  = new Engine(command[0], int.Parse(command[1]), int.Parse(command[2]), command[3]); 
    }
    else if (command.Count == 2){
        engine = new Engine(command[0], int.Parse(command[1]));
    }

    all_engines.Add(engine);
}


int lines1 = int.Parse(Console.ReadLine());
List<Car> all_cars = new List<Car>();

for (int i = 0; i < lines1; i++){

    List<string> command1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
    Engine engine = null;

    foreach(var item in all_engines){
        if (item.Model == command1[1]){
            engine = item;
            break;
        }
    }

    Car car = null;
    int a;

    if (command1.Count == 3){
        
        
        if (int.TryParse(command1[2], out a)){
            car = new Car(command1[0], engine, int.Parse(command1[2]));
        }
        else{
            car = new Car(command1[0], engine, -10, command1[2]);
        }
    }    
    else if (command1.Count == 4){
        car = new Car(command1[0], engine, int.Parse(command1[2]), command1[3]);
    }
    else if (command1.Count == 2){
        car = new Car(command1[0], engine);
    }

    all_cars.Add(car);


}


foreach(var car in all_cars){
    Console.WriteLine($"{car.Model}:\n {car.Engine.Model}:\n  Power: {car.Engine.Power}\n  Displacement: {(car.Engine.Displacement == -10 ? "n/a" : car.Engine.Displacement)}\n   Efficiency: {car.Engine.Efficiency}\n Weight: {(car.Weight == -10 ? "n/a" : car.Weight)}\n Color: {car.Color}");
}
namespace SoftUniParking;

public class Parking{

    private List<Car> cars;
    private int capacity;


    public Parking(int Capacity){
        this.capacity = Capacity;
        this.Cars = new List<Car>();
    }

    public List<Car> Cars  {get {return cars;} set{cars = value;}}

    public int Count { get { return cars.Count; } }
    
    public string AddCar(Car Car){

        foreach(var car in cars){
            if (car.RegistrationNumber == Car.RegistrationNumber){
                return "Car with that registration number, already exists!";
            }
        }


        if (cars.Count == capacity){
            return "Parking is full!";
        }

        cars.Add(Car);
        return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
    }


    public string RemoveCar(string RegistrationNumber){

        Car to_remove = null;
        bool bool1 = false;
        foreach(var car in cars){

            if (car.RegistrationNumber == RegistrationNumber){
                to_remove = car;
                bool1 = true;
            }
        }

        if (!bool1){
            return "Car with that registration number, doesn't exist!";
        }
        else{
                cars.Remove(to_remove);
                return $"Successfully removed {to_remove.RegistrationNumber}";
            
        }
    }


    public Car GetCar(string RegistrationNumber){
        Car car_final = null;

        foreach(var car in cars){
            if (car.RegistrationNumber == RegistrationNumber){
                car_final = car;
                break;
            }
        }

        return car_final;

    }

    public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers){

        foreach(var regnumber in RegistrationNumbers){

            for (int i  =0 ;i < cars.Count; i++){
                if (cars[i].RegistrationNumber == regnumber){
                    cars.RemoveAt(i);
                    break;
                }
            
            }


        }
    }


}
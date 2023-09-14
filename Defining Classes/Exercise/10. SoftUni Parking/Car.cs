namespace SoftUniParking;

public class Car{

    public string Make {set; get;}
    public string Model {set; get;}
    public int HorsePower {set; get;}
    public string RegistrationNumber { set; get;}

    public Car(string make, string model, int horsepower, string reginumber){
        this.Make = make;
        this.Model = model;
        this.HorsePower = horsepower;
        this.RegistrationNumber = reginumber;
    }


    public override string ToString(){
        return $"Make: {this.Make}\nModel: {this.Model}\nHorsePower: {this.HorsePower}\nRegistrationNumber: {this.RegistrationNumber}";
    }


}
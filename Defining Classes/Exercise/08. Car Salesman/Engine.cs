namespace Final;


public class Engine{

    public string Model { get; set;}
    public int Power {get; set;}
    public int Displacement {get; set;}
    public string Efficiency {get; set;}

    public Engine(string model, int power, int displacement = -10, string efficiency = "n/a"){
        this.Model = model;
        this.Power = power;
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }


}
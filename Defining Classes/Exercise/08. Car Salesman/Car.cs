namespace Final;


public class Car{

    public string Model {set; get;}
    public Engine Engine {set; get;}
    public int Weight {set; get;}
    public string Color {set; get;}


    public Car(string model, Engine engine, int  weight = -10, string color = "n/a"){
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }

}
namespace Final;

public class Cargo{


    public string type { get; set; }
    public int weight {get; set;}


    public Cargo(int Weight, string Type){
        weight = Weight;
        type = Type;
    }

}
public class Box<T>{

    private List<T> storage;

    public Box()
    {
        Storage  = new List<T>();
    }

    public List<T> Storage {set {storage = value;} get {return storage;}}


    public override string ToString()
    {

        string final = "";

        foreach(var st in storage){

            final += $"{typeof(T).FullName}: {st}\n";

        }

        return final;

    }


}
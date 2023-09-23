public class Box<T> where T: IComparable<T>{

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

    public string Swap(int first, int second){

        T temp = storage[first];
        storage[first] = storage[second];
        storage[second] = temp;

        string final = "";

        foreach(var thing in Storage){

            final += $"{typeof(T).FullName}: {thing}\n";
        }

        return final;


    }


    public int Bigger(List<T> values, T to_be_bigger_than ){

        int count = 0;

        foreach(var thing in values){

            if (thing.CompareTo(to_be_bigger_than) == 1){
                count++;
            }
        }

        return count;


    }



}
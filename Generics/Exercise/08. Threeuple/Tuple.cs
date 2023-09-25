namespace GenericScale;

public class Tuple<T1, T2, T3>{

    public T1 first { get; set; }
    public T2 second { get; set; }

    public T3 third {get; set;}

    public Tuple(T1 first, T2 second, T3 third){
        this.first = first;
        this.second = second;
        this.third = third;
    }



}
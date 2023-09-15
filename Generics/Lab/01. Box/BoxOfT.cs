using System.Data.SqlTypes;

namespace BoxOfT;

public class  Box<T>{

    private int count;
    private List<T> final;


    public  Box()
    {
        this.final = new List<T>();        
    }



    public int Count { get {return count;}}


    public void Add(T element){
        count++;
        this.final.Add(element);
    }


    public T Remove(){

        T removed_elemenet = final[final.Count - 1];
        final.Remove(removed_elemenet);
        count--;

        return removed_elemenet;

    }



}
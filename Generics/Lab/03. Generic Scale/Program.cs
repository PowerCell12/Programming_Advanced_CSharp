namespace GenericScale;

public class StartUp{

    public static void Main(string[] args){

        EqualityScale<int> final = new EqualityScale<int>(12, 12);


        Console.WriteLine(final.AreEqual());



    }

}
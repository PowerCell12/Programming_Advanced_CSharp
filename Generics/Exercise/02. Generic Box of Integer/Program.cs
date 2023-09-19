namespace GenericScale;

public class StartUp{

    public static void Main(string[] args){

        Box<int> box = new Box<int>();


        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++){

            int integers = int.Parse(Console.ReadLine());

            box.Storage.Add(integers);


        }

        Console.WriteLine(box.ToString());



    }

}
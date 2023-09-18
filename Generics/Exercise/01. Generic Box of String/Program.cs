namespace GenericScale;

public class StartUp{

    public static void Main(string[] args){

        Box<string> box = new Box<string>();


        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++){

            string strings = Console.ReadLine();

            box.Storage.Add(strings);


        }

        Console.WriteLine(box.ToString());



    }

}
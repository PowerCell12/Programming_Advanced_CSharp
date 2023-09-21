namespace GenericScale;

public class StartUp{

    public static void Main(string[] args){

        Box<int> box = new Box<int>();


        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++){

            int strings = int.Parse(Console.ReadLine());

            box.Storage.Add(strings);


        }

        
        List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();

        Console.WriteLine(box.Swap(indexes[0], indexes[1]));
    }

}
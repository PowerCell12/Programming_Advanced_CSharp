namespace GenericScale;

public class StartUp{

    public static void Main(string[] args){

        int lines = int.Parse(Console.ReadLine());
        List<string> values = new List<string>();


        for (int i = 0; i < lines; i++){

            string input = Console.ReadLine();

            values.Add(input);

        }

        string compared_to = Console.ReadLine();

        Box<string> box = new Box<string>();

        Console.WriteLine(box.Bigger(values, compared_to));

    }


}
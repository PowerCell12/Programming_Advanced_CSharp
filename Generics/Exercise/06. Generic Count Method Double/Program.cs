namespace GenericScale;

public class StartUp{

    public static void Main(string[] args){

        int lines = int.Parse(Console.ReadLine());
        List<double> values = new List<double>();


        for (int i = 0; i < lines; i++){

            double input = double.Parse(Console.ReadLine());

            values.Add(input);

        }

        double compared_to = double.Parse(Console.ReadLine());

        Box<double> box = new Box<double>();

        Console.WriteLine(box.Bigger(values, compared_to));

    }


}
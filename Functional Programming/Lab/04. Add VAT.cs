class Learning
{
    public static void Main()
    {

        List<double> prices = Console.ReadLine().Split(", ").Select(double.Parse).Select(n => n * 1.2).ToList();

        foreach(var thing in prices){
            Console.WriteLine($"{thing:F2}");
        }


    }
}

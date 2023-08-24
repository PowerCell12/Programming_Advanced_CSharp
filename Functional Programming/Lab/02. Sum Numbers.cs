class Learning
{
    public static void Main()
    {

        Func<string, int> parser = n => int.Parse(n);
        // make the select

        List<int> final = Console.ReadLine().Split(", ").Select(parser).ToList();

        Console.WriteLine(final.Count);
        Console.WriteLine(final.Sum());


    }
}


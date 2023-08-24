class Learning
{
    public static void Main()
    {

        List<int> integers = Console.ReadLine().Split(", ").Select(int.Parse).Where((int x) => x % 2 == 0).OrderBy(x => x).ToList();

        Console.WriteLine(string.Join(", ", integers));



    }
}


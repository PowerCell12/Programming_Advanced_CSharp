class Learning
{
    public static void Main()
    {

        Func<string, bool> startsWithUpper = n => char.IsUpper(n[0]);

        List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(startsWithUpper).ToList();

        foreach(var thing in text){
            Console.WriteLine(thing);
        }

    }
}

using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Func<int[], int> final  = n => n.Min();

        Console.WriteLine(final(numbers));






    }
}

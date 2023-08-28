using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {


        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int number = int.Parse(Console.ReadLine());

        Predicate<int> predicate = x => x % number != 0;


        List<int> numbers_final = numbers.Where(x => predicate(x)).ToList();


        Func<List<int>, List<int>> func = numbers => {


            List<int> final1 = new List<int>();

            for (int i = numbers.Count; i > 0; i--)
            {
                final1.Add(numbers[i - 1]);
            }

            return final1;


        };

        Console.WriteLine(string.Join(" ", func(numbers_final)));





    }
}

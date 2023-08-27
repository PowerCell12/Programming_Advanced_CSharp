using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {

        string[] names = Console.ReadLine().Split().ToArray();

        Action<string[]> printing = n => {

            foreach(var thing in names){
                Console.WriteLine($"Sir {thing}");
            }
        };

        printing(names);


    }
}

using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {


        int length = int.Parse(Console.ReadLine());

        string[] names = Console.ReadLine().Split().Where(x => x.Length <= length).ToArray();


        foreach(var name in names){
            Console.WriteLine(name);
        }





    }
}

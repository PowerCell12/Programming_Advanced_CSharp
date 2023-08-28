using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {


        int barrier  = int.Parse(Console.ReadLine());

        List<string> names = Console.ReadLine().Split().ToList();

        foreach(var name in names){

            int count = 0;
            foreach(var letter in name){

                count += (int)letter;

            }

            if (count >= barrier){

                Console.WriteLine(name);
                break;

            }


        }




    }
}

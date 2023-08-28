using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {


        int range = int.Parse(Console.ReadLine());

        int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> numbers  = new List<int>();

        for (int i = 1; i <= range; i++){

            bool bool1 = false;
            foreach(int diveder in dividers){

                if (i % diveder != 0){
                    bool1 = true;
                    break;

                }

            }

            if (!bool1){
                numbers.Add(i);
            }
        }


        Console.WriteLine(string.Join(" ", numbers));




    }
}

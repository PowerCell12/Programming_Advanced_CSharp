using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {

        
        List<int> range = Console.ReadLine().Split().Select(int.Parse).ToList();
        string type  = Console.ReadLine();

        Predicate<int> if_odd = n => n % 2 != 0;
        Predicate<int> if_even = n => n % 2 == 0;
        List<int> final = new List<int>();

        if (type == "odd"){
            for (int i = range[0]; i <= range[1]; i++){
                if (if_odd(i)){
                    final.Add(i);
                }

            }
        }
        else{
            for (int i = range[0]; i <= range[1]; i++){
                if (if_even(i)){
                    final.Add(i);
                }
            }
        }

        foreach(var thing in final){
            Console.Write(thing + " ");
        }







    }
}

using System.Runtime.InteropServices;

namespace DefiningClasses{

    public class StartUp{

        public static void Main(string[] args){

            int lines = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < lines; i++){

                List<string> input = Console.ReadLine().Split().ToList();

                Person person = new Person(input[0], int.Parse(input[1]));

                family.AddMember(person);


            }

            Person final = family.GetOldestMember();
            Console.WriteLine($"{final.Name} {final.Age}");



        }

    }
}
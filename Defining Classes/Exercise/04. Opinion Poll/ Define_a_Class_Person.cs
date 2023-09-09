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


            List<Person> over_30 = new List<Person>();

            foreach(var thing  in family.members){

                if (thing.Age > 30){
                    over_30.Add(thing);
                }


            }

            List<Person> final = over_30.OrderBy(x => x.Name).ToList();

            foreach (var thing in final){
                Console.WriteLine($"{thing.Name} - {thing.Age}");
            }

        }

    }
}
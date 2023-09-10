using System.Runtime.InteropServices;

namespace DefiningClasses{

    public class StartUp{

        public static void Main(string[] args){

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateModifier final = new DateModifier();

            Console.WriteLine(final.difference(date1, date2));
        }

    }
}
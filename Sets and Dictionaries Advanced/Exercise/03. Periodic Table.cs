using System;

class Program {
    static void Main() {

        int rows = int.Parse(Console.ReadLine());

        SortedSet<string> set  = new SortedSet<string>();

        for (int i = 0; i < rows; i++){

            List<string> elements = Console.ReadLine().Split().ToList();

            foreach(var thing in elements){

                set.Add(thing);

            }
        }



        foreach(var thing in set){

            Console.Write($"{thing} ");

        }



    }
}

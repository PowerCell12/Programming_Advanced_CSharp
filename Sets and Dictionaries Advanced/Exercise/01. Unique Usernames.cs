using System;

class Program {
    static void Main() {

        int rows = int.Parse(Console.ReadLine());

        HashSet<string> names = new HashSet<string>();

        for (int i = 0; i < rows; i++){

            string name = Console.ReadLine();
            names.Add(name);

        }

        foreach(var thing in names){
            Console.WriteLine(thing);

        }


    }
}

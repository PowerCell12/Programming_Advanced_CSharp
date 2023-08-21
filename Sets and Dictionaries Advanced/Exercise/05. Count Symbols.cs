using System;

class Program {
    static void Main() {

        
        SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
        string sentence = Console.ReadLine();
        foreach(var thing in sentence){

            if (dict.ContainsKey(thing)){
                dict[thing]++;
            }
            else{
                dict[thing] = 1;
            }
        }

        foreach(var thing in dict){
            Console.WriteLine($"{thing.Key}: {thing.Value} time/s");
        }








    }
}

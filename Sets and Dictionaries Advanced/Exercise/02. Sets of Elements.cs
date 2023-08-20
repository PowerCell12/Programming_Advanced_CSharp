using System;

class Program {
    static void Main() {


        List<int> MandN = Console.ReadLine().Split().Select(int.Parse).ToList();

        HashSet<int> first = new HashSet<int>();
        HashSet<int> second = new HashSet<int>();

        for (int i = 0; i < MandN[0] + MandN[1]; i++){
            int number = int.Parse(Console.ReadLine());


            if (i < MandN[0]){
                first.Add(number);
            }
            else{
                second.Add(number);
            }
        }

        foreach(var thing in first){

            if(second.Contains(thing)){

                Console.Write($"{thing} ");

            }


        }


    }
}

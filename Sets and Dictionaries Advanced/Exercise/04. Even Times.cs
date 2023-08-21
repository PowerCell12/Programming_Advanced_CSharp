using System;

class Program {
    static void Main() {


        int rows = int.Parse(Console.ReadLine());

        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < rows; i++){
            int number = int.Parse(Console.ReadLine());


            if (dict.ContainsKey(number)){

                dict[number] += 1;

            }
            else{
                dict.Add(number, 1);
            }
        }


        foreach(var thing in dict){

            if (thing.Value % 2 == 0){
                Console.WriteLine(thing.Key);
            }

        }



    }
}

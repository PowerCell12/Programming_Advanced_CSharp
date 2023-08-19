using System;

class Program {
    static void Main() {

        Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

        int rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++){

            List<string> commands = Console.ReadLine().Split().ToList();

            if (dictionary.ContainsKey(commands[0])){
        
                if (dictionary[commands[0]].ContainsKey(commands[1])){


                        dictionary[commands[0]][commands[1]].Add(commands[2]);



                }


                else{

                    dictionary[commands[0]].Add(commands[1], new List<string>());
                    dictionary[commands[0]][commands[1]].Add(commands[2]);

                }
                

            
            }



            else{
                dictionary.Add(commands[0], new Dictionary<string, List<string>>());
                dictionary[commands[0]].Add(commands[1], new List<string>());
                dictionary[commands[0]][commands[1]].Add(commands[2]);
            }



        }


        foreach(var thing in dictionary){
            Console.WriteLine($"{thing.Key}:");
            foreach(var thing1 in thing.Value){
                Console.WriteLine($"{thing1.Key} -> {string.Join(", ", thing1.Value)}");
            }
        }





    }
}

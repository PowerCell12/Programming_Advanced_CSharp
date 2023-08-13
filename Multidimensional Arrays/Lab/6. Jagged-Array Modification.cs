using System;

class Program {
    static void Main() {


      int rows = int.Parse(Console.ReadLine());

      int[][] array = new int[rows][];

      for (int i = 0; i < rows; i++){

        array[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

      }


     while (true){

        List<string> commands = Console.ReadLine().Split().ToList();

        if (commands[0] == "END"){
            break;
        }

        if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) > rows - 1){
            Console.WriteLine("Invalid coordinates");
            continue;
        }

        if (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) > array[int.Parse(commands[1])].Length - 1){

            Console.WriteLine("Invalid coordinates");
            continue;
        }

        if (commands[0] == "Add"){
            array[int.Parse(commands[1])][int.Parse(commands[2])] += int.Parse(commands[3]);
        }

        if (commands[0] == "Subtract"){
            array[int.Parse(commands[1])][int.Parse(commands[2])] -= int.Parse(commands[3]);
        }
        }

        for (int i = 0 ; i < rows; i++){

            for (int j = 0; j < array[i].Length; j++){

                Console.Write(array[i][j] + " ");

            }

            Console.WriteLine("");




     }




    }
}

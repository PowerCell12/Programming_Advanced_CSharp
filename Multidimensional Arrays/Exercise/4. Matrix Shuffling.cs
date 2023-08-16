using System;

class Program {
    static void Main() {



        List<int> rowcolumn = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string[,] matrix = new string[rowcolumn[0], rowcolumn[1]];

        for (int i = 0 ; i < rowcolumn[0]; i++){

            List<string> row = Console.ReadLine().Split(' ').ToList();
            for (int j = 0; j < rowcolumn[1]; j++){

                matrix[i, j] = row[j];


            }

        } 


        while (true){

            List<string> command = Console.ReadLine().Split(' ').ToList();

            if (command[0] == "END"){
                break;
            }

            if (command[0] != "swap"){
                Console.WriteLine("Invalid input!");
                continue;
            }

            if (command.Count > 5){
                Console.WriteLine("Invalid input!");
                continue;
            }


            if (int.Parse(command[1]) > rowcolumn[0] || int.Parse(command[3]) > rowcolumn[0]){
                Console.WriteLine("Invalid input!");
                continue;
            }
            else if (int.Parse(command[2]) > rowcolumn[1] || int.Parse(command[4]) > rowcolumn[1]){
                Console.WriteLine("Invalid input!");
                continue;
            }

            string temp = matrix[int.Parse(command[1]), int.Parse(command[2])];
            matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
            matrix[int.Parse(command[3]), int.Parse(command[4])] = temp;
            for (int i = 0; i < rowcolumn[0]; i++){

                for (int j= 0; j < rowcolumn[1]; j++){

                  Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();

            }


        }





    }
}

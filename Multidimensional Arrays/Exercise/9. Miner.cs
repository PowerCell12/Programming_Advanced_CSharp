using System;

class Program {
    static void Main() {


        int rows = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, rows];

        List<string> commands = Console.ReadLine().Split().ToList();

        for (int i = 0; i < rows; i++){

            List<string> row = Console.ReadLine().Split().ToList();

            for (int j = 0; j < rows; j++){
                matrix[i, j] = row[j];
            }
        }

        int row_miner = 0;
        int column_miner = 0;
        int all_coal = 0;

        for (int i = 0; i < rows; i++){

            for (int j = 0; j < rows; j++){

                if (matrix[i, j] == "c"){
                    all_coal++;
                }

                if (matrix[i,j] == "s"){
                    row_miner = i;
                    column_miner = j;
                }

            }


        }

        bool bool1 = false;
        int coal_found = 0;
        foreach(var command in commands){


            if (command == "left"){

                if (column_miner - 1 >= 0){
                    column_miner--;
                }


            }
            else if (command == "right"){

                if (column_miner + 1 < rows){
                    column_miner++;
                }
            }
            else if(command == "up"){

                if (row_miner - 1 >= 0){
                    row_miner--;
                }

            }
            else if (command == "down"){
                if (row_miner + 1 < rows){
                    row_miner++;
                }
            }

            if (matrix[row_miner, column_miner] == "e"){
                Console.WriteLine($"Game over! ({row_miner}, {column_miner})");
                bool1 = true;
                break;
            }

            if (matrix[row_miner, column_miner] == "c"){
                coal_found++;
                matrix[row_miner, column_miner] = "*";
            }

            if (coal_found == all_coal){
                Console.WriteLine($"You collected all coals! ({row_miner}, {column_miner})");
                bool1 = true;
                break;
            }
        }

        if (!bool1){
            Console.WriteLine($"{all_coal  - coal_found} coals left. ({row_miner}, {column_miner})");
        }


    }
}

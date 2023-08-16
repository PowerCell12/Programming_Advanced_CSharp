using System;

class Program {
    static void Main() {

        int rows = int.Parse(Console.ReadLine());
        int[][] matrix  = new int[rows][];


        for (int i = 0; i < rows; i++){

            List<int>row = Console.ReadLine().Split().Select(int.Parse).ToList();
            matrix[i] = row.ToArray();
        }



        for (int i = 0; i < rows; i++){

            if (i + 1 == rows){
                continue;
            }

            if (matrix[i].Length == matrix[i + 1].Length){

                for (int j = 0; j < matrix[i].Length; j++){

                    matrix[i][j] *= 2;

                }

                for (int j = 0; j < matrix[i + 1].Length;j++){
                    matrix[i + 1][j] *= 2;
                }
            }
            else{

                for (int j = 0; j < matrix[i].Length; j++){

                    matrix[i][j] /= 2;

                }

                for (int j = 0; j < matrix[i + 1].Length;j++){
                    matrix[i + 1][j] /= 2;
                }
            


            }
        }


        while (true){

            List<string> command = Console.ReadLine().Split().ToList();

            if (command[0] == "End"){
                break;
            }

            if (command[0] == "Add"){

                if (int.Parse(command[1])  >  rows || int.Parse(command[1]) < 0){
                    continue;
                }

                if (int.Parse(command[2]) >= matrix[int.Parse(command[1])].Length || int.Parse(command[2]) < 0){
                    continue;
                }
                matrix[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
            }
            else if (command[0] == "Subtract"){

                if (int.Parse(command[1])  >  rows || int.Parse(command[1]) < 0){
                    continue;
                }
                else if (int.Parse(command[2]) >= matrix[int.Parse(command[1])].Length || int.Parse(command[2]) < 0){
                    continue;
                }
                matrix[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
            }



        }

        for (int i = 0; i < rows; i++){

            for (int j = 0; j < matrix[i].Length; j++){

                Console.Write(matrix[i][j] + " ");

            }

                Console.WriteLine();

        }







    }
}

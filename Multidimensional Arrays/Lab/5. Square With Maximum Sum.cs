using System;

class Program {
    static void Main() {


        int[] linesAndrows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int[,] matrix  = new int[linesAndrows[0], linesAndrows[1]];

        for (int i = 0; i < linesAndrows[0]; i++)
        {

            List<int> lines = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            for (int j = 0; j < linesAndrows[1]; j++)
            {
                matrix[i, j] = lines[j];
            }

        }

        int top = 0;
        int[] top1 = new int[4];

        for (int i = 0; i < linesAndrows[0]; i++){

            if (i + 1 == matrix.GetLength(0)){
                break;
            }

            for (int j = 0; j  < linesAndrows[1]; j++){

                if (j + 1 == linesAndrows[1]){
                    break;
                }

                int all = matrix[i, j]  + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if (all > top){
                    top  = all;
                    top1[0] = matrix[i, j];
                    top1[1] = matrix[i, j + 1];
                    top1[2] = matrix[i + 1, j];
                    top1[3] = matrix[i  + 1, j + 1];
                }
            }
        }

        Console.WriteLine($"{top1[0]} {top1[1]}");
        Console.WriteLine($"{top1[2]} {top1[3]}");
        Console.WriteLine($"{top}");


    }
}

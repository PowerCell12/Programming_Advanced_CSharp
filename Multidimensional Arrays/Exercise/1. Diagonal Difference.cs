using System;

class Program {
    static void Main() {


        int rows = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, rows];


        for (int i = 0; i < rows; i++){

            List<int> lsit = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int j = 0; j < rows; j++){
                matrix[i, j] = lsit[j];
            }
        }


        int sum_primary = 0;
        int sum_secondary = 0;

        for (int i = 0; i < rows; i++){
                sum_primary += matrix[i, i];
                sum_secondary += matrix[i, rows - 1 - i];
            }
        
        Console.WriteLine( Math.Abs(sum_primary - sum_secondary));

    }

}

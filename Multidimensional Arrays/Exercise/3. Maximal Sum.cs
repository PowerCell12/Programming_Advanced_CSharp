using System;

class Program {
    static void Main() {


     List<int> rowcolumn = Console.ReadLine().Split().Select(int.Parse).ToList();
     int[,] matrix = new int[rowcolumn[0], rowcolumn[1]];

     for (int i = 0; i < rowcolumn[0]; i++){

        List<int> row  = Console.ReadLine().Split().Select(int.Parse).ToList();
        for (int j = 0; j < rowcolumn[1]; j++){
            matrix[i, j] = row[j];
        }
     }


     int biggest_sum  = 0;
     List<int> biggest = new List<int>();

     for (int i = 0; i < rowcolumn[0]; i++){

        if (i + 1 == rowcolumn[0] - 1){
            break;
        }

        for (int j = 0; j < rowcolumn[1]; j++){

            if (j + 1 == rowcolumn[1] - 1){
                break;
            }
        
        
            if (matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j +2 ] > biggest_sum){
                biggest_sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j +2 ];
                biggest = new List<int>();
                biggest.Add(matrix[i, j]);
                biggest.Add(matrix[i, j + 1]);
                biggest.Add(matrix[i, j + 2]);
                biggest.Add(matrix[i + 1, j]);
                biggest.Add(matrix[i + 1, j + 1]);
                biggest.Add(matrix[i + 1, j + 2]);
                biggest.Add(matrix[i + 2, j]);
                biggest.Add(matrix[i + 2, j + 1]);
                biggest.Add(matrix[i + 2, j + 2]);
            }
        
        
        
        }
     }


     Console.WriteLine($"Sum = {biggest_sum}");
     for (int i = 0; i < biggest.Count; i++){
        if (i % 3 == 0  && i != 0){
            Console.WriteLine();
        }
      
         Console.Write(biggest[i] + " ");
     }


    }

}

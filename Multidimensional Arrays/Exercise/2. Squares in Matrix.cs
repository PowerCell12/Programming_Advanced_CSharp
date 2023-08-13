using System;

class Program {
    static void Main() {


     List<int>  rowcolumn = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
     string[,] matrix = new string[rowcolumn[0], rowcolumn[1]];

     for (int i = 0; i < rowcolumn[0]; i++){

        List<string>lines = Console.ReadLine().Split(' ').ToList();
        for (int j = 0; j < rowcolumn[1]; j++){
            matrix[i, j]  = lines[j];
        }
     }

     int count = 0;

     
     for (int i = 0; i < rowcolumn[0]; i++){

        if (i == rowcolumn[0] - 1){
            break;
        }

        for (int j = 0; j < rowcolumn[1]; j++){

            if (j == rowcolumn[1] - 1){
                break;
            }

            if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1]){
                count++;
            }


        }

     }


     Console.WriteLine(count);     


    }

}

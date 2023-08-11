using System;

class Program {
    static void Main() {


        List<int> RowColumn = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

        int[,] matrix = new int[RowColumn[0], RowColumn[1]];
        int all  =0;

        for (int i = 0; i  < RowColumn[0]; i++){
            
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            for (int j  = 0; j < RowColumn[1]; j++){
                
                matrix[i , j] =  numbers[j];
                all += matrix[i , j];


            }
        }


        Console.WriteLine(RowColumn[0]);
        Console.WriteLine(RowColumn[1]);
        Console.WriteLine(all);







    }
}

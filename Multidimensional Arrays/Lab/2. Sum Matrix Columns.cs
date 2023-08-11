using System;

class Program {
    static void Main() {

        int[] RowsColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int[,] matrix = new int[RowsColumns[0], RowsColumns[1]];


        for (int i = 0; i < RowsColumns[0]; i++)
        {
         
            List<int> Numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            for (int j = 0; j < RowsColumns[1]; j++)
            {
                matrix[i, j] = Numbers[j];
            }
        }
    
        int column = 0;
        for (int i = 0; i < RowsColumns[1]; i++)
        {
            for (int j = 0; j < RowsColumns[0]; j++)
            {

                column += matrix[j, i];


            }
 
            Console.WriteLine(column);
            column = 0;
            
    
 
        }



    }
}

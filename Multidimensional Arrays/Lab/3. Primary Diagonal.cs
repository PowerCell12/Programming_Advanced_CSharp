using System;

class Program {
    static void Main() {


    int rows = int.Parse(Console.ReadLine());

    int[,] matrix = new int[rows, rows];

    
    for (int i  =0; i < rows; i++)
    {
    
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
    
        for (int j = 0; j < rows; j++)
        {

            matrix[i, j] = numbers[j];

        }
    }



    int primal = 0;


    for (int i =0; i < rows; i++)
    {
        primal += matrix[i, i];
    }


    Console.WriteLine(primal);
    




    }
}

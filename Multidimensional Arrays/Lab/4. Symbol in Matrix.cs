using System;

class Program {
    static void Main() {

    
        int lines  = int.Parse(Console.ReadLine());
        int[,] matrix = new int[lines, lines];


        for (int i = 0; i < lines; i++){

            string input = Console.ReadLine();

            for (int j = 0; j < lines; j++){

                matrix[i, j] = (int)input[j];

            }
        }

        int to_find = (int)char.Parse(Console.ReadLine());
        bool bool1 = false;

        for (int i = 0; i < lines; i++){

            for (int j = 0; j < lines; j++){

                if (matrix[i, j] == to_find){
                    bool1 = true;
                    Console.WriteLine($"({i}, {j})");
                    break;
                }
            }
            if (bool1 == true){
                break;
            }
        }

        if (!bool1){
            Console.WriteLine($"{Convert.ToChar(to_find)} does not occur in the matrix");
        }





    }
}

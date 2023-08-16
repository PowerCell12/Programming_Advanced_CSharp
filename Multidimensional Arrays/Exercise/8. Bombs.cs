using System;

class Program {
    static void Main() {


        int rows = int.Parse(Console.ReadLine());
        int[,] matrix =  new int[rows, rows];

        for (int i = 0; i < rows; i++){

            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int j = 0; j < rows; j++){
                matrix[i, j] = line[j];
            }
        }


        List<string> coordinates = Console.ReadLine().Split().ToList();

        for (int i = 0; i < coordinates.Count; i++){

            List<int> coordinate = coordinates[i].Split(',').Select(int.Parse).ToList(); // first is row and then column

            if (matrix[coordinate[0], coordinate[1]] <= 0){

                continue;

            }        

            int explosion_strength = matrix[coordinate[0], coordinate[1]];
            matrix[coordinate[0], coordinate[1]] = 0;

            if (coordinate[0] - 1 >=0){
                if (matrix[coordinate[0] - 1, coordinate[1]] > 0){
                    matrix[coordinate[0] - 1, coordinate[1]] -= explosion_strength;
                }
            }

            if (coordinate[0] + 1 < rows){
                if (matrix[coordinate[0] + 1, coordinate[1]] > 0){
                    matrix[coordinate[0] + 1, coordinate[1]] -= explosion_strength;        
                }
            }

            if (coordinate[1] - 1 >= 0){
                if (matrix[coordinate[0], coordinate[1] - 1] > 0){
                    matrix[coordinate[0], coordinate[1] - 1] -= explosion_strength;       
                }
            }

            if (coordinate[1] + 1 < rows){
                if (matrix[coordinate[0], coordinate[1] + 1] > 0){
                    matrix[coordinate[0], coordinate[1] + 1] -= explosion_strength;        
                }
            }

            if (coordinate[0] - 1 >= 0 && coordinate[1] - 1 >= 0){
                if (matrix[coordinate[0] - 1, coordinate[1] - 1] > 0){
                    matrix[coordinate[0] - 1, coordinate[1] - 1] -= explosion_strength;        
                }
            }
        
            if (coordinate[0] - 1 >= 0 && coordinate[1] + 1 < rows){
                if (matrix[coordinate[0] - 1, coordinate[1] + 1] > 0){
                    matrix[coordinate[0] - 1, coordinate[1] + 1] -= explosion_strength;        
                }
            }

            if (coordinate[0] + 1 < rows && coordinate[1] - 1 >= 0){
                if (matrix[coordinate[0] + 1, coordinate[1] - 1] > 0){
                    matrix[coordinate[0] + 1, coordinate[1] - 1] -= explosion_strength;        
                }
            }

            if (coordinate[0] + 1 < rows && coordinate[1] + 1 < rows){
                if (matrix[coordinate[0] + 1, coordinate[1] + 1] > 0){
                    matrix[coordinate[0] + 1, coordinate[1] + 1] -= explosion_strength;        
                }
            }

        }


        int count = 0;
        int sum_of_all =0;

        for (int i = 0; i < rows; i++){

            for (int j = 0; j < rows; j++){

                if (matrix[i, j] > 0){
                    count++;
                    sum_of_all += matrix[i, j];
                }

            }
        }


        Console.WriteLine($"Alive cells: {count}");
        Console.WriteLine($"Sum: {sum_of_all}");

        for (int i = 0; i < rows; i++){

            for (int j = 0; j < rows; j++){

                Console.Write(matrix[i, j] + " ");

            }

            Console.WriteLine();

        }





    }
}

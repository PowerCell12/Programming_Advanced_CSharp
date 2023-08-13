using System;

class Program {
    static void Main() {


        int rows = int.Parse(Console.ReadLine());

        long[][] array = new long[rows][];

        for (int i = 0; i < rows; i++){

            array[i] = new long[i + 1];
            if (i == 0){
                array[i]  = new long[] {1};
                continue;
            }


            for (int j = 0; j < array[i].Length; j++){

              if (j == 0 || j == array[i].Length - 1){
                array[i][j] = 1;
              }
              else{
                 array[i][j]  = array[i - 1][j] + array[i - 1][j - 1];
              }
            }
        }


        for (int i = 0; i < rows; i++){

            for (int j = 0; j < array[i].Length; j++){
                Console.Write(array[i][j] + " ");
            }

            Console.WriteLine("");

        }





    }
}

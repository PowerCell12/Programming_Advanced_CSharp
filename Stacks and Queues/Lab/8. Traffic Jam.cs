using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  



    int to_pass = int.Parse(Console.ReadLine());
    Queue<string> cars = new Queue<string>();
    int all_passed = 0 ;

    while (true){

      string car = Console.ReadLine();


      if (car == "end"){
        Console.WriteLine($"{all_passed} cars passed the crossroads.");
        break;
      }


      if (car == "green"){

         int count  = 0;

         while (count != to_pass){

          if (cars.Count == 0){

            break;

          }

          string car1 = cars.Dequeue();
          Console.WriteLine($"{car1} passed!");
          count++;
          all_passed++;
          


         }



        continue;
      }

      cars.Enqueue(car);


    }


    

    }
  }

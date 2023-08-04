using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    List<string> name1 = Console.ReadLine().Split().ToList();

    Queue<string> names = new Queue<string>(name1);

    int remove = int.Parse(Console.ReadLine());

    int count = 0;

    while (names.Count != 1){

      count++;

      string name = names.Dequeue();


      if (count != remove){
        names.Enqueue(name);
      }
      else{
        Console.WriteLine($"Removed {name}");
        count = 0;
      }
    }

    Console.WriteLine($"Last is {names.Dequeue()}");



    

    }
  }

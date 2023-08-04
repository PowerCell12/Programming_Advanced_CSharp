using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  

    Queue<string> names = new Queue<string>();


    while (true){

      string name = Console.ReadLine();


      if (name == "End"){
        Console.WriteLine($"{names.Count} people remaining.");
        break;
      }

      if (name == "Paid"){
        foreach(var nm in names){
          Console.WriteLine(nm);
        }
        names.Clear();
        continue;
      }


      names.Enqueue(name);


    }

    

    }
  }

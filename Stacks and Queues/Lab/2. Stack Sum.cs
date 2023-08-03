using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
      
    while (true){

      List<string> command = Console.ReadLine().Split().ToList();

      if (command[0].ToUpper() == "END"){
        break;
      }

      string command1 = command[0].ToUpper();

      if (command1 == "ADD"){

        stack.Push(int.Parse(command[1]));
        stack.Push(int.Parse(command[2]));

      }
      else if (command1 == "REMOVE"){

        if (stack.Count < int.Parse(command[1])){

          continue;

        }

        for (int i = 0; i < int.Parse(command[1]); i++){
          
          stack.Pop();
        }

      }

      }



      Console.WriteLine($"Sum: {stack.Sum()}");





    }
  }

using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  

    Stack<int> nums = new Stack<int>();


    int lines  = int.Parse(Console.ReadLine());


    for (int i = 0; i < lines; i++) {

      List<string> commands = Console.ReadLine().Split(' ').ToList();

      if (commands[0] == "1"){

        nums.Push(int.Parse(commands[1]));

      }
      else if (commands[0] == "2"){

        nums.Pop();

      }
      else if (commands[0] == "3"){

        if (nums.Count > 0){
          Console.WriteLine(nums.Max());
        }
      }
      else if (commands[0] == "4"){

        if (nums.Count > 0){
          Console.WriteLine(nums.Min());
        }
      }


    }

    Console.WriteLine(string.Join(", ", nums));




    }
  }

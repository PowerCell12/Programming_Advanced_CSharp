using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    string[] expr = Console.ReadLine().Split().ToArray();

    Array.Reverse(expr);

    Stack<string> stack = new Stack<string>(expr);


    int final = int.Parse(stack.Pop());

    while (stack.Count > 0){

      string expr1 = stack.Pop();
      int number = int.Parse(stack.Pop());

      if (expr1 == "+"){

        final += number;

      }
      else if (expr1 == "-"){

        final -= number;

      }
    }

    Console.WriteLine(final);




    }
  }

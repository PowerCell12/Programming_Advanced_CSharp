using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  



    Stack<int> indexes = new Stack<int>();


    string expression = Console.ReadLine();


    
    for (int i = 0; i < expression.Length; i++) {
      char ch = expression[i];

      if (ch == '('){

        indexes.Push(i);


      }

      if (ch == ')'){

        Console.WriteLine(expression.Substring(indexes.Peek(), i  - indexes.Peek() + 1));
        indexes.Pop();


      }


    }



    }
  }

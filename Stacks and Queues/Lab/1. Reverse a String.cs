using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {


  string words = Console.ReadLine();

  Stack<char> reversed  = new Stack<char>();

  for (int i = 0; i < words.Length; i++){

    reversed.Push(words[i]);
    
  }


  foreach(char h in reversed){
    Console.Write(h);
  }

    
    
  }
}

using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    HashSet<string> set = new HashSet<string>();

    int lines = int.Parse(Console.ReadLine());

    for (int i = 0; i < lines; i++){
      
      string name = Console.ReadLine();

      set.Add(name);

      
    }

    foreach(var thing in set){
      Console.WriteLine(thing);
    }
    
    
    
  }
}

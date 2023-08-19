using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<int> integers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToList();

    for (int i = 0; i < 3; i++){

      if (i > integers.Count - 1){
        break;
      }

      Console.Write(integers[i] + " ");
      
      
    }

    
    

    
  }
}

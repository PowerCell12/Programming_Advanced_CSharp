using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    SortedDictionary<string, Dictionary<string, double>> dict = new SortedDictionary<string, Dictionary<string, double>>();

    while (true){

      List<string> things = Console.ReadLine().Split(", ").ToList();

      if (things[0] == "Revision"){
        break;
      }
      
      
      if (dict.ContainsKey(things[0])){

        if (dict[things[0]].ContainsKey(things[1])){
          dict[things[0]][things[1]] += double.Parse(things[2]);
        }
        else{
          dict[things[0]][things[1]] = double.Parse(things[2]);
        }
        
      }
      else{
        dict.Add(things[0], new Dictionary<string, double>());
        dict[things[0]].Add(things[1], double.Parse(things[2]));
      } 
    }

    foreach(var thing in dict){
      Console.WriteLine($"{thing.Key}->");

      foreach (var thing1 in thing.Value){
        Console.WriteLine($"Product: {thing1.Key}, Price: {thing1.Value}");
      }
    }
    
  
  }
}

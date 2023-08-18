using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int names = int.Parse(Console.ReadLine());
    Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();
    
    for (int i = 0; i < names; i++){

      List<string> name  = Console.ReadLine().Split().ToList();


      if (dict.ContainsKey(name[0])){
        dict[name[0]].Add(decimal.Parse(name[1]));
      }
      else{
        dict[name[0]] = new List<decimal>() {decimal.Parse(name[1])};
      }
    }

    foreach (var thing in dict){
      List<string> formatted = new List<string>();
      foreach(var what in thing.Value){
        formatted.Add($"{what:F2}");
      }

      Console.WriteLine($"{thing.Key} -> {string.Join(' ', formatted)} (avg: {Queryable.Average(thing.Value.AsQueryable()):F2})");
      
    }


    
  }
}

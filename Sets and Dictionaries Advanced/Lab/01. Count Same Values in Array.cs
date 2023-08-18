using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    Dictionary<double, int> dict =  new Dictionary<double, int>();

    List<double> integers = Console.ReadLine().Split().Select(double.Parse).ToList();

    foreach(var thing in integers){

      if (dict.ContainsKey(thing)){
        dict[thing] += 1;
      }
      else{dict[thing] = 1;}
    }



    foreach(var thing in dict){

      Console.WriteLine($"{thing.Key} - {thing.Value} times");
      
    }


    
  }
}

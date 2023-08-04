using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  

    
    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    Stack<int> num  = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());


    for (int i = 0 ; i < numbers[1]; i++){

      if (num.Count > 0){
        num.Pop();
      }


    }



    if (num.Count == 0){
      Console.WriteLine("0");
    }
    else{

      if (num.Contains(numbers[2])){
        Console.WriteLine("true");
      }
      else{
        Console.WriteLine(num.Min());
      }



    }







    

    }
  }

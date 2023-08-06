using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    int food = int.Parse(Console.ReadLine());


    Queue<int> nums = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());


    Console.WriteLine(nums.Max());
    bool bool1 = false;

    while (true){

      if (nums.Count == 0){
        bool1 = true;
        break;
      }

      else{

        if (nums.Peek() <= food){
          
          food -= nums.Peek();
          nums.Dequeue();
        }
        else{
          break;
        }

      }
    }

    if (bool1 == true){
      Console.WriteLine("Orders complete");
    }
    else{
      Console.WriteLine($"Orders left: {string.Join(" ", nums)}");
    }


    }
  }

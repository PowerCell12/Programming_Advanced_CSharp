using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    Stack<int> boxFull = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
    int capacity = int.Parse(Console.ReadLine());
    int rakcs = 1;
    int all = 0;

    while (true){

      if (boxFull.Count == 0){
        break;
      }

      int box = boxFull.Pop();

      all += box;

      if (all == capacity){
        all = 0;
        if (boxFull.Count > 0){
          rakcs++;
        }
      }
      else if (all > capacity){
        rakcs++;
        all = box;
      }
    }

    Console.WriteLine(rakcs);



    }
  }

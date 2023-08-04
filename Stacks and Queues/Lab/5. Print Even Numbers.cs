using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    Queue<int> queue = new Queue<int>(integers);
    List<int> list = new List<int>();


    while (queue.Count  > 0){

      int num = queue.Dequeue();


      if (num % 2 == 0){

        list.Add(num);

      }
    }


    Console.WriteLine(string.Join(", ", list));




    }
  }

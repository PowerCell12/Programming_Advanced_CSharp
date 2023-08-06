using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {  


    Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ").ToList());


    while (true){

      if (songs.Count == 0){
        break;
      }



      List<string> command = Console.ReadLine().Split(" ", 2).ToList();

      if (command[0] == "Play"){
        songs.Dequeue();
      }

      if (command[0] == "Add"){

        if (songs.Contains(command[1])){
          Console.WriteLine($"{command[1]} is already contained!");
        }
        else{
          songs.Enqueue(command[1]);
        }

      }

      if (command[0] == "Show"){
        Console.WriteLine(string.Join(", ", songs));
      }


    }

    Console.WriteLine("No more songs!");



    }
  }

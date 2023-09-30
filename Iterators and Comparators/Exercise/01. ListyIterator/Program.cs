using System;
using System.Collections.Generic;
using System.Linq;

namespace Final;

class Program {
  public static void Main (string[] args) {

    List<string> create_command = Console.ReadLine().Split(new char[] { ' ' }, 2).ToList();
    ListyIterator<string> final = null;
    
    if (create_command.Count > 1){
    
      List<string> final1 = create_command[1].Split().ToList();

    
      final = new ListyIterator<string>(final1);
    }
    else{
      final = new ListyIterator<string>(new List<string>());
    }
    
    
    while (true){

      string commands = Console.ReadLine();

      if(commands == "END"){
        break;
      }
      else if (commands == "Move"){
        Console.WriteLine(final.Move());
      }
      else if (commands == "Print"){
        Console.WriteLine(final.Print());
      }
      else if (commands == "HasNext"){
        Console.WriteLine(final.HasNext());
      }
      
        
    }
  
    
    
  }
}




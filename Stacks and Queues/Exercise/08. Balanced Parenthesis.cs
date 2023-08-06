using System;

class Program {
    static void Main() {


      string parent = Console.ReadLine();
      Stack<int> indx = new Stack<int>();
      bool bool1 = false;

      for (int i  = 0; i < parent.Length; i++){
        char par = parent[i];

        if (par == '(' || par == '{' || par == '[' ){

          indx.Push(i);
          continue;
        }

        if (indx.Count  < 1){
          bool1 = true;
          break;
        }

        if (par == ')'){

          if (parent[indx.Peek()] == '('){
            indx.Pop();
          }
          else{
            bool1 = true;
            break;
          }
        }

      if (par == '}'){

          if (parent[indx.Peek()] == '{'){
            indx.Pop();
          }
          else{
            bool1 = true;
            break;
          }
        }



      if (par == ']'){

          if (parent[indx.Peek()] == '['){
            indx.Pop();
          }
          else{
            bool1 = true;
            break;
          }
        }
    }


    if (bool1 == true){
      Console.WriteLine("NO");
    }
    else{
      Console.WriteLine("YES");
    }




    }
}

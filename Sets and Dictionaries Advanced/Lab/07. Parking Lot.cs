using System;

class Program {
    static void Main() {


        HashSet<string> set = new HashSet<string>();

        while (true){

            List<string> command = Console.ReadLine().Split(", ").ToList();

            if (command[0] == "END"){
                break;
            }


            if (command[0] == "IN"){
                set.Add(command[1]);
            }
            else{
                if (set.Contains(command[1])){
                    
                    set.Remove(command[1]);
                }
            }



        }


        if (set.Count >= 1){
            foreach(var thing in set){
                Console.WriteLine(thing);
            }
        }
        else{
            Console.WriteLine("Parking Lot is Empty");
        }



    }
}

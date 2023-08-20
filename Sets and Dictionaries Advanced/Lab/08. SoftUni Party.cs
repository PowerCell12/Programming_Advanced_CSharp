using System;

class Program {
    static void Main() {


        HashSet<string> party = new HashSet<string>();
        HashSet<string> party_vip = new HashSet<string>();


        while (true){

            string member = Console.ReadLine();

            if (member == "PARTY"){
                break;
            }

            if (char.IsNumber(member[0])){
                party_vip.Add(member);
                continue;
            }

            party.Add(member);


        }


        while (true){

            string member = Console.ReadLine();

            if (member == "END"){
                break;
            }


            if (char.IsNumber(member[0])){

                if (party_vip.Contains(member)){
                    party_vip.Remove(member);
                }


            }
            else{

                if (party.Contains(member)){
                    party.Remove(member);
                }

            }
        }

        Console.WriteLine(party.Count + party_vip.Count);

        foreach(var thing in party_vip){
            Console.WriteLine(thing);
        }


        foreach(var thing in party){
            Console.WriteLine(thing);
        }








    }
}

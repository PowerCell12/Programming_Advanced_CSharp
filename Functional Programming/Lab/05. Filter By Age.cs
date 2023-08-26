class Learning
{
    public static void Main()
    {


        Dictionary<string, int> person = new Dictionary<string, int>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++){
            List<string> person1 = Console.ReadLine().Split(", ").ToList();
            person.Add(person1[0], int.Parse(person1[1]));
        }

        string type   = Console.ReadLine();
        int threshhold  = int.Parse(Console.ReadLine());

        Func<int, Dictionary<string, int>> if_older =  x => { Dictionary<string, int> person_final  = new Dictionary<string, int>(); foreach (var thing in person){
       
       
       
                if (thing.Value >= x){
                    person_final.Add(thing.Key, thing.Value);
                }    
            }   

            return person_final;
        
        
        };


        Func <int, Dictionary<string, int>> if_younger =  x => { Dictionary<string, int> person_final  = new Dictionary<string, int>(); foreach (var thing in person){


                if (thing.Value < x){
                    person_final.Add(thing.Key, thing.Value);
                }


    
        }; 

            return person_final;

        };



        var final_person = new Dictionary<string, int>();

        if (type == "older"){
            final_person = if_older(threshhold);
        } else if (type == "younger"){
            final_person = if_younger(threshhold);
        }


        List<string> to_print = Console.ReadLine().Split().ToList();

        if (to_print.Count == 2){
            foreach(var thing in final_person){

                Console.WriteLine($"{thing.Key} - {thing.Value}");

            }
        }
        else{
            if (to_print[0] == "name"){
                foreach(var thing in final_person){
                    Console.WriteLine($"{thing.Key}");
                }
            }
            else{
                foreach(var thing in final_person){
                    Console.WriteLine($"{thing.Value}");
                }
            }
        }



    }
}

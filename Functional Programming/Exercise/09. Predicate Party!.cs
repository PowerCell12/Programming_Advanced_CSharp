using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {

        List<string> names = Console.ReadLine().Split().ToList();

        Func<string, string, bool> starts_with = (name, part) => name.StartsWith(part);
        Func<string, string, bool> ends_with = (name, part) => name.EndsWith(part);
        Func<string, string, bool> has_length = (name, part) => name.Length == int.Parse(part);



        while (true){

            List<string> commands = Console.ReadLine().Split().ToList();

            if (commands[0] == "Party!"){
                break;
            }



            if (commands[0] == "Remove"){

                if (commands[1] == "StartsWith"){

                    for (int i = 0; i   < names.Count; i++){

                        if (starts_with(names[i], commands[2])){
                        
                            names.RemoveAt(i);
                            i--;

                        }


                    }



                }
                else if (commands[1] == "EndsWith"){

                    for (int i = 0; i < names.Count; i++){

                        if (ends_with(names[i], commands[2])){

                            names.RemoveAt(i);
                            i--;

                        }

                    }



                }
                else if (commands[1] == "Length"){

                    for (int i = 0; i < names.Count; i++){

                        if (has_length(names[i], commands[2])){

                            names.RemoveAt(i);
                            i--;

                        }

                    }



                }
            }




            else if (commands[0] == "Double"){

                if (commands[1] == "StartsWith"){

                    for (int i = 0; i < names.Count; i++){

                        if (starts_with(names[i], commands[2])){

                            names.Insert(i + 1, names[i]);
                            i++;


                        }


                    }


                }
                else if (commands[1] == "EndsWith"){

                    for (int i = 0; i < names.Count; i++){

                        if (ends_with(names[i], commands[2])){

                            names.Insert(i + 1, names[i]);
                            i++;

                        }

                    }


                }
                else if (commands[1] == "Length"){

                    for (int i = 0; i < names.Count; i++){

                        if (has_length(names[i], commands[2])){

                            names.Insert(i + 1, names[i]);
                            i++;


                        }

                    }


                }



            }


        }

        if (names.Count > 0){

            Console.WriteLine($"{string.Join(", ", names)} are going to the party!");

        }
        else{
            Console.WriteLine("Nobody is going to the party!");
        }






    }
}

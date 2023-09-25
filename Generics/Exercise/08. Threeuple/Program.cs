List<string> strings = Console.ReadLine().Split().ToList();

Tuple<string, string, string> tuple = new Tuple<string, string, string>(strings[0] + " " + strings[1], strings[2], strings[3]);

List<string> namebeer1 = Console.ReadLine().Split().ToList();

Tuple<string, int, string> namebeer = new Tuple<string, int, string>(namebeer1[0], int.Parse(namebeer1[1]), namebeer1[2]);


List<string> intdouble1 = Console.ReadLine().Split().ToList();

Tuple<string, double, string> intdouble = new Tuple<string, double, string>(intdouble1[0], double.Parse(intdouble1[1]), intdouble1[2]);


Console.WriteLine($"{tuple.Item1} -> {tuple.Item2} -> {tuple.Item3}");

if (namebeer.Item3 == "drunk"){
    Console.WriteLine($"{namebeer.Item1} -> {namebeer.Item2} -> True");
    
}
else{
    Console.WriteLine($"{namebeer.Item1} -> {namebeer.Item2} -> False");
}

Console.WriteLine($"{intdouble.Item1} -> {intdouble.Item2} -> {intdouble.Item3}");
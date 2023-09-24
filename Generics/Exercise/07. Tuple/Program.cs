List<string> strings = Console.ReadLine().Split().ToList();

Tuple<string, string> tuple = new Tuple<string, string>(strings[0] + " " + strings[1], strings[2]);

List<string> namebeer1 = Console.ReadLine().Split().ToList();

Tuple<string, int> namebeer = new Tuple<string, int>(namebeer1[0], int.Parse(namebeer1[1]));


List<string> intdouble1 = Console.ReadLine().Split().ToList();

Tuple<int, double> intdouble = new Tuple<int, double>(int.Parse(intdouble1[0]), double.Parse(intdouble1[1]));


Console.WriteLine($"{tuple.Item1} -> {tuple.Item2}");
Console.WriteLine($"{namebeer.Item1} -> {namebeer.Item2}");
Console.WriteLine($"{intdouble.Item1} -> {intdouble.Item2}");
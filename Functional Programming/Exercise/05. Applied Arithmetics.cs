using System.Security.Cryptography.X509Certificates;

class Learning
{
    public static void Main()
    {

        
        double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        Action<double[]> add  = n => {
            for (int i = 0; i < n.Length; i++){
                n[i]++;
            }
        };

        Action<double[]> multiply = n => {
            for (int i = 0; i < n.Length; i++){
                n[i] *= 2;
            }
        };

        Action<double[]> subtract  = n => {
            for (int i = 0; i < n.Length; i++){
                n[i]--;
            }
        };

        Action<double[]> print = n => {
            Console.WriteLine(string.Join(" ", n));
        };


        while (true){

            string command = Console.ReadLine();

            if (command == "end"){
                break;
            }

            switch (command){
                case "add":
                    add(numbers);
                    break;
                case "multiply":
                    multiply(numbers);
                    break;
                case "subtract":
                    subtract(numbers);
                    break;
                case "print":
                    print(numbers);
                    break;
            }
        }



    }
}

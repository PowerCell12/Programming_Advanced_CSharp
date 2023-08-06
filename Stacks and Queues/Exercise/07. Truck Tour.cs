using System;

class Program {
    static int FindStartingPetrolPump(int[,] petrolPumps) {
        int n = petrolPumps.GetLength(0);
        int totalPetrol = 0;
        int currentPetrol = 0;
        int startingPetrolPump = 0;

        for (int i = 0; i < n; i++) {
            int petrol = petrolPumps[i, 0];
            int distance = petrolPumps[i, 1];

            totalPetrol += petrol;
            currentPetrol += petrol - distance;

            if (currentPetrol < 0) {
                currentPetrol = 0;
                startingPetrolPump = i + 1;
            }
        }

        return (totalPetrol >= 0) ? startingPetrolPump % n : -1;
    }

    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[,] petrolPumps = new int[n, 2];

        for (int i = 0; i < n; i++) {
            string[] input = Console.ReadLine().Split(' ');
            petrolPumps[i, 0] = int.Parse(input[0]);
            petrolPumps[i, 1] = int.Parse(input[1]);
        }

        int startingPetrolPump = FindStartingPetrolPump(petrolPumps);
        Console.WriteLine(startingPetrolPump);
    }
}

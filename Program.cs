// See https://aka.ms/new-console-template for more information
// Name: James King II
// Date: June 11, 2025
// Lab 3: The Beaker Game


    {
        int volume = 0;
        const int max = 30;
        int player = 1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Beaker: {volume}/{max} mL");
            Console.WriteLine($"Player {player}, add 1 to 5 mL:");

            if (!int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 5)
            {
                Console.WriteLine("Invalid input. Press any key.");
                Console.ReadKey();
                continue;
            }

            volume += input;

            if (volume > max)
            {
                Console.WriteLine($"Overflow! Player {player} loses.");
                break;
            }
            else if (volume == max)
            {
                Console.WriteLine($"Player {player} added the last amount and loses.");
                break;
            }

            player = (player == 1) ? 2 : 1;
        }

        Console.WriteLine("Game over. Press any key.");
        Console.ReadKey();
    }


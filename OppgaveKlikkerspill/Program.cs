namespace OppgaveKlikkerspill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0; 
            int pointsPerClick = 1; 
            int pointsPerClickIncrease = 1; 

            while (true) 
            { 
                Console.Clear(); 
                Console.WriteLine("Commands:\r\n - SPACE = click (and get points)\r\n - K = buy upgrade \r\n increases points per click \r\n costs 10 points\r\n - S = buy super upgrade \r\n increases \"points per click\" for the regular upgrade.\r\n costs 100 points\r\n - X = exit application"); 
                Console.WriteLine($"You have {points} points."); 
                Console.WriteLine("Press the key for the desired command."); 
                var command = Console.ReadKey().KeyChar;
                if (command == 'X') break;
                else if (command == ' ') points += pointsPerClick;
                else if (command == 'K' && points >= 10)
                {
                    points -= 10;
                    pointsPerClick += pointsPerClickIncrease;
                }
                else if (command == 'S' && points >= 100)
                {
                    points -= 100;
                    pointsPerClickIncrease++;
                }
            }
        }
    }
}

/*
    The code below is a simple clicker game: 

        int points = 0; 
        int pointsPerClick = 1; 
        int pointsPerClickIncrease = 1; 

        while (true) 
        { 
            Console.Clear(); 
            Console.WriteLine("Commands:\r\n - SPACE = click (and get points)\r\n - K = buy upgrade \r\n increases points per click \r\n costs 10 points\r\n - S = buy super upgrade \r\n increases \"points per click\" for the regular upgrade.\r\n costs 100 points\r\n - X = exit application"); 
            Console.WriteLine($"You have {points} points."); 
            Console.WriteLine("Press the key for the desired command."); 
            var command = Console.ReadKey().KeyChar; 
            if (command == 'X'
            else if (command == ' ') points += pointsPerClick;
            else if (command == 'K' && points >= 10)
            {
                points -= 10;
                pointsPerClick += pointsPerClickIncrease;
            }
            else if (command == 'S' && points >= 100)
            {
                points -= 100;
                pointsPerClickIncrease++;
            }
        }
    }
    Task

    Rewrite to be more object-oriented by introducing a class ClickerGame with object variables for
    the three int variables and a method for each command. Also introduce an interface ICommand
    with only one method, Run. Then create a class for each command in the application. Also
    create a separate class CommandSet. This has an array with an object of each command. When the
    user types a character, this must be sent to the RunCommand method in the CommandSet. There it
    looks up which command has the relevant letter and then executes Run on this command.
 */
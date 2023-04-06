namespace OppgaveKlikkerspill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cg = new ClickerGame(0,1,1);
            var commandSet = new CommandSet(cg);

            while (true) 
            { 
                //Console.Clear(); 
                Console.WriteLine("Commands:\r\n - SPACE = click (and get points)\r\n - K = buy upgrade \r\n increases points per click \r\n costs 10 points\r\n - S = buy super upgrade \r\n increases \"points per click\" for the regular upgrade.\r\n costs 100 points\r\n - X = exit application"); 
                Console.WriteLine($"You have {cg.Points} points."); 
                Console.WriteLine("Press the key for the desired command.");

                var command = Console.ReadKey().KeyChar;

                if (command == 'X') break;

                else commandSet.RunCommand(command);
            }
        }
    }
}
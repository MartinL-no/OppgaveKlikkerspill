using System;

namespace OppgaveKlikkerspill
{
    internal class CommandSet
    {
        private ICommand[] _commands;

        public CommandSet(ClickerGame clickerGame)
        {
            _commands = new ICommand[]
            {
                new AddPointsCommand(clickerGame),
                new BuyUpgradeCommand(clickerGame),
                new BuySuperUpgradeCommand(clickerGame)
            };
        }
        public void RunCommand(char commandLetter)
        {
            switch (commandLetter)
            {
                case ' ':
                    _commands[0].Run();
                    break;
                case 'K':
                    _commands[1].Run();
                    break;
                case 'S':
                    _commands[2].Run();
                    break;
            }
        }
    }
}

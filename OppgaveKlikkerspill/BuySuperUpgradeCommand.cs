using System;

namespace OppgaveKlikkerspill
{
    internal class BuySuperUpgradeCommand : ICommand
    {
        private readonly ClickerGame _clickerGame;

        public BuySuperUpgradeCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
        }
        public void Run()
        {
            _clickerGame.BuySuperUpgrade();
        }
    }
}
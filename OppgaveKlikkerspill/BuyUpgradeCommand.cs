using System;

namespace OppgaveKlikkerspill
{
    internal class BuyUpgradeCommand : ICommand
    {
        private readonly ClickerGame _clickerGame;

        public BuyUpgradeCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
        }
        public void Run()
        {
            _clickerGame.BuyUpgrade();
        }
    }
}
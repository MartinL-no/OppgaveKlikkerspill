using System;

namespace OppgaveKlikkerspill
{
    internal class AddPointsCommand : ICommand
    {
        private readonly ClickerGame _clickerGame;

        public AddPointsCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
        }

        public void Run()
        {
            _clickerGame.AddPoints();
        }
    }
}
using System;

namespace OppgaveKlikkerspill
{
    internal class ClickerGame
    {
        public int Points { get; private set; }
        private int _pointsPerClick;
        private int _pointsPerClickIncrease;

        public ClickerGame(int points, int pointsPerClick, int pointsPerClickIncrease)
        {
            Points = points; 
            _pointsPerClick = pointsPerClick = 1; 
            _pointsPerClickIncrease = pointsPerClickIncrease = 1;
        }

        public void AddPoints()
        {
            Points += _pointsPerClick;
        }

        public void BuyUpgrade()
        {
            if (Points < 10) return;

            Points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void BuySuperUpgrade()
        {
            if (Points < 100) return;

            Points -= 100;
            _pointsPerClickIncrease++;
        }
    }
}

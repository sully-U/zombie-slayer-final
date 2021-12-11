using System;

namespace zombie_slayer_final.Casting
{
    class Scoreboard : Actor
    {
        /// <summary>
        /// Class for the scoreboard actor in the game.
        /// </summary>
        int _points = 0;
        public Scoreboard (int x, int y)
        {

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(50);
            SetHeight(20);
            HasText();

        }
    }
}
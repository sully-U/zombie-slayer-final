using System;

namespace zombie_slayer_final.Casting
{
    public class Zombie : Actor
    {
        /// <summary>
        /// Class for the zombie actor in the game.
        /// </summary>
        public Zombie (Point p)
        {
            SetImage(Constants.IMAGE_ZOMBIE);

            SetPosition(p);
            SetWidth(Constants.ZOMBIE_WIDTH);
            SetHeight(Constants.ZOMBIE_HEIGHT);
        }
    }
}
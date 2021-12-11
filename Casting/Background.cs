using System;

namespace zombie_slayer_final.Casting
{
    /// <summary>
    /// Class for the background actor in the game.
    /// </summary>
    public class Background : Actor
    {
        public Background (int x, int y)
        {
            SetImage(Constants.IMAGE_BACKGROUND);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.MAX_X);
            SetHeight(Constants.MAX_Y);
        }
    }
}
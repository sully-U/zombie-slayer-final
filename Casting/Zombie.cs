using System;

namespace zombie_slayer_final.Casting
{
    public class Zombie : Actor
    {
        public Zombie (int x, int y)
        {
            // SetImage(Constants.IMAGE_ZOMBIE);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.ZOMBIE_WIDTH);
            SetHeight(Constants.ZOMBIE_HEIGHT);
        }
    }
}
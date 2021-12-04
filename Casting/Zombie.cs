using System;

namespace zombie_slayer_final.Casting
{
    public class Zombie : Actor
    {
        public Zombie (Point p)
        {
            // SetImage(Constants.IMAGE_ZOMBIE);

            SetPosition(p);
            SetWidth(Constants.ZOMBIE_WIDTH);
            SetHeight(Constants.ZOMBIE_HEIGHT);
        }
    }
}
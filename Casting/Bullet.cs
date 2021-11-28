using System;

namespace zombie_slayer_final.Casting
{
    public class Bullet : Actor
    {
        public Bullet (int x, int y)
        {
            // SetImage(Constants.IMAGE_BULLET);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.BULLET_WIDTH);
            SetHeight(Constants.BULLET_HEIGHT);
            // SetVelocity(new Point());
            MoveNext();
        }
    }
}
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
            SetVelocity(_velocity);
            MoveNext();
        }
        // public void shootUp()
        //     {
        //         int x = GetX();
        //         int y = GetY();
        //         int dx = _velocity.GetX();
        //         int dy = _velocity.GetY();

        //         _velocity = new Point(x, -dy);
        //     }
        // public void shootDown()
        // {
        //     int x = GetX();
        //     int y = GetY();
        //     int dx = _velocity.GetX();
        //     int dy = _velocity.GetY();

        //     _velocity = new Point(x, dy);
        // }
        // public void shootLeft()
        // {
        //     int x = GetX();
        //     int y = GetY();
        //     int dx = _velocity.GetX();
        //     int dy = _velocity.GetY();

        //     _velocity = new Point(-dx, y);
        // }
        // public void shootRight()
        // {
        //     int x = GetX();
        //     int y = GetY();
        //     int dx = _velocity.GetX();
        //     int dy = _velocity.GetY();

        //     _velocity = new Point(dx, y);
        // }
    }
}
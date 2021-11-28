using System;

namespace zombie_slayer_final.Casting
{
    public class Hunter : Actor
    {
        public Hunter (int x, int y)
        {
            // SetImage(Constants.IMAGE_HUNTER);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.HUNTER_WIDTH);
            SetHeight(Constants.HUNTER_HEIGHT);
        }
                public void rightBoundary()
        {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(dx, dy);
                _position = new Point (Constants.MAX_X-15-Constants.HUNTER_WIDTH, GetY());
        }
        public void leftBoundary()
        {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(dx, dy);
                _position = new Point (15, GetY());
        }
    }
}
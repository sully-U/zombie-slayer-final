using System;

namespace zombie_slayer_final.Casting
{
    public class Hunter : Actor
    {
        /// <summary>
        /// Class for the hunter actor in the game.
        /// </summary>
        public Hunter (int x, int y)
        {
            SetImage(Constants.IMAGE_HUNTER);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.HUNTER_WIDTH);
            SetHeight(Constants.HUNTER_HEIGHT);
        }
        /// <summary>
        /// Attributes of the Hunter Class to stay within the boundaries (top, bottom, left, right) of the screen
        /// </summary>
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
        public void bottomBoundary()
        {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(dx, dy);
                _position = new Point (GetX(), Constants.MAX_Y-15-Constants.HUNTER_HEIGHT);
        }
        public void topBoundary()
        {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(dx, dy);
                _position = new Point (GetX(), 15);
        }
    }
}
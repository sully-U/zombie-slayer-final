using System.Collections.Generic;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Services;

namespace zombie_slayer_final.Scripting
{
        /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HordeAction : Action
    {

        public HordeAction()
        {
        }
        /// <summary>
        /// Overrides the action of the zombies' movement to track and follow the movement of the hunter
        /// </summary>

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor hunter = cast["hunter"][0]; 

            foreach (Actor zombie in cast["zombies"])
            {
                MoveTowardPlayer(hunter, zombie);
            }
        }

        private void MoveTowardPlayer(Actor hunter, Actor zombie)
        {
            int x = zombie.GetX();
            int y = zombie.GetY();

            int dx = zombie.GetVelocity().GetX();
            int dy = zombie.GetVelocity().GetY();

            int newX = (x + dx) % Constants.MAX_X;
            int newY = (y + dy) % Constants.MAX_Y;

            if (newX < 0)
            {
                newX = Constants.MAX_X;
            }

            if (newY < 0)
            {
                newY = Constants.MAX_Y;
            }
            if (zombie.GetX() < hunter.GetX())
            {
                newX = x+1;
            }
            if (zombie.GetX() > hunter.GetX())
            {
                newX = x-1;
            }
            if (zombie.GetY() < hunter.GetY())
            {
                newY = y+1;
            }
            if (zombie.GetY() > hunter.GetY())
            {
                newY = y-1;
            }

            zombie.SetPosition(new Point(newX, newY));
        }



    }
}
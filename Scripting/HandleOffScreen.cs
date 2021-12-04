using System.Collections.Generic;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Services;

namespace zombie_slayer_final.Scripting
{
    /// <summary>
    /// Handle the actors to stay on screen
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        
        public HandleOffScreenAction()
        {
        }
        /// <summary>
        /// Overrides the action of the balls to bounce correctly off the sides of the screen.
        /// </summary>
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> bulletsToRemove = new List<Actor>();
            List<Actor> bullets = cast["bullets"];
            foreach (Hunter hunter in cast["hunter"])
            {
                if (hunter.GetX()>= Constants.MAX_X-Constants.HUNTER_WIDTH-15)
                {
                    hunter.rightBoundary();
                }
                if (hunter.GetX() + hunter.GetVelocity().GetX() <=2)
                {
                    hunter.leftBoundary();
                } 
                if (hunter.GetY() >= Constants.MAX_Y-Constants.HUNTER_HEIGHT-15)
                {
                    hunter.bottomBoundary();
                } 
                if (hunter.GetY() + hunter.GetVelocity().GetX() <= 15)
                {
                    hunter.topBoundary();
                } 
            }
            foreach(Bullet bullet in cast["bullets"])
            {
                if (bullet.GetX() >= Constants.MAX_X-Constants.BULLET_WIDTH-20)
                {
                    bulletsToRemove.Add(bullet);
                    // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                }
                if (bullet.GetX() + bullet.GetVelocity().GetX() <=20)
                {
                    
                    bulletsToRemove.Add(bullet);
                    // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                }
                if (bullet.GetY() >= Constants.MAX_Y-Constants.BULLET_HEIGHT-20)
                {
                    
                    bulletsToRemove.Add(bullet);
                    // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                }
                if (bullet.GetY() + bullet.GetVelocity().GetX() <= 20)
                {
                    
                    bulletsToRemove.Add(bullet);
                    // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                }
            }
            foreach (Bullet bulletremove in bulletsToRemove)
            {
                cast["bullets"].Remove(bulletremove);
            } 
        }
    }
}
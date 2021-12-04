using System.Collections.Generic;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Services;

namespace zombie_slayer_final.Scripting
{
    /// <summary>
    /// Class to handle the interaction between actors (brick and ball, ball and paddle)
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        /// <summary>
        /// Overrides the action of the actors to move correctly
        /// </summary>
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> zombiesToRemove = new List<Actor>();
            List<Actor> bulletsToRemove = new List<Actor>();
            List<Actor> bullets = cast["bullets"];
            Actor hunter = cast["hunter"][0]; 
            List<Actor> zombies = cast["zombies"];

            for (int i = 0; i < bullets.Count; i++)
            {
                Bullet bullet = (Bullet)bullets[i];
                
                foreach (Actor actor in zombies)
                {
                    Zombie zombie = (Zombie)actor;
                    
                    if (_physicsService.IsCollision(bullet, zombie))
                    {
                        zombiesToRemove.Add(zombie);
                        bulletsToRemove.Add(bullet);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    
                    }
                    if (bullet.GetX() == zombie.GetRightEdge() && bullet.GetY() >= zombie.GetTopEdge() && bullet.GetY()<=zombie.GetBottomEdge())
                    {
                        zombiesToRemove.Add(zombie);
                        bulletsToRemove.Add(bullet);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                    if (bullet.GetX()+bullet.GetWidth() == zombie.GetLeftEdge() && bullet.GetY() >= zombie.GetTopEdge() && bullet.GetY()<=zombie.GetBottomEdge())
                    {
                        zombiesToRemove.Add(zombie);
                        bulletsToRemove.Add(bullet);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                    if (bullet.GetY() == zombie.GetBottomEdge() && bullet.GetX() >= zombie.GetLeftEdge() && bullet.GetX()<=zombie.GetRightEdge())
                    {
                        zombiesToRemove.Add(zombie);
                        bulletsToRemove.Add(bullet);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                    if (bullet.GetY()+bullet.GetHeight() == zombie.GetTopEdge() && bullet.GetX() >= zombie.GetLeftEdge() && bullet.GetX()<=zombie.GetRightEdge())
                    {
                        zombiesToRemove.Add(zombie);
                        bulletsToRemove.Add(bullet);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                }

            }
            /// <summary>
            /// Removes the brick from the screen
            /// </summary>
            foreach (Zombie zombie in zombiesToRemove)
            {
                cast["zombies"].Remove(zombie);
            }
            foreach (Bullet bullet in bulletsToRemove)
            {
                cast["bullets"].Remove(bullet);
            } 
        }


    }
}
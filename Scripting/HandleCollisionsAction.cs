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
        int _points = 0;

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
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    
                    }
                    if (bullet.GetX() == zombie.GetRightEdge() && bullet.GetY() >= zombie.GetTopEdge() && bullet.GetY()<=zombie.GetBottomEdge())
                    {
                        zombiesToRemove.Add(zombie);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                    if (bullet.GetX() == (zombie.GetLeftEdge()-Constants.BULLET_WIDTH) && bullet.GetY() >= zombie.GetTopEdge() && bullet.GetY()<=zombie.GetBottomEdge())
                    {
                        zombiesToRemove.Add(zombie);
                        // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    }
                }

            }

        //     /// <summary>
        //     /// Keeps track of ball and paddle interaction, once they have made contact 10 times, a new ball is added. 
        //     /// </summary>
    
        //     if (_points == 10)
        //     {
        //         Ball ball = new Ball(400, 520);
        //         cast["balls"].Add(ball);
        //         _points = 0;
        //     }
            /// <summary>
            /// Removes the brick from the screen
            /// </summary>
            foreach (Zombie zombie in zombiesToRemove)
            {
                cast["zombies"].Remove(zombie);
            }  
        }


    }
}
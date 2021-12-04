using System;
using System.Collections.Generic;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Services;

namespace zombie_slayer_final.Scripting
{
        public class SpawnAction : Action
    {

        private OutputService _outputService;

        public SpawnAction(OutputService outputService)
        {
            _outputService = outputService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> zombies = cast["zombies"];

            Point spawnTop = new Point(Constants.MAX_X/2, 20);
            Point spawnBottom = new Point(Constants.MAX_X/2, Constants.MAX_Y-20);
            Point spawnLeft = new Point(20, Constants.MAX_Y/2);
            Point spawnRight = new Point(Constants.MAX_X-20, Constants.MAX_Y/2);
            Point spawnBottomRight = new Point(Constants.MAX_X-20, Constants.MAX_Y-20);
            Point spawnTopRight = new Point(Constants.MAX_X-20, 20);
            Point spawnBottomLeft = new Point(20, Constants.MAX_Y-20);
            Point spawnTopLeft = new Point(20, 20);

            Random randomGenerator = new Random();
            int random = randomGenerator.Next(100);

            // for (int i = Constants.ZOMBIE_SPACE; i < (800-Constants.ZOMBIE_SPACE); i+= (Constants.ZOMBIE_SPACE+Constants.ZOMBIE_WIDTH))  // Outer loop
            // {
            //     // Code here executes once
            //     // for each outer loop cycle

            //     for (int j = 0; j < 200; j+=((Constants.ZOMBIE_SPACE*2)+Constants.ZOMBIE_HEIGHT))  // Inner loop
            //     {
            //         // The inner loop runs to completion
            //         // for each loop cycle of the outer loop
            //         Zombie zombie = new Zombie(i,j);
            //         cast["zombies"].Add(zombie);
            //     }
            // }

            if (random <= 10)
            {
                // Create a zombie
                Zombie zombie;
                int randomSpawn = randomGenerator.Next(8);
                if (randomSpawn == 0)
                {
                    zombie = new Zombie(spawnTop);
                }
                else if (randomSpawn == 1)
                {
                    zombie = new Zombie(spawnBottom);                
                }
                else if (randomSpawn == 2)
                {
                    zombie = new Zombie(spawnLeft);                
                }
                else if (randomSpawn == 3)
                {
                    zombie = new Zombie(spawnRight);                
                }
                else if (randomSpawn == 4)
                {
                    zombie = new Zombie(spawnTopLeft);                
                }
                else if (randomSpawn == 5)
                {
                    zombie = new Zombie(spawnBottomLeft);                
                }
                else if (randomSpawn == 6)
                {
                    zombie = new Zombie(spawnTopRight);                
                }
                else
                {
                    zombie = new Zombie(spawnBottomRight);                
                }

                cast["zombies"].Add(zombie);
            }
            else
            {
                // don't create a zombie
            }
        }
    }
}
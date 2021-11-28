using System;
using zombie_slayer_final.Services;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Scripting;
using System.Collections.Generic;

namespace zombie_slayer_final
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Bricks
            cast["bricks"] = new List<Actor>();

            // for (int i = Constants.BRICK_SPACE; i < (800-Constants.BRICK_SPACE); i+= (Constants.BRICK_SPACE+Constants.BRICK_WIDTH))  // Outer loop
            // {
            //     // Code here executes once
            //     // for each outer loop cycle

            //     for (int j = 0; j < 200; j+=((Constants.BRICK_SPACE*2)+Constants.BRICK_HEIGHT))  // Inner loop
            //     {
            //         // The inner loop runs to completion
            //         // for each loop cycle of the outer loop
            //         Brick brick = new Brick(i,j);
            //         cast["bricks"].Add(brick);
            //     }
            // }

            // The Ball (or balls if desired)
            cast["bullets"] = new List<Actor>();

            // TODO: Add your ball here
            Bullet bullet = new Bullet(380, 520);
            cast["bullets"].Add(bullet);
            


            // The paddle
            cast["hunter"] = new List<Actor>();

            // TODO: Add your paddle here
            Hunter hunter = new Hunter(375, 560);
            cast["hunter"].Add(hunter);


            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);
            
            // HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            // script["update"].Add(handleOffScreenAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);

            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            




            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Horde", Constants.FRAME_RATE);
            audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}

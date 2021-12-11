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

            // Background 
            cast["background"] = new List<Actor>();
            Background background = new Background(0,0);
            cast["background"].Add(background);

            // Zombies
            cast["zombies"] = new List<Actor>();

            // Scoreboard
            cast["scoreboard"] = new List<Actor>();
            Scoreboard scoreboard = new Scoreboard(10, Constants.MAX_Y-30);
            cast["scoreboard"].Add(scoreboard);


            // The hunter
            cast["hunter"] = new List<Actor>();
            Hunter hunter = new Hunter(Constants.MAX_X/2, Constants.MAX_Y/2);
            cast["hunter"].Add(hunter);

            // The bullets
            cast["bullets"] = new List<Actor>();

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions
            // spawn actors
            // horde zombies toward hunter
            // etc.
            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            script["update"].Add(handleOffScreenAction);

            SpawnAction spawnAction = new SpawnAction(outputService);
            script["output"].Add(spawnAction);
            
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HordeAction hordeAction = new HordeAction();
            script["update"].Add(hordeAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);
            
            ShootAction shootAction = new ShootAction(inputService);
            script["input"].Add(shootAction);

            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Horde", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}

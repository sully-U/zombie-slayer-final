using System;
using zombie_slayer_final.Services;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Scripting;
using System.Collections.Generic;

namespace zombie_slayer_final
{
        /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        // Scoreboard _scoreBoard = new Scoreboard();
        private bool _keepPlaying = true;
        private Dictionary<string, List<Actor>> _cast;
        private Dictionary<string, List<Action>> _script;
        

        public Director(Dictionary<string, List<Actor>> cast, Dictionary<string, List<Action>> script)
        {
            _cast = cast;
            _script = script;
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void Direct()
        {
            while (_keepPlaying)
            {
                CueAction("input");
                CueAction("update");
                CueAction("output");

                if (Raylib_cs.Raylib.WindowShouldClose())
                {
                    _keepPlaying = false;
                }

                foreach (Zombie zombie in _cast["zombies"])
                {
                    foreach (Hunter hunter in _cast["hunter"])
                    {
                        if (zombie.GetY() == hunter.GetY() && zombie.GetX() == hunter.GetX())
                        {
                            _keepPlaying = false;
                        }
                         if (hunter.GetX() == zombie.GetRightEdge() && hunter.GetY() >= zombie.GetTopEdge() && hunter.GetY()<=zombie.GetBottomEdge())
                        {
                            _keepPlaying = false;
                        }
                        if (hunter.GetX()+hunter.GetWidth() == zombie.GetLeftEdge() && hunter.GetY() >= zombie.GetTopEdge() && hunter.GetY()<=zombie.GetBottomEdge())
                        {
                            _keepPlaying = false;
                        }
                        if (hunter.GetY() == zombie.GetBottomEdge() && hunter.GetX() >= zombie.GetLeftEdge() && hunter.GetX()<=zombie.GetRightEdge())
                        {
                            _keepPlaying = false;
                        }
                        if (hunter.GetY()+hunter.GetHeight() == zombie.GetTopEdge() && hunter.GetX() >= zombie.GetLeftEdge() && hunter.GetX()<=zombie.GetRightEdge())
                        {
                        _keepPlaying = false; 
                        }
                    }
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Executes all of the actions for the provided phase.
        /// </summary>
        /// <param name="phase"></param>
        private void CueAction(string phase)
        {
            List<Action> actions = _script[phase];

            foreach (Action action in actions)
            {
                action.Execute(_cast);
            }
        }

    }
}
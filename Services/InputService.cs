using System;
using Raylib_cs;

using zombie_slayer_final.Casting;

namespace zombie_slayer_final.Services
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }
        public bool IsLeftPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        }

        public bool IsRightPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);
        }
        public bool IsUpPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP);
        }
        public bool IsDownPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN);
        }
        public bool IsAPressed()
        {
            return Raylib.IsKeyPressed(Raylib_cs.KeyboardKey.KEY_A);
        }
        public bool IsSPressed()
        {
            return Raylib.IsKeyPressed(Raylib_cs.KeyboardKey.KEY_S);
        }
        public bool IsDPressed()
        {
            return Raylib.IsKeyPressed(Raylib_cs.KeyboardKey.KEY_D);
        }
        public bool IsWPressed()
        {
            return Raylib.IsKeyPressed(Raylib_cs.KeyboardKey.KEY_W);
        }
        public bool IsMouseButtonPressed()
        {
            return Raylib.IsMouseButtonPressed(Raylib_cs.MouseButton.MOUSE_LEFT_BUTTON);
        }

        /// <summary>
        /// Gets the direction asked for by the current key presses
        /// </summary>
        /// <returns></returns>
        public Point GetDirection()
        {
            int x = 0;
            int y = 0;
            
            if (IsLeftPressed())
            {
                x = -1;
            }

            if (IsRightPressed())
            {
                x = 1;
            }
            
            if (IsUpPressed())
            {
                y = -1;
            }
            
            if (IsDownPressed())
            {
                y = 1;
            }

            return new Point(x, y);
        }
        public Point bulletDirection()
        {
            int x = 0;
            int y = 0;

            if (IsAPressed())
            {
                x = -1;
                y = 0;
            }

            if (IsSPressed())
            {
                x = 0;
                y = 1;
            }

            if (IsDPressed())
            {
                x = 1;
                y = 0;
            }

            if (IsWPressed())
            {
                x = 0;
                y = -1;
            }
            
            return new Point(x, y);
        }
        // public Point mouseDirection()
        // {
        //     int x = 0;
        //     int y = 0;

        //     if (IsMouseButtonPressed())
        //     {
        //         x = mouse
        //     }
        // }
    

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}
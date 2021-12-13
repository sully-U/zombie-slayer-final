using System;

namespace zombie_slayer_final
{
        /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 1000;
        public const int MAX_Y = 800;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_BULLET = "./Assets/BulletC5.png";
        public const string IMAGE_HUNTER = "./Assets/hunter.png";
        public const string IMAGE_ZOMBIE = "./Assets/zombie_2_36x54.png";
        public const string IMAGE_BACKGROUND = "./Assets/background.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_OVER = "./Assets/Game_Over.mp3";
        public const string SOUND_ZOMBIE = "./Assets/zombie_sound.wav";
        public const string SOUND_ZOMBIE_2 = "./Assets/zombie_sound2.wav";
        public const string SOUND_SHOOT = "./Assets/fire.mp3";

        public const int BULLET_X = MAX_X / 2;
        public const int BULLET_Y = MAX_Y - 125;

        public const int BULLET_DX = 8;
        public const int BULLET_DY = BULLET_DX * -1;

        public const int ZOMBIE_DX = 8;
        public const int ZOMBIE_DY = ZOMBIE_DX * -1;

        public const int HUNTER_X = MAX_X / 2;
        public const int HUNTER_Y = MAX_Y / 2;

        public const int ZOMBIE_WIDTH = 24;
        public const int ZOMBIE_HEIGHT = 36;

        public const int ZOMBIE_SPACE = 5;

        public const int HUNTER_SPEED = 8;

        public const int HUNTER_WIDTH = 24;
        public const int HUNTER_HEIGHT = 24;

        public const int BULLET_WIDTH = 8;
        public const int BULLET_HEIGHT = 8;
        public const int BULLET_SPEED = 25;
        public const int  DELAY_COUNTDOWN = 100;

        
    }

}
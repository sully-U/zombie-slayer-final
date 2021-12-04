using System.Collections.Generic;
using zombie_slayer_final.Casting;
using zombie_slayer_final.Services;

namespace zombie_slayer_final.Scripting
{
    /// <summary>
    /// An action to get user input and update actors accordingly.
    /// </summary>
    public class ShootAction : Action
    {
        InputService _inputService;

        public ShootAction(InputService inputService)
        {
            _inputService = inputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point bulletDirection = _inputService.bulletDirection();
            Actor hunter = cast["hunter"][0]; 
            List<Actor> bullets = cast["bullets"];
            {

            if (_inputService.IsAPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
            }
            else if (_inputService.IsSPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
            }
            else if (_inputService.IsDPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
            }
            else if (_inputService.IsWPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
            } 
            // if (_inputService.IsAPressed())
            // {
            //     Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
            //     bullet.shootLeft();
            //     cast["bullets"].Add(bullet);
            //     // _audioService.PlaySound(Constants.SOUND_BOUNCE);
                
            // }
            }
        }
    }
}

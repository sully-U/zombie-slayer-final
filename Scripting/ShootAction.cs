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
        AudioService _audioService = new AudioService();

        public ShootAction(InputService inputService)
        {
            _inputService = inputService;
        }
        /// <summary>
        /// Overrides the action of the bullets to travel correctly when input is given
        /// </summary>

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
                _audioService.PlaySound(Constants.SOUND_SHOOT);
            }
            else if (_inputService.IsSPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
                _audioService.PlaySound(Constants.SOUND_SHOOT);
            }
            else if (_inputService.IsDPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
                _audioService.PlaySound(Constants.SOUND_SHOOT);
            }
            else if (_inputService.IsWPressed())
            {
                Bullet bullet = new Bullet(hunter.GetX(), hunter.GetY());
                Point velocity = bulletDirection.Scale(Constants.BULLET_SPEED);
                bullet.SetVelocity(velocity);
                cast["bullets"].Add(bullet);
                _audioService.PlaySound(Constants.SOUND_SHOOT);
            } 
            }
        }
    }
}

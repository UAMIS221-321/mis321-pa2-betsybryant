using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            CharacterName = "Will Turner";
            attackBehavior = new WTAttack();
            defendBehavior = new WTDefend();
        }
    }
}
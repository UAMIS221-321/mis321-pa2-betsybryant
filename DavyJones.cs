using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            CharacterName = "Davy Jones";
            attackBehavior = new DJAttack();
            defendBehavior = new DJDefend();
        }
    }
}
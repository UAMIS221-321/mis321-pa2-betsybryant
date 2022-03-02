using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            CharacterName = "Jack Sparrow";
            attackBehavior = new JSAttack();
            defendBehavior = new JSDefend();
        }
    }
}
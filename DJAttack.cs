using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class DJAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Davy Jones: BOMBS AWAY!!! I just hit you with a cannon... if you didn't already notice.");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
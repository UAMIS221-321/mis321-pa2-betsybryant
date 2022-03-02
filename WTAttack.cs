using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class WTAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Will Turner: *Enter sword sound* Did that hurt? You might need a bandaid... or a couple.");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
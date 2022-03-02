using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class JSAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Jack Sparrow: I think there's something on your shirt... AH HA! I distracted you!!!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
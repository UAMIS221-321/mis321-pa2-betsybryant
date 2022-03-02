using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class JSDefend : IDefend
    {
        public void Defend()
        {
            Console.WriteLine("Jack Sparrow: AH HA! You thought you got me but you didn't... I defended myself against you!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
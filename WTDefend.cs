using System.Threading;
using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class WTDefend : IDefend
    {
        public void Defend()
        {
            Console.WriteLine("Will Turner: Uhhhhh you missed... I defended myself against you!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
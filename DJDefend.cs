using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class DJDefend : IDefend
    {
        public void Defend()
        {
            Console.WriteLine("Davy Jones: Whoops you're a little to slow... I defended myself against you!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
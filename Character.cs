using System.Threading;
using System;
using mis321_pa2_betsybryant.Interfaces;
namespace mis321_pa2_betsybryant
{
    public class Character
    {
        public string PlayerName {get; set;}
        public string CharacterName {get; set;}
        public int MaxPower {get; set;}
        public double Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensivePower {get; set;}
        public IAttack attackBehavior {get; set;}
        public IDefend defendBehavior {get; set;}
        public Character()
        {
            
        }
        public int MaxPowerRandom()
        {
            Random random = new Random();
            MaxPower = random.Next(1,101);
            return MaxPower;
        }
        public int AttackStrengthRandom()
        {
            Random random = new Random();
            AttackStrength = random.Next(1, MaxPower + 1);
            return AttackStrength;
        }
        public int DefensivePowerRandom()
        {
            Random random = new Random();
            DefensivePower = random.Next(1, MaxPower + 1);
            return DefensivePower;

        }
        public void Stats()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\n\t\t{PlayerName} / {CharacterName} Stats:\n\tHealth: \t\t{Health}\n\tMax Power: \t\t{MaxPower}\n\tAttackStrength: \t{AttackStrength}\n\tDefensive Power: \t{DefensivePower}");
        }
    }
}
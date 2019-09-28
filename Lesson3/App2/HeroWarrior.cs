using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class HeroWarrior : Hero
    {
        public int Power;
        public HeroWarrior(string name, int level,int hp, int power) : base(name, level, hp)
        {
            Power = power;
        }
        public override string GetInfo()
        {
            return $"Имя: {Name,3} Уровень: {Level,3} HP: {Hp,3} Power: {Power,3}";
        }
        public Hero Attack(Hero A)
        {
            A.Hp = A.Hp - Power * 1;
            return A;
        }
    }
}

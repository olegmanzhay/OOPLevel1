using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class HeroWizard:Hero
    {
        public int Mp;
        public HeroWizard(string name, int level, int hp, int mp) : base(name, level, hp)
        {
            Mp = mp;
        }
        public override string GetInfo()
        {
            return $"Имя: {Name,3} Уровень: {Level,3} HP: {Hp,3} MP: {Mp,3}";
        }

        public Hero ToBeHeal(Hero A)
        {
            A.Hp = A.Hp + 2 * Level;
            if (A.Hp > 100)
                A.Hp = 100;
            return A;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Hero
    {
        public string Name;
        public int Level;
        public int Hp;

        public Hero(string name, int level, int hp)
        {
            Name = name;
            Level = level;
            Hp = hp;
        }

        public Hero()
        {

        }
        
        public virtual string GetInfo()
        {
            return $"Имя: {Name,3} Уровень: {Level,3} HP: {Hp,3}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hero
            //Hero Orc = new Hero();          // new - конструктор, задача - разместить в памяти
            //Orc.Name = "Orc";
            //Orc.Level = 11;

            //Hero Human = new Hero()
            //{
            //    Name = "Bob",
            //    Level = 1
            //};

            //Hero Elf = new Hero("Ozi", 50, 100);

            //Hero DarkElf = new Hero();
            //Console.Write("Введите Имя героя: ");
            //DarkElf.Name = Console.ReadLine();
            //Console.Write("Введите уровень героя: ");
            //DarkElf.Level = int.Parse(Console.ReadLine());



            //Console.WriteLine($"Имя: {Orc.Name,3} Уровень: {Orc.Level,3} ");
            //Console.WriteLine($"Имя: {Human.Name,3} Уровень: {Human.Level,3} ");
            //Console.WriteLine($"Имя: {Elf.Name,3} Уровень: {Elf.Level,3} ");

            //Console.WriteLine(DarkElf.GetInfo());

            //HeroWizard Potter = new HeroWizard("Potter", 100, 100, 10);
            //Console.WriteLine(Potter.GetInfo());

            //Hero VolanDeMort = new HeroWizard("VolandDeMort", 2, 100, 9);
            //Console.WriteLine(VolanDeMort.GetInfo());

            //HeroWizard Ronald = new HeroWizard("Potter", 5, 100, 10);
            //Console.WriteLine(Potter.GetInfo());
            //Console.WriteLine();

            //HeroWarrior Spartak = new HeroWarrior("Spartak", 10, 100, 20);
            //Console.WriteLine(Spartak.GetInfo());
            //HeroWarrior Lancelot = new HeroWarrior("Lancelot", 10, 100, 35);
            //Console.WriteLine(Lancelot.GetInfo());
            //Console.WriteLine();

            //Lancelot.Attack(Spartak);
            //Spartak.Attack(Lancelot);
            //Console.WriteLine(Spartak.GetInfo());
            //Console.WriteLine(Lancelot.GetInfo());
            //Console.WriteLine();

            //Potter.ToBeHeal(Spartak);
            //Ronald.ToBeHeal(Lancelot);
            //Console.WriteLine(Spartak.GetInfo());
            //Console.WriteLine(Lancelot.GetInfo());
            //Console.ReadKey();
            #endregion

            HeroWizard Gendalf = new HeroWizard("Gendalf", 10, 100, 100);
            HeroWizard Stella = new HeroWizard("Stella", 1, 100, 100);

            HeroWarrior Mongol = new HeroWarrior("Mongol", 99, 100, 100);
            HeroWarrior Gorosh = new HeroWarrior("Gorosh", 78, 100, 100);

            Console.WriteLine(Gorosh.GetInfo());
            Mongol.Attack(Gorosh);
            Console.WriteLine(Gorosh.GetInfo());
            Console.ReadKey();

        }
    }
}

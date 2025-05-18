using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilder
{
    using System;

    class Program
    {
        static void Main()
        {
            Director director = new Director();

            HeroBuilder heroBuilder = new HeroBuilder();
            director.CreateHero(heroBuilder);
            Character hero = heroBuilder.Build();

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            director.CreateEnemy(enemyBuilder);
            Character enemy = enemyBuilder.Build();

            Console.WriteLine("=== Hero ===");
            hero.ShowInfo();

            Console.WriteLine("=== Enemy ===");
            enemy.ShowInfo();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}

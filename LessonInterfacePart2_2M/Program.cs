using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LessonInterfacePart2_2M.Classes;

namespace LessonInterfacePart2_2M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Actor> actors = new List<Actor>()
            {
                new Zombie(0, 0, "Zombie Artur"),
                new Zombie(0, 0, "Zombie Lesha"),
                new ZombieRunner(0, 0, "ZombieRunner Vlad"),
                new ZombieSpit(0, 0, "ZombieSpit Boris")
            };

            foreach (var actor in actors)
            {
                actor.Info();
            }

            Console.ReadLine();   // pause
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LessonInterfacePart2_2M.Classes.Interfaces;

namespace LessonInterfacePart2_2M.Classes
{
    public class ZombieRunner : Actor, IRun
    {
        public ZombieRunner(int x, int y, string name) : base(x, y, name) { }

        public int Speed { get; set; }

        public override void Info()
        {
            Console.WriteLine($"[ZOMBIE RUNNER] Name: {name}, X: {x}, Y: {y}");
        }

        public void Run()
        {
            Console.WriteLine("[ZOMBIE RUNNER] RUN!");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdv04.Fifa_Games
{
    internal class player
    {
        public string playName { get; set; }
        public string TeamName { get; set; }
        public void Run()
        {
            Console.WriteLine($"Player : {playName} Is Running ..........");
        }
    }
}

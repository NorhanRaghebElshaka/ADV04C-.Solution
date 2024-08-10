using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdv04.Fifa_Games
{
    internal class Refree
    {
        public string RefreeName { get; set; }
        public void Look()
        {
            Console.WriteLine($"Refree : {RefreeName} Is Looking At Ball ..........");
        }
    }
}

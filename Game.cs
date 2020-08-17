using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthregen = 80;
            string name = Console.ReadLine();
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine(health);
            health = health + healthregen;
            Console.Write(name + " you healed " + healthregen);
            
            
        }
    }
}

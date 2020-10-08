using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Warrior : Player
    {
        public Warrior(string nameVal)
        {
            _name = nameVal;
            playerHealth = 200.0f;
        }
    }
}

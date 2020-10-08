using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wizard : Player
    {
        public Wizard(string nameVal)
        {
            _name = nameVal;
            playerHealth = 80.0f;
        }
    }
}

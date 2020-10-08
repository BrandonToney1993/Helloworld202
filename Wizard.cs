using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wizard : Player
    {
        public Wizard(string nameVal)
            name = nameVal;
            PlayerHealth = 80.0f;
            healthregen = 5.0f;

    }
}

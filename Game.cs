using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            Console.WriteLine("you've been sent out to find a powerful mage to help in the efforts of curing to queen who has been cursed by an evil wizard.");
            Console.WriteLine("King Dannahiem has given you the location as to where Merlin has been hiding. The king has given you an order to bring Merlin back by any means necessary.");
            Console.WriteLine("during your travels, you come across a cave for shelter. once you enter you're met by a hermit of a man.");
            Console.WriteLine("Hello, who's there?");
            string name = Console.ReadLine();
            Console.WriteLine("what is it that you want " + name + "?");
            Console.ReadLine();
            Console.WriteLine("how is it that you found me " + name + "?");
            Console.ReadLine();
            Console.WriteLine("i see so they've sent some child to find bring me in?");
            Console.ReadLine();
            Console.WriteLine("my name is merlin the great, so the king is in need of my assistence is he " + name + "?");
            Console.ReadLine();
            Console.WriteLine("I can assure you i won't be of any trouble.");
            Console.WriteLine("Please, allow me to heal you before you bring me back to the kingdom");
            Console.WriteLine("so what are you exactly? you're not like anything ive ever seen before!" + "please input role");
            string role = Console.ReadLine();
            //this variable is used to store health
            float health = 100.0f;
            //this variable is used to heal the player
            float healthregen = 80.0f;
            //this variable is used for player magic
            float magic = 100.0f;
            //this variable is used for player magic regen
            float magicregen = 80.0f;
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            Console.WriteLine("Player Name:" + name);
            Console.WriteLine("Player Health:" + health);
            Console.WriteLine("Player Level:" + level);
            Console.WriteLine("Player Role:" + role);
            Console.WriteLine("player magic:" + magic);
            //Create an application that gets the user's name
            //along with an additional application that gets the user's name
            //to the console along with their stats. Must use all data types  

            
            
        }
    }
}

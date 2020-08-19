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
            if(input == '1')
            {
                i am looking for a man by the name of Merlin;
            }
            {if(input == '2')
                    i am looking for shelter;
            }
            Console.WriteLine("how is it that you found me " + name + "?");
            Console.ReadLine();
            Console.WriteLine("i see so they've sent some child to bring me in?");
            Console.ReadLine();
            Console.WriteLine("my name is merlin the great, so the king is in need of my assistence is he " + name + "?");
            Console.ReadLine();
            Console.WriteLine("I can assure you i won't be of any trouble.");
            Console.WriteLine("Please, allow me to heal you before you bring me back to the kingdom");
            Console.WriteLine("so what are you exactly? you're not like anything ive ever seen before!");
            string role = ("");
            //ask player to choose a role
            Console.WriteLine("1.Warrior Role");
            Console.WriteLine("2.Wizard Role");
            char Input = Console.ReadKey().KeyChar; 
            if(Input == '1')
            {
                int Attack = 150;
                int damage = 100;
                int mana = 20;
                int warrior;
               
            }
            else if(Input == '2')
            {
                int Attack = 100;
                int Damage = 70;
                int mana = 150;
                int wizard;
                
            }
            //this variable is used to store health
            float health = 100.0f;
            //this variable is used to heal the player
            float healthregen = 80.0f;
            //this variable is used for player magic
            float magic = 100.0f;
            //this variable is used for player magic regen
            float magicregen = 80.0f;
            //represent players max level reached
            bool maxLevelReached = false;
            //represents players max level
            int maxLevel = 100;
            //represents players level
            int level = 1;
            bool Ready = true;
            //print players stats on screen
            Console.WriteLine("Player Name:" + name);
            Console.WriteLine("Player Health:" + health);
            Console.WriteLine("Player Level:" + level);
            Console.WriteLine("Player Role:" + role);

            
            
        }
    }
}

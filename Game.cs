using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        //end the game when true
        private bool _gameover = false;
        
        public void Run()
        {

            Console.WriteLine("you've been sent out to find a powerful mage to help in the efforts of curing the queen who has been cursed by an evil wizard.");

            Console.WriteLine("King Dannahiem has given you the location as to where Merlin has been hiding. The king has given you an order to bring Merlin back by any means necessary.");

            Console.WriteLine("during your travels, you come across a cave for shelter. once you enter you're met by a hermit, who has fallen.");
            Console.WriteLine("1.Help the hermit up.");
            Console.WriteLine("2.keep walking you have more important things to worry about");
            char input = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("thank you my good boy! For helping me, i would like to return the favor by helping you in your travels!");
            }
            else if(input == '2')
            {
                Console.WriteLine("you try to walk away, but the cries from the old hermit make you return to help.");
            }
            Console.WriteLine("what is your name my boy? ");

            string name = Console.ReadLine();
            Console.WriteLine("what is it that you seek? " + name + "?");
            Console.WriteLine("1.I seek merlin");
            Console.WriteLine("2.I seek a battle");
            char discussion = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine(" well you're in luck you've found me my good boy!");
            }
            else if(input == '2')
            {
                Console.WriteLine(" oh a battle is what you want huh? well you won't get one from me haha!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input");
            }
            
            Console.WriteLine("how is it that you found me " + name + "?");
            Console.WriteLine("1.the king has sent me to find you, the queen has been cursed!");
            Console.WriteLine("2.it was a just a conincidence.");
            char dialog = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("i see so how should i help?");
            }
            else if(input == '2')
            {
                Console.WriteLine("there are no coincidences my boy!");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("invalid input");
            }
            
            Console.WriteLine("1.come back to Dannahiem with me and lift the curse from the queen!");
            Console.WriteLine("2.help me slay the wizard who cursed the queen!");
            char convo = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("certainlly my boy, I'll do what I can to help!");
            }
            else if(input == '2')
            {
                Console.WriteLine("Hahahaha....ohhohohoh....thats a good one me fight!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input");
            }
            Console.WriteLine("Please, allow me to heal you before you bring me back to the kingdom.");
            Console.WriteLine("1.you allow merlin to heal you.");
            Console.WriteLine("2.you refuse and head back to the kingdom.");
            char dialect = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("marvelous i'll get right to it my good boy!");
            }
            else if(input == '2')
            {
                Console.WriteLine("you take merlin by the arm and hoist him up on your horse and quickly ride back to the kingdom of Dannahiem");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input");
            }
            Console.WriteLine("so what are you exactly? you're not like anything ive ever seen before!");
            string role = ("");
            //ask player to choose a role
            Console.WriteLine("1.Warrior Role");
            Console.WriteLine("2.Wizard Role");
            while (input != '1' && input != '2')
            {
                char Input = Console.ReadKey().KeyChar;
                if (Input == '1')
                {
                    int Attack = 150;
                    int warrior;

                }
                else if (Input == '2')
                {
                    int Attack = 100;
                    int Damage = 70;
                    int mana = 150;
                    int wizard;

                }
                else
                {
                    Console.Clear();
                    Console.Write("invalid input");
                }
            }

            Console.WriteLine("merlin and" + name + ", are returning to Dannahiem to try and lift the curse placed by the evil wizard. when you're stopped by a merchant.");
            Console.WriteLine("well hello there my good friends! can i interest you in some antiqueties?");
            Console.WriteLine("1.we haven't the time you pesant! no move!");
            Console.WriteLine("2.move or ill move you myself worm!");
            char converse = Console.ReadKey().KeyChar;
            if(input == '1')
            {
                Console.WriteLine("pesant haha! as you wish sir!");
            }
            else if(input == '2')
            {
                Console.WriteLine("yes my good sir!");
            }

            Console.WriteLine("as merlin and" + name + "walks away the seemingly easy going merchant transforms into the evil wizard");

            Console.WriteLine("hahaha fools they'll try and lift the curse, but only fail and kill the queen! hahaha");
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

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Game
    {
        private bool _gameover = false;
        Player player1;


        public void Run()
        {
            Console.WriteLine("What is your name?");
            String Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1.Warrior Role");
            Console.WriteLine("2.Wizard Role");
            char Input = Console.ReadKey().KeyChar;
            if (Input == '1')
            {
                player1 = new Warrior(Name);

            }
            else if (Input == '2')
            {
                player1 = new Wizard(Name);
            }
            else
            {
                Console.Clear();
                Console.Write("invalid input");
            }


            Console.WriteLine("Player Health:" + player1.playerHealth);
            Console.WriteLine("Player Level:" + player1.level);
            Console.WriteLine("Player Role:" + player1.role);
            Console.WriteLine("you've been sent out to find a powerful mage to help in the efforts of curing the queen who has been cursed by an evil wizard.");

            Console.WriteLine("King Dannahiem has given you the location as to where Merlin has been hiding. The king has given you an order to bring Merlin back by any means necessary.");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("during your travels, you come across a cave for shelter. once you enter you're met by a hermit, who has fallen.");
            Console.WriteLine("1.Help the hermit up.");
            Console.WriteLine("2.keep walking you have more important things to worry about");
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine("thank you my good boy! For helping me, i would like to return the favor by helping you in your travels!");
            }
            else if (input == '2')
            {
                Console.WriteLine("you try to walk away, but the cries from the old hermit make you return to help.");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("what is it that you seek? " + Name + "?");
            Console.WriteLine("1.I seek merlin");
            Console.WriteLine("2.I seek a battle");

            char discussion = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine(" well you're in luck you've found me my good boy!");
            }
            else if (input == '2')
            {
                Console.WriteLine(" oh a battle is what you want huh? let's see if this old man still has it!");
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Player Merlin = new Wizard("Merlin");
                while(player1.playerHealth > 0 && Merlin.playerHealth > 0)
                {
                    Console.WriteLine("Player Name:" + player1.GetName() );
                    Console.WriteLine("Player Health:" + player1.playerHealth);
                    Console.WriteLine("Player Level:" + player1.level);
                    Console.WriteLine("Player Role:" + player1.role);
                    Console.WriteLine("\nMerlin");
                    Console.WriteLine("Merlin Health: + MerlinHealth");
                    Console.WriteLine("Merlin Level: + Merlin.level");
                    Console.WriteLine("Merlin Role: + Merlin.Role");
                    Console.WriteLine("press 1 for attack");
                    Console.WriteLine("press 2 for defend");

                    char Discussion = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        Console.WriteLine("you attack merlin with blunt of your sword!");
                        Merlin.playerHealth -= player1.damage;
                        Console.WriteLine("Merlin Strikes you back with a fireball");
                        player1.playerHealth -= Merlin.magic;

                    }
                    else if (input == '2')
                    {
                        Console.Write("merlin attacks with a fireball but misses you");
                        Console.WriteLine("and yo swing back with a counter attck");
                        Merlin.playerHealth -= player1.damage;
                    }
                }
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("why is it that you came in search of me " + player1.GetName() + "?");
            Console.WriteLine("1.the king has sent me to find you, the queen has been cursed!");
            Console.WriteLine("2.it was just a conincidence.");
            char dialog = Console.ReadKey().KeyChar;
            bool DialogDone = false;
            while (DialogDone == false)
            {
                if (dialog == '1')
                {
                    Console.WriteLine("i see so how should i help?");
                    DialogDone = true;
                }
                else if (dialog == '2')
                {
                    Console.WriteLine("there are no coincidences my boy!");
                    DialogDone = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("invalid input");
                }
            }

            Console.WriteLine("1.come back to Dannahiem with me and lift the curse from the queen!");
            Console.WriteLine("2.help me slay the wizard who cursed the queen!");
            char convo = Console.ReadKey().KeyChar;
            bool ConvoDone = false;
            while (ConvoDone == false)
            {
                if (convo == '1')
                {
                    Console.WriteLine("certainlly my boy, I'll do what I can to help!");
                    ConvoDone = true;
                }
                else if (convo == '2')
                {
                    Console.WriteLine("i may not be of much use these days when it comes to battle, but ill do what i can!");
                    ConvoDone = true;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("invalid input");
                }
            }
            Console.WriteLine("Please, allow me to heal you before you bring me back to the kingdom.");
            Console.WriteLine("1.you allow merlin to heal you.");
            Console.WriteLine("2.you refuse and head back to the kingdom.");
            char dialect = Console.ReadKey().KeyChar;
            bool DialectDone = false;
            while (DialectDone == false)
            {
                if (input == '1')
                {
                    Console.WriteLine("marvelous i'll get right to it my good boy!");
                    DialectDone = true;
                }
                else if (input == '2')
                {
                    Console.WriteLine("you take merlin by the arm and hoist him up on your horse and quickly ride back to the kingdom of Dannahiem");
                    DialectDone = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("invalid input");
                }
            }
            Console.WriteLine("so what are you exactly? you're not like anything ive ever seen before!");

            Console.WriteLine("merlin and" + Name + ", are returning to Dannahiem to try and lift the curse placed by the evil wizard. when you're stopped by a merchant.");
            Console.WriteLine("well hello there my good friends! can i interest you in some antiqueties?");
            Console.WriteLine("1.we haven't the time you pesant! now move!");
            Console.WriteLine("2.move or ill move you myself worm!");
            char converse = Console.ReadKey().KeyChar;
            bool ConverseDone = false;
            while (ConverseDone == false);
            if (input == '1')
            {
                Console.WriteLine("pesant haha! as you wish sir!");
                ConverseDone = true;
            }
            else if (input == '2')
            {
                Console.WriteLine("yes my good sir!");
                ConverseDone = true;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("as merlin and" + Name + "walks away the seemingly easy going merchant transforms into the evil wizard");

            Console.WriteLine("hahaha fools they'll try and lift the curse, but only fail and kill the queen! hahaha");
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            //player1.Save(writer);
            writer.Close();
        
        }

        public void Load()
        {

        }

        public void StartBattle()
        {

        }

        public void Update()
        {

        }

        public void End()
        {
            
        }
    }
}

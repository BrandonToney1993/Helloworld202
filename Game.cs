using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Game
    {
        readonly Shop shop;
        public bool _gameover = false;
        Player player1;
        public string role;
        public float playerHealth = 100.0f;
        public int damage = 100;
        public float magic = 100.0f;
        public int level = 1;
        public int Gold = 500;
        public List<Item> _inventory;
        public Item[] _inventory1;
        public Item[] _inventory2;
        public int itemSelected;

        internal Shop Shop => shop;

        public void Run()
        //run game. will ask for name and character class.
        {
            Console.WriteLine("What is your name?");
            String Name = Console.ReadLine();
            Console.Clear();
            //choose between 2 preset characters if not choosen send invalid input
            Console.WriteLine("0.Warrior Role");
            Console.WriteLine("1.Wizard Role");
            char Input = Console.ReadKey().KeyChar;
            if (Input == '0')
            {
                player1 = new Warrior(Name);

            }
            else if (Input == '1')
            {
                player1 = new Wizard(Name);
            }
            else
            {
                Console.Clear();
                Console.Write("invalid input");
            }
            //players choice determines health, role, and level. game should begin here
            Console.WriteLine("Player Health:" + player1.playerHealth);

            Console.WriteLine("Player Level:" + player1.level);

            Console.WriteLine("Player Role:" + player1.role);

            Console.WriteLine("you've been sent out to find a powerful mage to help in the efforts of curing the queen who has been cursed by an evil wizard.");

            Console.WriteLine("King Dannahiem has given you the location as to where Merlin has been hiding. The king has given you an order to bring Merlin back by any means necessary.");

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("during your travels, you come across a cave for shelter. once you enter you're met by a hermit, who has fallen.");

            Console.WriteLine("0.Help the hermit up.");

            Console.WriteLine("1.keep walking you have more important things to worry about");

            char input = Console.ReadKey().KeyChar;
            if (input == '0')
            {
                Console.WriteLine("thank you my good boy! For helping me, i would like to return the favor by helping you in your travels!");
            }
            else if (input == '1')
            {
                Console.WriteLine("you try to walk away, but the cries from the old hermit make you return to help.");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("what is it that you seek? " + Name + "?");

            Console.WriteLine("0.I seek merlin");

            Console.WriteLine("1.I seek a battle");

            char discussion = Console.ReadKey().KeyChar;
            if (input == '0')
            {
                Console.WriteLine(" well you're in luck you've found me my good boy!");
            }
            else if (input == '1')
            {
                Console.WriteLine(" oh a battle is what you want huh? let's see if this old man still has it!");
                Player Merlin = new Wizard("Merlin");
                while (player1.playerHealth > 0 && Merlin.playerHealth > 0)
                {
                    Console.WriteLine("Player Name:" + player1.GetName());

                    Console.WriteLine("Player Health:" + player1.playerHealth);

                    Console.WriteLine("Player Level:" + player1.level);

                    Console.WriteLine("Player Role:" + player1.role);

                    Console.WriteLine("\nMerlin");

                    Console.WriteLine("Merlin Health: + MerlinHealth");

                    Console.WriteLine("Merlin Level: + Merlin.level");

                    Console.WriteLine("Merlin Role: + Merlin.Role");

                    Console.WriteLine("press A for attack");

                    Console.WriteLine("press D for defend");


                    char Discussion = Console.ReadKey().KeyChar;
                    if (input == 'A')
                    {
                        Console.WriteLine("you attack merlin with blunt of your sword!");

                        Merlin.playerHealth -= player1.damage;

                        Console.WriteLine("Merlin Strikes you back with a fireball");

                        player1.playerHealth -= Merlin.magic;

                    }
                    else if (input == 'D')
                    {
                        Console.Write("merlin attacks with a fireball but misses you");

                        Console.WriteLine("and yo swing back with a counter attack");

                        Merlin.playerHealth -= player1.damage;
                    }
                }
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("why is it that you came in search of me " + player1.GetName() + "?");

            Console.WriteLine("0.the king has sent me to find you, the queen has been cursed!");

            Console.WriteLine("1.it was just a conincidence.");
            char dialog = Console.ReadKey().KeyChar;
            bool DialogDone = false;
            while (DialogDone == false)
            {
                if (dialog == '0')
                {
                    Console.WriteLine("i see so how should i help?");
                    DialogDone = true;
                }
                else if (dialog == '1')
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

            Console.WriteLine("0.come back to Dannahiem with me and lift the curse from the queen!");

            Console.WriteLine("1.help me slay the wizard who cursed the queen!");

            char convo = Console.ReadKey().KeyChar;
            bool ConvoDone = false;
            while (ConvoDone == false)
            {
                if (convo == '0')
                {
                    Console.WriteLine("certainlly my boy, I'll do what I can to help!");
                    ConvoDone = true;
                }
                else if (convo == '1')
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
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Please, allow me to heal you before you bring me back to the kingdom.");

            Console.WriteLine("0.you allow merlin to heal you.");

            Console.WriteLine("1.you refuse and head back to the kingdom.");
            char dialect = Console.ReadKey().KeyChar;
            bool DialectDone = false;
            while (DialectDone == false)
            {
                if (input == '0')
                {
                    Console.WriteLine("marvelous i'll get right to it my good boy!");
                    DialectDone = true;
                }
                else if (input == '1')
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
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            //setup a simple shop system to buy and sell items and weapons

            Console.WriteLine("merlin and" + Name + ", are returning to Dannahiem to try and lift the curse placed by the evil wizard. when you're stopped by a merchant.");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("well hello there my good friends! can i interest you in some antiqueties?");

            Console.WriteLine("0.yes! i am in need of a weapon.");

            Console.WriteLine("1.we haven't the time you we must hurry back!");

            char converse = Console.ReadKey().KeyChar;
            bool ConverseDone = false;
            while (ConverseDone == false)
                if (input == '0')
                {
                    Console.WriteLine("yes! i am in need of a weapon.");
                    ConverseDone = true;
                    Shop.RunShop(player: ref player1);
                }
                else if (input == '1')
                {
                    Console.WriteLine("we haven't the time you we must hurry back!");
                    ConverseDone = true;

                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            Shop.RunShop(player: ref player1);


            Console.WriteLine("as merlin and" + Name + "walks away the seemingly easy going merchant transforms into the evil wizard");

            Console.WriteLine("hahaha fools they'll try and lift the curse, but only fail and kill the queen! hahaha");

            Console.Clear();

            Console.WriteLine("");
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            //player1.Save(writer);
            writer.Close();
        }
            public void End()
            {
                _gameover = true;
            }


        public void GameShop()
        {
            string choice = "";
            Shop shop = new Shop(0);
            shop.RunShop(ref player1);
            while (choice != "0")
            {
                Console.WriteLine("welcome to my shop");
                Console.WriteLine("what would you like to do");
                Console.WriteLine("0:exit");
                Console.WriteLine("1:buy");
                Console.WriteLine("2:sell");

                choice = Console.ReadLine();
                if (choice == "")
                {
                    //checks if there is anything to buy
                    if (_inventory.Count <= 0)
                    {
                        Console.WriteLine("there is nothing left to buy");
                    }
                    //enter buy menu
                    else
                    {
                        Buy(ref player1);
                    }
                }
                else if (choice == "2")
                //enter sell menu
                {
                    Sell(ref player1);
                }
                else if (choice == "0")
                {
                    Console.Clear();
                }

            }

        }

        private void Buy(ref Player player)
        {
            int index = 1;
            while (index != 1 && _inventory.Count > 0)
            {
                Console.WriteLine("what item would you like to buy");
                Console.WriteLine("0:exit");
                for (int i = 0; i < _inventory.Count; i++)
                {

                    Console.WriteLine((i + 1) + ": " + _inventory[i].Name + "costs;" + _inventory[i].Value);

                }
                //checks if input was namber
                var ok = true;
                ok = Int32.TryParse(Console.ReadLine(), out index);
                if (ok)
                {
                    Console.Clear();
                    Console.WriteLine("invalid input");
                    Console.ReadKey();

                }
                else
                {
                    Console.Clear();
                    //checks if player has enough money
                    if (player.Gold >= _inventory[index].Value)
                    {
                        player.AddItemToInventory(_inventory[index]);
                        player.Gold -= _inventory[index].Value;
                        _inventory.RemoveAt(index);
                    }

                }

            }
        }
        public void Sell(ref Player player)
        {

        }
    }
}



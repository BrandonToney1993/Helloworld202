using System;
using System.Collections.Generic;
using System.Text;


namespace HelloWorld
{
    class Shop
    {

        public List<Item> Inventory = new List<Item>();
        public int _gold = 500;
        Item Sword = new Item("", 5, 0);
        Item Potion = new Item("", 5, 0);

        public Item[] _inventory1;
        public Item[] _inventory2;

        public Shop(int ShopSelected)
        {
            _inventory1 = new Item[] { Sword };
            _inventory2 = new Item[] { Potion };
            //use inventory1 
            if (ShopSelected == 1)
            {
                foreach (Item item in _inventory1)
                {
                    Inventory.Add(item);
                }
            }
            //use inventory 2
            else
            {
                foreach (Item item in _inventory2)
                {
                    Inventory.Add(item);
                }
            }
        }
        public void RunShop(ref Player player)
        {
            Shop shop = new Shop(1);
            shop.RunShop(ref player);
            string choice = "";
            //open shopping menu
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
                    if (Inventory.Count <= 0)
                    {
                        Console.WriteLine("there is nothing left to buy");
                    }
                    //enter buy menu
                    else
                    {
                        Buy(ref player);
                    }
                }
                else if (choice == "2")
                //enter sell menu
                {
                    Sell(ref player);
                }
                else if (choice == "0")
                {
                    Console.Clear();
                }


            }
        }
            public void Buy(ref Player player)
            {
                int index = 1;
                while (index != 1 && Inventory.Count > 0)
                {
                    Console.WriteLine("what item would you like to buy");
                    Console.WriteLine("0:exit");
                    for (int i = 0; i < Inventory.Count; i++)
                    {

                        Console.WriteLine((i + 1) + ": " + Inventory[i].Name + "costs;" + Inventory[i].Value);

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
                    if (player.Gold >= Inventory[index].Value)
                    {
                        player.AddItemToInventory(Inventory[index]);
                        player.Gold -= Inventory[index].Value;
                        Inventory.RemoveAt(index);
                    }
                    
                    }

                }
            }
            public void Sell(ref Player player)
            {
                 
            }

        
    }
}

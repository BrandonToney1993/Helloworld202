using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Player
    {
            protected string _name;
            public string role;
            public float playerHealth = 100.0f;
            public int damage = 100;
            public float magic = 100.0f;
            public int level = 1;
            public int Gold = 500;
            public List<Item> _inventory;


        public Player()
        {
            playerHealth = 100;
            damage = 10;
        }

        public Player(string nameVal)
        {
          
        }

        public Player(string nameVal, int healthVal, int damageVal, int inventorySize)
        {
            playerHealth = healthVal;
            damage = damageVal;
            inventorySize = 5;
        }

        public void EquipItem(Item Weapon)
        {
            Item Sword = new Item("", 5, 0);
            Item Potion = new Item("", 5, 0);
        }

        public void AddItemToInventory(Item item)
        {
            _inventory.Add(item);
        }

        public void EquipItem()
        {
            Item Sword = new Item("", 5, 0);
            Item Potion = new Item("", 5, 0);
        }

        public string GetName()
        {
            return _name;
        }

        public bool GetIsAlive()
        {
            return playerHealth > 0;
        }

        public void Attack(Player enemy)
        {
            enemy.TakeDamage(damage);
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Damage: " + damage);
        }

        public void TakeDamage(int damageVal)
        {
            if (GetIsAlive())
            {
                playerHealth -= damageVal;
            }
            Console.WriteLine(_name + " took " + damageVal + " damage!!!");
        }
        public void Save()
        {

        }
    }
}

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
            public int Gold = 1;

            bool maxLevelReached = false;
            private int maxLevel = 100;

        public Item[] _inventory;

        public Player()
        {
            _inventory = new Item[3];
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
            _inventory = new Item[inventorySize];
        }

        public void EquipItem(Item Weapon)
        {

        }

        public void AddItemToInventory(Item item, int index)
        {
            //damage += Weapon.statBoost;
            _inventory[index] = item;
            _inventory.Add(item);
        }

        public void EquipItem(int itemIndex)
        {
            //damage = _inventory[itemIndex].statBoost;
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

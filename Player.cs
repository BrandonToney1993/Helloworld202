using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        struct Item
        {
            public string name;
        }

        private string _name;
        private int _health;
        private int _damage;
        private Item[] _inventory;

        public Player()
        {
            _inventory = new Item[3];
            _health = 100;
            _damage = 10;
        }

        public Player(string nameVal, int healthVal, int damageVal)
        {
            protected string _name;
            public string Role;
            public float PlayerHealth = 100.0f;
            public float healthregen = 80.0f;
            public float damage = 100.0f;
            public float magic = 100.0f;
            public float magicregen = 80.0f;
            bool maxLevelReached = false;
            public int maxLevel = 100;
            public int level = 1;
            bool Ready = true;
            float MerlinHealth = 100.0f;
            float Mana = 80.0f;
        }

        public Player(string nameVal, int healthVal, int damageVal, int inventorySize)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            _inventory = new Item[inventorySize];
        }

        public void EquipItem(Item Weapon)
        {

        }

        public void AddItemToInventory(Item item, int index)
        {
            _damage += Weapon.statBoost;
            _inventory[index] = item;
        }

        public void EquipItem(int itemIndex)
        {
            _damage = _inventory[itemIndex].statBoost;
        }

        public string GetName()
        {
            return _name;
        }

        public bool GetIsAlive()
        {
            return _health > 0;
        }

        public void Attack(Player enemy)
        {
            enemy.TakeDamage(_damage);
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }

        private void TakeDamage(int damageVal)
        {
            if (GetIsAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine(_name + " took " + damageVal + " damage!!!");
        }
        public void Save()
        {

        }


    }
}

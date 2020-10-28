using System.Collections.Generic;

namespace HelloWorld
{
    class Item
    {
        public string Name = "";
        public int Value = 0;

        //item type 0 = default item
        //item type 1 = weapon

        public int ItemType = 0;
        public Item(string name, int cost, int itemType)
        {
            Name = name;
            cost = Value;
            ItemType = ItemType;
        }
        public virtual int GetDamage()
        {
            return 0;
        }

        public List<Item> Inventory = new List<Item>();
        public int Gold = 500;
        Item Sword = new Item("", 5, 0);
        Item Potion = new Item("", 5, 0);

        public Item[]_inventory1;
        public Item[] _inventory2;
        public int itemSelected;

    }
}

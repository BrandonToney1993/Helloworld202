using System;
using System.Collections.Generic;
using System.Text;

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
            Value = cost;
            ItemType = ItemType;
        }

    }
}

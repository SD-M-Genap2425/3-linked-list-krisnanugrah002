using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Inventori
{
    public class ItemNode
    {
        public Item Item { get; set; }
        public ItemNode Next { get; set; }
        public ItemNode Prev { get; set; }

        public ItemNode(Item item)
        {
            Item = item;
            Next = null;
            Prev = null;
        }
    }
}

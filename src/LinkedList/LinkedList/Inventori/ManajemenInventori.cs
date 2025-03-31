using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Inventori
{
    public class ManajemenInventori
    {
        private ItemNode _head;
        private ItemNode _tail;

        public ManajemenInventori()
        {
            _head = null;
            _tail = null;
        }

        public void TambahItem(Item item)
        {
            var node = new ItemNode(item);
            if (_head == null)
            {
                _head = _tail = node;
            }
            else
            {
                _tail.Next = node;
                node.Prev = _tail;
                _tail = node;
            }
        }

        public bool HapusItem(string nama)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Item.Nama == nama)
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        _tail = current.Prev;
                    }
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string TampilkanInventori()
        {
            var current = _head;
            var sb = new StringBuilder();
            while (current != null)
            {
                sb.AppendLine($"{current.Item.Nama}; {current.Item.Kuantitas}");
                current = current.Next;
            }
            return sb.ToString().TrimEnd();
        }
    }
}

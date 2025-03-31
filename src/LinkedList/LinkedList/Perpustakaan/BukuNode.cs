using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Perpustakaan
{
    public class BukuNode
    {
        public Buku Data { get; set; }
        public BukuNode Next { get; set; }

        public BukuNode(Buku data)
        {
            Data = data;
            Next = null;
        }
    }
}

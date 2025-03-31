﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Inventori
{
    public class Item
    {
        public string Nama { get; set; }
        public int Kuantitas { get; set; }

        public Item(string nama, int kuantitas)
        {
            Nama = nama;
            Kuantitas = kuantitas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Perpustakaan
{
    public class KoleksiPerpustakaan
    {
        private BukuNode head;

        public void TambahBuku(Buku buku)
        {
            BukuNode newNode = new BukuNode(buku);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                BukuNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool HapusBuku(string judul)
        {
            BukuNode current = head, prev = null;
            while (current != null && !current.Data.Judul.Equals(judul, StringComparison.OrdinalIgnoreCase))
            {
                prev = current;
                current = current.Next;
            }

            if (current == null)
                return false;

            if (prev == null)
                head = current.Next;
            else
                prev.Next = current.Next;

            return true;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasil = new List<Buku>();
            BukuNode current = head;
            while (current != null)
            {
                if (current.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasil.Add(current.Data);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanKoleksi()
        {
            StringBuilder sb = new StringBuilder();
            BukuNode current = head;
            while (current != null)
            {
                sb.AppendLine($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }
            return sb.ToString().Trim();
        }
    }
}

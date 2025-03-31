using LinkedList.Inventori;

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        var perpustakaan = new LinkedList.Perpustakaan.KoleksiPerpustakaan();
        perpustakaan.TambahBuku(new LinkedList.Perpustakaan.Buku("Pulang", "Tereliye", 2015));
        perpustakaan.TambahBuku(new LinkedList.Perpustakaan.Buku("Hujan", "Tereliye", 2016));
        perpustakaan.TambahBuku(new LinkedList.Perpustakaan.Buku("Negeri 5 Menara", "Ahmad Fuadi", 2009));

        Console.WriteLine(perpustakaan.TampilkanKoleksi());


        // Soal ManajemenKaryawan
        var daftarKaryawan = new LinkedList.ManajemenKaryawan.DaftarKaryawan();
        daftarKaryawan.TambahKaryawan(new LinkedList.ManajemenKaryawan.Karyawan("001", "John Doe", "Manager"));
        daftarKaryawan.TambahKaryawan(new LinkedList.ManajemenKaryawan.Karyawan("002", "Jane Doe", "HR"));
        daftarKaryawan.TambahKaryawan(new LinkedList.ManajemenKaryawan.Karyawan("003", "Bob Smith", "IT"));

        Console.WriteLine(daftarKaryawan.TampilkanDaftar());


        // Soal Inventori
        ManajemenInventori manajemen = new ManajemenInventori();
        manajemen.TambahItem(new Item("Apple", 50));
        manajemen.TambahItem(new Item("Orange", 30));
        manajemen.TambahItem(new Item("Banana", 20));

        Console.WriteLine("Daftar Inventori:");
        Console.WriteLine(manajemen.TampilkanInventori());
    }
}

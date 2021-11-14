using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiPerpustakaan
{
    class Peminjam
    {
        public int IdPeminjam { get; set; }
        public string NamaPeminjam { get; set; }
        public  void DataPeminjam()
        {
            Console.WriteLine("================");
            Console.WriteLine("Id Peminjam " + IdPeminjam);
            Console.WriteLine("Nama Peminjam " + NamaPeminjam);
            Console.WriteLine("================");
        }

        public void DataPeminjam(int hari, int buku)
        {
            
            Console.WriteLine("================");
            Console.WriteLine("Id Peminjam" + IdPeminjam);
            Console.WriteLine("Nama Peminjam " + NamaPeminjam);
            int jlh_denda = 5000 * hari * buku;
            Console.WriteLine("Jumlah Denda " + jlh_denda);
            Console.WriteLine("================");
        }
    }
}

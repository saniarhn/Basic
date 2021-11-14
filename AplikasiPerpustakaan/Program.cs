using System;
using System.Collections.Generic;

namespace AplikasiPerpustakaan
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan, terlambat,jlh_buku;
            string tgl,pinjam,pinjam_buku,tahun,judul_buku,penulis;
            Console.WriteLine("==================================");
            Console.WriteLine("Aplikasi Peminjaman & Pengembalian Buku");
            Console.WriteLine("         Pada Perpustakaan           ");
            Console.WriteLine("==================================");
            Console.WriteLine("MENU");
            Menu();
            Console.WriteLine("Pilih Menu : ");
            pilihan = int.Parse(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Peminjaman Buku");

                        Peminjam PeminjamA = new Peminjam();

                        Console.WriteLine("Masukkan Id Peminjam = ");
                        PeminjamA.IdPeminjam = int.Parse(Console.ReadLine());
                        Console.WriteLine("Masukkan Nama Peminjam = ");
                        PeminjamA.NamaPeminjam = Console.ReadLine();
                        Console.WriteLine("Tanggal Peminjaman = ");
                        tgl = DateTime.Now.ToString();
                        Console.WriteLine(tgl);
                        Console.WriteLine("Judul Buku");
                        var judul = new List<string>();
                        judul.Add(Console.ReadLine());

                        for (int i = 0; i < 2; i++)
                        {

                            Console.WriteLine("Apakah Ingin Meminjam Lagi? (y/t)");
                            pinjam = Console.ReadLine();


                            switch (pinjam)
                            {
                                case "y":
                                    Console.WriteLine("Judul Buku");
                                    judul.Add(Console.ReadLine());
                                    break;
                                default:
                                    break;
                            }

                        }
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("Data Peminjaman");
                        PeminjamA.DataPeminjam();

                        foreach (var j in judul)
                        {
                            Console.WriteLine("Judul Buku " + j);
                        }
                        break;

                    }
                case 2:
                    {
                        Console.Clear();
                        Peminjam PeminjamA = new Peminjam();

                        Console.WriteLine("Masukkan Id Peminjam = ");
                        PeminjamA.IdPeminjam = int.Parse(Console.ReadLine());
                        Console.WriteLine("Masukkan Nama Peminjam = ");
                        PeminjamA.NamaPeminjam = Console.ReadLine();
                        Console.WriteLine("Jumlah Hari Keterlambatan = ");
                        terlambat = int.Parse(Console.ReadLine());
                        Console.WriteLine("Jumlah Buku");
                        jlh_buku = int.Parse(Console.ReadLine());
                        Console.Clear();
                        PeminjamA.DataPeminjam(terlambat, jlh_buku);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Masukkan Judul Buku = ");
                        judul_buku= Console.ReadLine();
                        Console.WriteLine("Nama Penulis = ");
                        penulis = Console.ReadLine();
                        Console.WriteLine("Tahun Terbit = ");
                        tahun = Console.ReadLine();
                        
                        Console.WriteLine("Apakah Ingin Memasukkan Informasi Tambahan? (y/t)");
                        pinjam_buku = Console.ReadLine();

                        switch (pinjam_buku)
                        {
                            case "y":
                                Console.WriteLine("Jenis Buku");
                                Console.WriteLine("1.Buku Pelajaran");
                                Console.WriteLine("2. Novel");
                                Console.WriteLine("Pilih Jenis Buku");
                                pilihan = int.Parse(Console.ReadLine());

                                switch (pilihan)
                                {
                                    case 1:
                                        BukuPelajaran BukuPelajaranA = new BukuPelajaran();
                                        Console.WriteLine("Masukkan Nama Pelajaran= ");
                                        BukuPelajaranA.Mapel = Console.ReadLine();
                                        BukuPelajaranA.Judul = judul_buku;
                                        BukuPelajaranA.Penulis = penulis;
                                        BukuPelajaranA.Tahun = tahun;
                                        BukuPelajaranA.DeskripsiBuku();
                                        break;
                                    case 2:
                                        Novel NovelA = new Novel();
                                        Console.WriteLine("Masukkan Nama Genre= ");
                                        NovelA.Genre = Console.ReadLine();
                                        NovelA.Judul = judul_buku;
                                        NovelA.Penulis = penulis;
                                        NovelA.Tahun = tahun;
                                        NovelA.DeskripsiBuku();
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                Book Buku = new Book();
                                Buku.Judul = judul_buku;
                                Buku.Penulis = penulis;
                                Buku.Tahun = tahun;
                                Buku.DeskripsiBuku();
                                break;
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Menu Pilihan Tidak Tersedia");
                        break;
                    }
            }
           

        }

        private static void Menu()
        {
            Console.WriteLine("1.Peminjaman Buku");
            Console.WriteLine("2.Pengembalian Buku");
            Console.WriteLine("3.Daftar Buku");

        }

        /*private static int Denda(int terlambat,int jlh_buku)
        {
            int denda_per_hari = 5000;
            int denda;

            return denda = denda_per_hari * terlambat * jlh_buku;
        }*/
    }
}

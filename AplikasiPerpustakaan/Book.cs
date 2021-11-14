using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiPerpustakaan
{
    class Book
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Tahun { get; set; }

        public virtual void DeskripsiBuku()
        {
            Console.WriteLine( "================" );
            Console.WriteLine("Judul Buku " + Judul);
            Console.WriteLine("Nama Penulis " + Penulis);
            Console.WriteLine("Tahun Terbit " + Tahun);
   
        }
        
    }
}

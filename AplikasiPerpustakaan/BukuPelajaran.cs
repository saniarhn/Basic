using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiPerpustakaan
{
    class BukuPelajaran : Book
    {
        public string Mapel { get; set; }
        public override void DeskripsiBuku()
        {
            base.DeskripsiBuku();
            Console.WriteLine("Mata Pelajaran " + Mapel);
            Console.WriteLine("================");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiPerpustakaan
{
    class Novel : Book
    {
        public string Genre { get; set; }
        public override void DeskripsiBuku()
        {
            base.DeskripsiBuku();
            Console.WriteLine("Genre " + Genre);
            Console.WriteLine("================");
        }
    }
}

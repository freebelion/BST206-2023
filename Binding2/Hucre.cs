using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding2
{
    public class Hucre
    {
        public int SatirNo { get; set; }
        public int SutunNo { get; set; }
        public bool MayinVar { get; set; }
        public int KomsuMayinSayisi { get; set; }

        public Hucre()
        {
            MayinVar = false;
            KomsuMayinSayisi = 0;
        }

        public override string ToString()
        {
            return KomsuMayinSayisi.ToString();
        }
    }
}

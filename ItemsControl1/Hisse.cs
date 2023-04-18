using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControl1
{
    public class Hisse
    {
        public string? Kod { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return Kod + " (" + Fiyat.ToString("C2") + ")";
        }
    }

    public class HisseListe : ObservableCollection<Hisse>
    { }
}

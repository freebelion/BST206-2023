using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding2
{
    public class Pano
    {
        private int nSatir = 5;
        private int nSutun = 5;
        private int nMayin = 5;

        private Hucre[,] hucreMatris;
        public ObservableCollection<Hucre> Hucreler {  get; set; }
        public int SatirSayisi
        {
            get { return nSatir; }
            set
            {
                nSatir = value;
                PanoYenile();
            }
        }

        public int SutunSayisi
        {
            get { return nSutun; }
            set
            {
                nSutun = value;
                PanoYenile();
            }
        }

        public Pano()
        {
            hucreMatris = new Hucre[1,1];
            Hucreler = new ObservableCollection<Hucre>();
            PanoYenile();
        }

        public void PanoYenile()
        {
            Hucreler.Clear();
            hucreMatris = new Hucre[nSatir, nSutun];

            for(int i=0; i<nSatir; i++)
            {
                for(int j=0; j<nSutun; j++)
                {
                    Hucre h = new Hucre();
                    h.SatirNo = i;
                    h.SutunNo = j;
                    hucreMatris[i,j] = h;
                    Hucreler.Add(h);
                }
            }

            MayinlariYerlestir();
        }

        public void MayinlariYerlestir()
        {
            int hucreSayisi = nSatir * nSutun;
            nMayin = (int)Math.Sqrt(hucreSayisi);
            
            Random rnd = new Random();

            int mayinliHucreNo;
            Hucre mayinliHucre;
            Hucre komsuHucre;

            while (nMayin > 0)
            {
                mayinliHucreNo = rnd.Next(Hucreler.Count);
                mayinliHucre = Hucreler[mayinliHucreNo];
                // O hücrede zaten mayın vardıysa atlayıp tekrar dene
                if(mayinliHucre.MayinVar) { continue; }

                mayinliHucre.MayinVar = true;
                mayinliHucre.KomsuMayinSayisi = int.MinValue;

                if (mayinliHucre.SatirNo > 0)
                {
                    komsuHucre = hucreMatris[mayinliHucre.SatirNo - 1, mayinliHucre.SutunNo];
                    if (!komsuHucre.MayinVar)
                    { komsuHucre.KomsuMayinSayisi++; }
                }
                if (mayinliHucre.SatirNo < SatirSayisi-1)
                {
                    komsuHucre = hucreMatris[mayinliHucre.SatirNo + 1, mayinliHucre.SutunNo];
                    if (!komsuHucre.MayinVar)
                    { komsuHucre.KomsuMayinSayisi++; }
                }
                if (mayinliHucre.SutunNo > 0)
                {
                    komsuHucre = hucreMatris[mayinliHucre.SatirNo, mayinliHucre.SutunNo - 1];
                    if (!komsuHucre.MayinVar)
                    { komsuHucre.KomsuMayinSayisi++; }
                }
                if (mayinliHucre.SutunNo < SutunSayisi - 1)
                {
                    komsuHucre = hucreMatris[mayinliHucre.SatirNo, mayinliHucre.SutunNo + 1];
                    if (!komsuHucre.MayinVar)
                    { komsuHucre.KomsuMayinSayisi++; }
                }

                nMayin--;
            }
        }
    }
}

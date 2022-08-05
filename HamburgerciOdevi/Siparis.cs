using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOdevi
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemes = new List<EkstraMalzeme>();
        }
        public Menu SecilenMenu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemes { get; set; }
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }
        public double ToplamTutar { get; set; }
        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SecilenMenu.Fiyati;
            switch (Boyut)
            {
              
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.30;
                    break;
                default:
                    break;
            }
            foreach (var ekstra in EkstraMalzemes)
            {
                ToplamTutar += ekstra.Fiyati;
            }
            ToplamTutar = ToplamTutar * Adet;
        }
       
        
        // listbox a seçilen siparişi ekrana düzgün formatta yazmak için to string override edicez.
        public override string ToString()
        {
            if (EkstraMalzemes.Count<1)
            {
                return $"Menu : {SecilenMenu}, Adet : {Adet}, Boy : {Boyut}, ToplamTutar : {ToplamTutar}";
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (EkstraMalzeme ekstra in EkstraMalzemes)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ","; // ranch, ketçap, ...
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(','); //en son eklenen virgülü siler.
                return $"Menu : {SecilenMenu}, Adet : {Adet}, Boy : {Boyut}, ToplamTutar : {ToplamTutar}, Ekstra : {ekstraMalzemeler}";
            }
        }
    }
}

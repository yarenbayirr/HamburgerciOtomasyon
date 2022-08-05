using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciOdevi
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public double Fiyati { get; set; }
       
        // to string metodunu ezdiğimiz için artık nesne oluşturduğumuzda hamburgerci.menu falan demeyecek
        public override string ToString()
        {
            return $"Menu : {MenuAdi}, Fiyat : {Fiyati}";
        }
    }
}

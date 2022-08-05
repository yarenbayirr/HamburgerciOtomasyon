using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciOdevi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu() { MenuAdi="BigMac",Fiyati = 76 },
            new Menu() { MenuAdi = "2LiTavukBurgerMenu", Fiyati = 45 },
            new Menu() { MenuAdi = "CheeseBurger", Fiyati = 50 },
            new Menu() { MenuAdi = "KöfteBurger", Fiyati = 88 },
            new Menu() { MenuAdi = "SteakHouse", Fiyati = 150 }
        };



        public static List<EkstraMalzeme> EkstraMalzemes = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme() {EkstraAdi = "Ranch", Fiyati=2.5},
            new EkstraMalzeme() {EkstraAdi = "Ketçap", Fiyati=1.5},
            new EkstraMalzeme() {EkstraAdi = "Mayonez", Fiyati=1.5},
            new EkstraMalzeme() {EkstraAdi = "Barbekü", Fiyati=3.5},
            new EkstraMalzeme() {EkstraAdi = "Buffalo", Fiyati=3.5}
        };
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public static List<Siparis> tumSiparisler = new List<Siparis>();



        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in Menuler)
            {
                cmbMenuler.Items.Add(item);
            }
            foreach (var item in EkstraMalzemes)
            {
                
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item }); //tag hem fiyatı hem text i tutar
            }
            foreach (var item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item);
            }
            TutarHesapla();
            rdbKucuk.Checked = true;
            //cmbMenuler.SelectedItem = 

        }
        private double TutarHesapla()
        {
            double toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yenisiparis = new Siparis();
            yenisiparis.SecilenMenu = (Menu)cmbMenuler.SelectedItem;

            if (rdbKucuk.Checked)
            {
                yenisiparis.Boyut = Boyut.Kucuk;
            }
            else if (rdbOrta.Checked)
            {
                yenisiparis.Boyut = Boyut.Orta;
            }
            else if (rdbBuyuk.Checked)
            {
                yenisiparis.Boyut = Boyut.Buyuk;
            }

            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yenisiparis.EkstraMalzemes.Add((EkstraMalzeme)item.Tag);
                }
            }
            yenisiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yenisiparis.Hesapla();

            mevcutSiparisler.Add(yenisiparis);
            tumSiparisler.Add(yenisiparis);
            lbxSiparisler.Items.Add(yenisiparis);

            TutarHesapla();
            //temizle metodu çağır
            
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı" + TutarHesapla().ToString() + "\nSatın almayı tamamlamak ister misin ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla(); // 0'a çekiyor labelda 0 yazacak
                MessageBox.Show("Siparişiniz tamamlandı");
            }
            else
            {
                MessageBox.Show("Sipariş iptal edildi");
            }
        }
    }
}

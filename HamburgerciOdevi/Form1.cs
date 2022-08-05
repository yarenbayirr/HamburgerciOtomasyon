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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {

            ChildFormAc(new Form2());
        }
        void ChildFormAc(Form childForm) 
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildFormAc(new Form5());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildFormAc(new Form3());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildFormAc(new Form4());
        }
    }
}

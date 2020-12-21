using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Urun
{
    public partial class UrunEkle : Form
    {
        private IUrunService _urunService;
        public UrunEkle(IUrunService urunService)
        {
            InitializeComponent();
            _urunService = urunService;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _urunService.Ekle(new Entities.Entities.Urun
            {
                UrunAd = txtUrunAd.Text,
                KategoriAd = txtKategoriAd.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text)
            });

            MessageBox.Show("Ürün Eklendi");
            this.Close();
        }
    }
}

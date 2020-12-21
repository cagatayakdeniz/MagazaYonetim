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
    public partial class UrunAnaEkran : Form
    {
        private IUrunService _urunService;
        public UrunAnaEkran(IUrunService urunService)
        {
            InitializeComponent();
            _urunService = urunService;
        }

        private void ListeyiGetir()
        {
            dgwUrun.DataSource = _urunService.Listele();
        }

        private void UrunAnaEkran_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        private void AlanlariTemizle()
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtKategoriAd.Text = "";
            txtFiyat.Text = "";
        }

        private void dgwUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dgwUrun.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwUrun.CurrentRow.Cells[1].Value.ToString();
            txtKategoriAd.Text = dgwUrun.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dgwUrun.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            _urunService.Sil(new Entities.Entities.Urun
            {
                UrunId = Convert.ToInt32(txtUrunId.Text)
            });

            MessageBox.Show("Ürün Silindi.");
            AlanlariTemizle();
            ListeyiGetir();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            _urunService.Guncelle(new Entities.Entities.Urun
            {
                UrunId = Convert.ToInt32(txtUrunId.Text),
                UrunAd = txtUrunAd.Text,
                KategoriAd = txtKategoriAd.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text)
            });

            MessageBox.Show("Ürün Güncellendi.");
            AlanlariTemizle();
            ListeyiGetir();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle(_urunService);
            urunEkle.ShowDialog();
            ListeyiGetir();
        }
    }
}

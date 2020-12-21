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

namespace Sunum.Personel
{
    public partial class PersonelAnaEkran : Form
    {
        private IPersonelService _personelService;
        public PersonelAnaEkran(IPersonelService personelService)
        {
            InitializeComponent();
            _personelService = personelService;
        }

        private void ListeyiGetir()
        {
            dgwPersonel.DataSource = _personelService.Listele();
        }

        private void PersonelAnaEkran_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        private void dgwPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelId.Text = dgwPersonel.CurrentRow.Cells[0].Value.ToString();
            txtPersonelNo.Text = dgwPersonel.CurrentRow.Cells[1].Value.ToString();
            txtPersonelAd.Text = dgwPersonel.CurrentRow.Cells[2].Value.ToString();
            txtPersonelSoyad.Text = dgwPersonel.CurrentRow.Cells[3].Value.ToString();
            txtPersonelMaas.Text = dgwPersonel.CurrentRow.Cells[4].Value.ToString();
            txtPersonelDepartman.Text = dgwPersonel.CurrentRow.Cells[5].Value.ToString();
        }

        private void AlanlariTemizle()
        {
            txtPersonelId.Text = "";
            txtPersonelNo.Text = "";
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelMaas.Text = "";
            txtPersonelDepartman.Text = "";
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            _personelService.Sil(new Entities.Entities.Personel
            {
                PersonelId = Convert.ToInt32(txtPersonelId.Text)
            });

            MessageBox.Show("Personel Silindi.");
            AlanlariTemizle();
            ListeyiGetir();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            _personelService.Guncelle(new Entities.Entities.Personel
            {
                PersonelId = Convert.ToInt32(txtPersonelId.Text),
                PersonelNo = Convert.ToInt32(txtPersonelNo.Text),
                PersonelAd = txtPersonelAd.Text,
                PersonelSoyad = txtPersonelSoyad.Text,
                Maas = Convert.ToDecimal(txtPersonelMaas.Text),
                Departman = txtPersonelDepartman.Text
            });

            MessageBox.Show("Personel Güncellendi.");
            AlanlariTemizle();
            ListeyiGetir();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle(_personelService);
            personelEkle.ShowDialog();
            ListeyiGetir();
        }
    }
}

using Business;
using Business.DependencyInjection;
using Sunum.Personel;
using Sunum.Urun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            _personelService = KernelFactory.GetService<IPersonelService>();
            _urunService = KernelFactory.GetService<IUrunService>();
        }

        private IPersonelService _personelService;
        private IUrunService _urunService;

        private void pictureBoxPersonel_Click(object sender, EventArgs e)
        {
            PersonelAnaEkran personelAnaEkran = new PersonelAnaEkran(_personelService);       
            personelAnaEkran.ShowDialog();
            this.Close();
        }

        private void pictureBoxUrun_Click(object sender, EventArgs e)
        {
            UrunAnaEkran urunAnaEkran = new UrunAnaEkran(_urunService);
            urunAnaEkran.ShowDialog();
            this.Close();
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

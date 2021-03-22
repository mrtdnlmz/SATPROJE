using SAT.Business.Abstract;
using SAT.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAT.Business.Concrete;
using SAT.Entities.Concrete;

namespace SAT.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _personelServis = InstanceFactory.GetInstance<IPersonelServis>();
            _gunHesapServis = InstanceFactory.GetInstance<IGunHesapServis>();
            _tazminatServis = InstanceFactory.GetInstance<ITazminatServis>();
            _hesapServis = InstanceFactory.GetInstance<IHesapServis>();
            _sosyalYardimServis = InstanceFactory.GetInstance<ISosyalYardimServis>();

        }

        private void txtSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");


                txtAdiSoyadi.Text = _personelServis.Get(txtSicilNo.Text).Adi + " " +
                                    _personelServis.Get(txtSicilNo.Text).Soyadi;
                txtiseGiris.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).iseGirisTarihi.ToShortDateString());
                txtistenCikis.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).istenCikisTarihi);
                txtDepartman.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).Departman);
                txtUnvan.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).Unvan);
                txtNetUcret.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).NetUcret);
                txtSendikaDurumu.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).Kapsam);
                txtSehir.Text = Convert.ToString(_personelServis.Get(txtSicilNo.Text).SehirID);

            }
        }

        private IPersonelServis _personelServis;
        private IGunHesapServis _gunHesapServis;
        private ITazminatServis _tazminatServis;
        private ISosyalYardimServis _sosyalYardimServis;
        private IHesapServis _hesapServis;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAdiSoyadi.Enabled = false;
            txtSendikaDurumu.Enabled = false;
            txtiseGiris.Enabled = false;
            txtGunHesap.Enabled = false;
            txtNetUcret.Enabled = false;
            txtDepartman.Enabled = false;
            txtUnvan.Enabled = false;
            txtSehir.Enabled = false;
            txtCalismaGun.Enabled = false;
            txtihbarSure.Enabled = false;
            txtOdenecekKidem.Enabled=false;
            txtOdenecekihbar.Enabled=false;
            txtBostaGecen.Enabled = false;
            txtiseBaslatmama.Enabled = false;
            txtSendikaOdeme.Enabled = false;
            txtKidemBrut.Enabled = false;
            txtTopKidemBrut.Enabled = false;
            txtNetKidem.Enabled = false;
            txtKidemDV.Enabled = false;
            txtihbarBrut.Enabled = false;
            txtihbarGV1.Enabled = false;
            txtihbarGV2.Enabled = false;
            txtihbarDV.Enabled = false;
            txtTopihbarGV.Enabled = false;
            txtGenelToplam.Enabled = false;
            txtTazminatToplam.Enabled = false;
            txtKalanizinUcret.Enabled = false;
            txtihbarBrut.Enabled = false;
            txtNetihbar.Enabled = false;
            txtTopihbarBrut.Enabled = false;



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //_personelServis.Add(new Personel()); kontrol edilecek.
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            GunHesap();
            ihbarSureHesap();
            KidemHesap();
            Hesapla();

            if (cxbKidem.Checked==true)
            {
                ToplamNetKidem();
            }
            else
            {
                
            }
            
        }

        int gun, ay1, yil1;
        public void GunHesap()
        {
            DateTime sonTarih = DateTime.Parse(txtistenCikis.Text);

            DateTime ilkTarih = DateTime.Parse(txtiseGiris.Text);

            int[] sonuc = _gunHesapServis.ikiTarihFarki(sonTarih, ilkTarih);

            txtGunHesap.Text = sonuc[0].ToString() + " Yıl " + sonuc[1].ToString() + " Ay " + sonuc[2].ToString() + " Gün";
            gun = sonuc[2];
            ay1 = sonuc[1];
            yil1 = sonuc[0];

        }

        public void ihbarSureHesap()
        {
            DateTime ilkTarih = DateTime.Parse(txtiseGiris.Text);
            DateTime sonTarih = DateTime.Parse(txtistenCikis.Text);
            int kacGun = _gunHesapServis.ihbarHesap(ilkTarih, sonTarih);
            txtCalismaGun.Text = Convert.ToString(kacGun + " " + "Gün");
            int ihbarSure = _gunHesapServis.ihbarGun(kacGun);
            txtihbarSure.Text = Convert.ToString(ihbarSure * 7 + " " + "Gün");

        }
        int yil, sehir,ay;


        bool kapsam;
        public void KidemHesap()
        {

            var sonTarih = DateTime.Parse(txtistenCikis.Text);
            yil = _gunHesapServis.yilBul(sonTarih);
            sehir = _personelServis.Get(txtSicilNo.Text).SehirID;
            kapsam = Convert.ToBoolean(_personelServis.Get(txtSendikaDurumu.Text));
            ay = _gunHesapServis.ayBul(sonTarih);
            

        }

        public void Hesapla()
        {
             
            double net =Convert.ToDouble(txtNetUcret.Text) ;
            double KidemBrutu = _sosyalYardimServis.BrutGetir(yil, sehir,kapsam,net);
            txtTopKidemBrut.Text = Convert.ToString(Math.Round(KidemBrutu,2));
            double KidemNet = _sosyalYardimServis.KidemBrutKontrol(yil,ay1);
            double ToplamKidemNet = _sosyalYardimServis.SonHesap(gun,ay1,yil1);
            _sosyalYardimServis.KidemHesapla();

            txtKidemBrut.Text = Convert.ToString(Math.Round(KidemNet,2));
            txtKidemDV.Text =Convert.ToString(Math.Round(_sosyalYardimServis.NetKidemHesap(),2) ) ;

        }

        public void ToplamNetKidem()
        {
            txtNetKidem.Text =Convert.ToString(Math.Round( _sosyalYardimServis.NetKidemHesap(),2));
            
        }

    }
}

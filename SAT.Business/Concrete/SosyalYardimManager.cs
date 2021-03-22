using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.TestHelper;
using SAT.Business.Abstract;
using SAT.DataAccess.Abstract;
using SAT.Entities.Concrete;

namespace SAT.Business.Concrete
{
    public class SosyalYardimManager : ISosyalYardimServis
    {
        private ISosyalYardimDal _sosyalYardimDal;
        private IPersonelDal _personelDal;
        private IKidemTavanDal _kidemTavanDal;
        public SosyalYardimManager(ISosyalYardimDal sosyalYardimDal, IPersonelDal personelDal, IKidemTavanDal kidemTavanDal)
        {
            _sosyalYardimDal = sosyalYardimDal;
            _personelDal = personelDal;
            _kidemTavanDal = kidemTavanDal;
        }

        double SosyalBrut, NetinBrutu, ikramiyeBrut, KidemBrutu;
        public int BrutGetir(int yil, int sehir, bool kapsam, double net)
        {
            if (yil == _sosyalYardimDal.Get(p => p.Yil == yil).Yil)
            {
                if (sehir == 1)
                {
                    if (kapsam == false)
                    {
                        SosyalBrut = Convert.ToDouble(_sosyalYardimDal.Get(p => p.Yil == yil).CankiriKDBrut);
                    }

                    else
                    {
                        SosyalBrut = Convert.ToDouble(_sosyalYardimDal.Get(p => p.Yil == yil).CankiriKiBrut);
                    }
                }

                else if (sehir == 2)
                {
                    SosyalBrut = Convert.ToDouble(_sosyalYardimDal.Get(p => p.Yil == yil).AnkaraBrut);
                }

                else
                {
                    SosyalBrut = Convert.ToDouble(_sosyalYardimDal.Get(p => p.Yil == yil).istanbulBrut);
                }
            }

            ikramiyeBrut = Convert.ToDouble((net / 30) * 80 / 365 / 0.7149);
            NetinBrutu = Convert.ToDouble(net / 0.7149);
            KidemBrutu = SosyalBrut + ikramiyeBrut + NetinBrutu;

            return Convert.ToInt32(KidemBrutu);


        }



        private double ilkKidem;
        public double KidemBrutKontrol(int yil, int ay1)
        {

            if (yil == _kidemTavanDal.Get(p => p.Yil == yil).Yil)
            {
                if (ay1 <= 6)
                {
                    ilkKidem = _kidemTavanDal.Get(p => p.Yil == yil).KidemTavan1;
                }
                else
                {
                    ilkKidem = _kidemTavanDal.Get(p => p.Yil == yil).KidemTavan2;
                }
            }

            return ilkKidem;
        }

        private double ToplamKidem;
        public void KidemHesapla()
        {
            if (KidemBrutu >= ilkKidem)
            {
                ToplamKidem = ilkKidem;
            }
            else
            {
                ToplamKidem = KidemBrutu;
            }
        }



        private double ToplamKidemGun;
        public double SonHesap(int gun, int ay1, int yil1)
        {
            ToplamKidemGun = Convert.ToDouble(yil1 * 35 + ay1 * 2.92 + gun * 35 / 365);
            return ToplamKidemGun;
        }

       
        public double NetKidemHesap()
        {
            double DV = 0.00759;
            double BrutKidem, NetKidem;

            BrutKidem = Convert.ToDouble(ToplamKidem / 30) * ToplamKidemGun;
            NetKidem =BrutKidem - Convert.ToDouble(BrutKidem * DV);
            return NetKidem;
        }


    }
}

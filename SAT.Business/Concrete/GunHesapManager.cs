using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SAT.Business.Abstract;

namespace SAT.Business.Concrete
{
    public class GunHesapManager : IGunHesapServis
    {
        //private IGunHesapDal _gunHesapDal;

        //public GunHesapManager(IGunHesaplDal gunhesapDal)
        //{
        //    _gunhesapDal = gunhesapDal;
        //}

        public int[] ikiTarihFarki(DateTime sonTarih, DateTime ilkTarih)
        {
            {

                int ilkGun, ilkAy, ilkYil;

                int sonGun, sonAy, sonYil;

                int farkYil, farkAy, farkGun;

                farkYil = 0;
                farkAy = 0;
                farkGun = 0;



                ilkYil = ilkTarih.Year;

                ilkAy = ilkTarih.Month;

                ilkGun = ilkTarih.Day;



                sonGun = sonTarih.Day;

                sonAy = sonTarih.Month;

                sonYil = sonTarih.Year;



                if (sonGun < ilkGun)

                {

                    sonGun += DateTime.DaysInMonth(sonYil, sonAy);

                    farkGun = sonGun - ilkGun;

                    sonAy--;

                    if (sonAy < ilkAy)

                    {

                        sonAy += 12;

                        sonYil--;

                        farkAy = sonAy - ilkAy;

                        farkYil = sonYil - ilkYil;

                    }

                    else

                    {

                        farkAy = sonAy - ilkAy;

                        farkYil = sonYil - ilkYil;

                    }

                }

                else

                {

                    farkGun = sonGun - ilkGun;

                    if (sonAy < ilkAy)

                    {

                        sonAy += 12;

                        sonYil--;

                        farkAy = sonAy - ilkAy;

                        farkYil = sonYil - ilkYil;

                    }

                    else

                    {

                        farkAy = sonAy - ilkAy;

                        farkYil = sonYil - ilkYil;

                    }

                }



                int[] sonuc = new int[3];

                sonuc[0] = farkYil;

                sonuc[1] = farkAy;

                sonuc[2] = farkGun;

                return sonuc;

            }
        }


        public int kacGun, ihbarSure;
        public int ihbarHesap(DateTime sonTarih, DateTime ilkTarih)
        {
            
            kacGun = (int)(ilkTarih-sonTarih).TotalDays+1;
            return kacGun;

        }

        public int ihbarGun(int kacGun)
        {
            if (kacGun <= 42)
            {
                ihbarSure = 2;
            }
            else if (kacGun > 43 && kacGun <= 546)
            {
                ihbarSure = 4;
            }
            else if (kacGun > 547 && kacGun <= 1092)
            {
                ihbarSure = 6;
            }
            else if (kacGun >= 1093)
            {
                ihbarSure = 8;
            }

            return ihbarSure;
        }

        public int yilBul(DateTime sonTarih)
        {
            int sonYil;

            sonYil = sonTarih.Year;

            return sonYil;
        }

        public int ayBul(DateTime sonTarih)
        {
            int sonAy;

            sonAy = sonTarih.Month;

            return sonAy;
        }
    }


}


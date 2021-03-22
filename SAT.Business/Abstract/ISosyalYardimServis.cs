using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Entities.Concrete;

namespace SAT.Business.Abstract
{
    public interface ISosyalYardimServis
    {
        void KidemHesapla();
        int BrutGetir(int yil, int sehir, bool kapsam,double net);
        double KidemBrutKontrol(int yil, int ay1);
        double SonHesap(int gun, int ay1, int yil1);
        double NetKidemHesap();


    }
}

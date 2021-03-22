using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Business.Abstract
{
   public interface IGunHesapServis
    {

        int[] ikiTarihFarki(DateTime sonTarih, DateTime ilkTarih);
        int ihbarHesap(DateTime sonTarih, DateTime ilkTarih);
        int ihbarGun(int kacGun);
        int yilBul(DateTime sonTarih);
        int ayBul(DateTime sonTarih);
    }
}

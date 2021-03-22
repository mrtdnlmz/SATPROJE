using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Entities.Abstract;

namespace SAT.Entities.Concrete
{
   public class Tazminat:IEntity
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime iseGirisTarihi { get; set; }
        public DateTime istenCikisTarihi { get; set; }
        public string Departman { get; set; }
        public string Unvan { get; set; }
        public double NetUcret { get; set; }
        public double BrutUcret { get; set; }
        public double KidemeEsasUcret { get; set; }
        public Int16 ToplamCalismaGunu { get; set; }
        public Int16 Yil { get; set; }
        public Int16 Ay { get; set; }
        public Int16 Gun { get; set; }
        public double ToplamKidem { get; set; }
        public double DVKidem { get; set; }
        public double NetKidem { get; set; }
        public double ihbaraEsasBrut { get; set; }
        public Int16 ihbarSuresi { get; set; }
        public double GV1 { get; set; }
        public double GV2 { get; set; }
        public double ToplamGV { get; set; }
        public double DVihbar { get; set; }
        public double Netihbar { get; set; }
        public double BostaGecenSure { get; set; }
        public double iseBaslatmama { get; set; }
        public double Sendikal { get; set; }
        public double EkOdeme { get; set; }
        public double SonMaas { get; set; }
        public Int16 YillikizinSure { get; set; }
        public double YillikizinTutar { get; set; }
        public double GenelToplam { get; set; }
        public char Aciklama { get; set; }
        public bool Sil { get; set; }


    }
}

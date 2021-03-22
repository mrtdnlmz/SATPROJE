using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Entities.Abstract;

namespace SAT.Entities.Concrete
{
    public class SosyalYardim:IEntity
    {
        public int ID { get; set; }
        public Int16 Yil { get; set; }
        public double CankiriYol { get; set; }
        public double CankiriYemek { get; set; }
        public double AnkaraYol { get; set; }
        public double AnkaraYemek { get; set; }
        public double istanbulYol { get; set; }
        public double istanbulYemek { get; set; }
        public double GidaGiyim { get; set; }
        public double CocukYrd { get; set; }
        public double AileYrd { get; set; }
        public double YakacakYrd { get; set; }
        public double EgitimYrd { get; set; }
        public double YipranmaOd { get; set; }
        public double DevamOd { get; set; }
        public double BayramYrd { get; set; }
        public double CankiriKiBrut { get; set; }
        public double CankiriKDBrut { get; set; }
        public double AnkaraBrut { get; set; }
        public double istanbulBrut { get; set; }


    }
}

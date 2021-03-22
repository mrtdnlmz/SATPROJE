using SAT.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Entities.Concrete
{
    public class YasalOran : IEntity
    {
        public int id { get; set; }
        public double DamgaVergisi { get; set; }
        public byte GVOran1 { get; set; }
        public byte GVOran2 { get; set; }
        public byte GVOran3 { get; set; }
        public byte GVOran4 { get; set; }

    }
}

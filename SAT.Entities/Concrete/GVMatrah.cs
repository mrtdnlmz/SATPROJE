using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Entities.Abstract;

namespace SAT.Entities.Concrete
{
    public class GVMatrah:IEntity
    {
        public int ID { get; set; }
        public Int16 Yil { get; set; }
        public double Matrah1 { get; set; }
        public double Matrah2 { get; set; }
        public double Matrah3 { get; set; }
        public double Matrah4 { get; set; }
        public double Matrah5 { get; set; }

    }
}

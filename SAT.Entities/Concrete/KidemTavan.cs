using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT.Entities.Abstract;

namespace SAT.Entities.Concrete
{
    public class KidemTavan:IEntity
    {
        public int ID { get; set; }
        public Int16 Yil { get; set; }
        public double KidemTavan1 { get; set; }
        public double KidemTavan2 { get; set; }

    }
}

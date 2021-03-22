using SAT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DataAccess.Concrete.EntityFramework
{
    public class SATContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<YasalOran> YasalOranlar { get; set; }
        public DbSet<KidemTavan> KidemTavanlari { get; set; }
        public DbSet<GVMatrah> GVMatrahlari { get; set; }
        public DbSet<Tazminat> Tazminatlar { get; set; }
        public DbSet<SosyalYardim> SosyalYardims { get; set; }

    }
}

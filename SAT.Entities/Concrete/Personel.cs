using SAT.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Entities.Concrete
{
    public class Personel : IEntity
    {
        public int ID { get; set; }
        public string SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime iseGirisTarihi { get; set; }
        public Nullable<DateTime> istenCikisTarihi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public String Departman { get; set; }
        public String Unvan { get; set; }
        public Nullable<double> NetUcret { get; set; }
        public Nullable<bool> Kapsam { get; set; }
        public Nullable<byte> Foto { get; set; }
        public int SehirID { get; set; }
        public Nullable<bool> Sil { get; set; }
    }
}

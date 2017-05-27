using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.Model
{
    public class Monan
    {
        public Monan() { }
        [Key]
        public string Monan_ID { get; set; }
        public string TenMonan { get; set; }
        public int Giatien { get; set; }
        public string LoaiMonan { get; set; }
        public virtual ICollection<Chitiet_donhang> Chitiet_donhang { get; set; }
    }
}

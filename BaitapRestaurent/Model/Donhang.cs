using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.Model
{
    public class Donhang
    {
        public Donhang() { }
        [Key]
        public string Donhang_ID { get; set; }
        public string NV_ID { get; set; }
        public string Banan_ID { get; set; }
        public DateTime ThoigianTaodon { get; set; }
        public bool Tinhtrang { get; set; }
        [ForeignKey("NV_ID")]
        public virtual Nhanvien Nhanvien { get; set; }
        [ForeignKey("Banan_ID")]
        public virtual Banan Banan { get; set; }

    }
}

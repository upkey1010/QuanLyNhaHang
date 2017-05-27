using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.Model
{
    public class Chitiet_donhang
    {
        public Chitiet_donhang() { }
        [Key, Column(Order = 1)]
        public string Donhang_ID { get; set; }
        [Key, Column(Order = 2)]
        public string Monan_ID { get; set; }

        public int Soluong { get; set; }

        [ForeignKey("Monan_ID")]
        public virtual Monan Monan { get; set; }
        [ForeignKey("Donhang_ID")]
        public virtual Donhang Donhang { get; set; }

    }
}

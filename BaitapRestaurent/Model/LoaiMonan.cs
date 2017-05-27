using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.Model
{
     public class LoaiMonan
    {
        public LoaiMonan() { }
        [Key]
        public string LoaiMonan_ID { get; set; }
        public string TenLoaimonan { get; set; }
        public virtual ICollection<Monan> Monan { get; set; }

    }
}

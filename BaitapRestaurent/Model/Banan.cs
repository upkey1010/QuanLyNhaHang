using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.Model
{
    public class Banan
    {
        public Banan() { }
        [Key]
        public string Banan_ID { get; set; }
        public string TenBanan { get; set; }
        public bool Tinhtrang { get; set; }

        public virtual ICollection<Donhang> Donhang { get; set; }


    }
}

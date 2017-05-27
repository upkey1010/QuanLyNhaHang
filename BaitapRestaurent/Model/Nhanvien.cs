using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapRestaurent.Model
{
    public class Nhanvien
    {
        public Nhanvien() { }
        [Key]
        public string NV_ID { get; set; }
        public string TenNV { get; set; }
        public string TenDangNhap { get; set; }
        public string Matkhau { get; set; }
        public DateTime Ngaysinh { get; set; }
        public bool Gioitinh { get; set; }
        public string Capbac { get; set; }

        public virtual ICollection<Donhang> Donhang { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Buoi4.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Phieugiaohang = new HashSet<Phieugiaohang>();
        }
        [Key]
        [StringLength(50),DisplayName("Ma nhan vien")]
        public string Manv { get; set; }
        [StringLength(50), DisplayName("Ten nhan vien")]
        public string Tennv { get; set; }
        [DisplayName("Ngay sinh"),DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime? Ngaysinh { get; set; }
        [DisplayName("Phai")]
        public bool? Phai { get; set; }
        [StringLength(50), DisplayName("Dia chi")]
        public string Diachi { get; set; }
        [StringLength(50), DisplayName("Password")]
        public string Password { get; set; }

        public ICollection<Phieugiaohang> Phieugiaohang { get; set; }
    }
}

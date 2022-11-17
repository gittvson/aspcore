using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Buoi4.Models
{
    public partial class Loaihanghoa
    {
        public Loaihanghoa()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }
        [Key]
        [StringLength(50), DisplayName("Ma loai hang ")]
        [Required(ErrorMessage = "Xin nhap ma loai hang")]
        public string Maloai { get; set; }
        [StringLength(50), DisplayName("Ten loai hang")]
        [Required(ErrorMessage = "Xin nhap ten loai hang")]
        public string Tenloai { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Buoi4.Models
{
    public partial class Nhasanxuat
    {
        public Nhasanxuat()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }
        [Key]
        [StringLength(50), DisplayName("Ma nha san xuat")]
        [Required(ErrorMessage = "Xin nhap ma nha san xuat")]
        public string Mansx { get; set; }
        [StringLength(50), DisplayName("Ten nha san xuat ")]
        [Required(ErrorMessage = "Xin nhap ten nha san xuat")]
        public string Tennsx { get; set; }
        [StringLength(50), DisplayName("Dia chi")]
        [Required(ErrorMessage = "Xin nhap dia chi")]
        public string Diachi { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}

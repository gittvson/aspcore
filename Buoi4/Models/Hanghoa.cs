using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Buoi4.Models
{
    public partial class Hanghoa
    {
        public Hanghoa()
        {
            Chitietphieudathang = new HashSet<Chitietphieudathang>();
            Chitietphieugiaohang = new HashSet<Chitietphieugiaohang>();
        }
        [Key]
        [StringLength(50), DisplayName("Ma hang hoa")]
        [Required(ErrorMessage ="Xin nhap ma hang hoa")]
        public string Mahang { get; set; }

        [StringLength(50), DisplayName("Ten hang")]
        [Required(ErrorMessage = "Xin nhap ten hang")]
        public string Tenhang { get; set; }
        [StringLength(50), DisplayName("Don vi tinh")]
        [Required(ErrorMessage = "Xin nhap do vi tinh")]
    
        public string Donvitinh { get; set; }
        [DisplayName("Don gia")]
        [Required(ErrorMessage = "Xin nhap don gia")]
        
        public double? Dongia { get; set; }
        [StringLength(50), DisplayName("Hinh anh")]

        public string Hinh { get; set; }
        [StringLength(50), DisplayName("Ma loai hang")]

        public string Maloai { get; set; }
        [StringLength(50), DisplayName("Ma nha san xuat")]
        public string Mansx { get; set; }

        public Loaihanghoa loaihanghoa { get; set; }
        public Nhasanxuat nhasanxuat { get; set; }
        public ICollection<Chitietphieudathang> Chitietphieudathang { get; set; }
        public ICollection<Chitietphieugiaohang> Chitietphieugiaohang { get; set; }
    }
}

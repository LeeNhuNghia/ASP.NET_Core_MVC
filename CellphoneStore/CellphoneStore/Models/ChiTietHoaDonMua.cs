using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CellphoneStore.Models
{
    public class ChiTietHoaDonMua
    {
        [Key]
        public string ma_cthd_mua { get; set; }
        [Required]
        public string ma_sp { get; set; }
        [Required]
        public float don_gia { get; set; }
        [Required]
        public int so_luong { get; set; }
        [Required]
        public string ma_hd { get; set; }
    }
}

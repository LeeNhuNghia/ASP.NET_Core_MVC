using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CellphoneStore.Models
{
    public class ChiTietHoaDonBan
    {
        [Key]
        public string ma_cthd_ban { get; set; }
        public string ma_sp { get; set; }
        public float don_gia { get; set; }
        public int so_luong { get; set; }
        public string ma_hd { get; set; }
    }
}

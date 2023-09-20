using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CellphoneStore.Models
{
    public class SanPham
    {
        [Key]
        public string ma_sp { get; set; }
        [Required]
        public string ten_sp { get; set; }
        public DateTime da_xoa { get; set; }
        public float gia_cu { get; set; }
        public float gia_moi { get; set; }
        public string hinh_anh { get; set; }
        public string hot { get; set; }
        [Required]
        public string ma_dm { get; set; }
        [Required]
        public string ma_ncc { get; set; }
        public DateTime ngay_tao { get; set; }

    }
}

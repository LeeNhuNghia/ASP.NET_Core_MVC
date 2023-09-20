using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CellphoneStore.Models
{
    public class DanhMuc
    {
        [Key]
        public string ma_dm { get; set; }
        [Required]
        public string ten_dm { get; set; }
        public DateTime da_xoa { get; set; }
        public DateTime ngay_tao { get; set; }
    }
}

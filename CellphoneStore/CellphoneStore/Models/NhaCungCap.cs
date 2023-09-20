using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CellphoneStore.Models
{
    public class NhaCungCap
    {
        [Key]
        public string ma_ncc { get; set; }
        public DateTime da_xoa { get; set; }
        [Required]
        public string ten { get; set; }
    }
}

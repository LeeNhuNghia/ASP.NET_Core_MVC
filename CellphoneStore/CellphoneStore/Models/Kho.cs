using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CellphoneStore.Models
{
    public class Kho
    {
        [Key]
        public string ma_sp { get; set; }
        [Required]
        public int so_luong { get; set; }
    }
}

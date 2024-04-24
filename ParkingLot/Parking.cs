using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    [Table("tb_parking")]
    public class Parking
    {
        public int ParkingId { get; set; }

        [MaxLength(7)]
        [Required]
        public string LicensePlate { get; set; }

        public bool Large { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Entry { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Exit { get; set; }
        public bool Paid { get; set; }
        [Required]
        public User Responsible { get; set; }
    }
}

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
        [Column(TypeName = "DateTime")]
        public DateTime Entry { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime Exit { get; set; }
        public bool Paid { get; set; }
        [Required]
        public User Responsible { get; set; }

        public Parking() { }
        public Parking(string licensePlate, bool large, DateTime entry, User responsible)
        {
            LicensePlate = licensePlate;
            Large = large;
            Entry = entry;
            Exit = Convert.ToDateTime("1753-01-01");
            Responsible = responsible;
        }
        
        public TimeSpan CalculatePastTime(DateTime possibleExit)
        {
            return possibleExit - Entry;
        }
        public override string ToString()
        {
            return $"{LicensePlate} | {Entry}. Responsible: {Responsible.FirstName} {Responsible.LastName}";
        }
    }
}

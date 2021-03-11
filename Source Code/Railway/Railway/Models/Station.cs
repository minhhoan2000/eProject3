using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Railway.Models
{
    [Table("Station")]
    public class Station
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StationID { get; set; }
        public string StationName { get; set; }
        public string TimeStart { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public Train Trains { get; set; }
        public Reservation Reservations { get; set; }
    }
}

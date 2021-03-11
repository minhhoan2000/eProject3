using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Railway.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReserId { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string TrainID { get; set; }
        [Required]
        public int StationID { get; set; }
        [Required]
        public string ticket { get; set; }
        public int Total { get; set; }
    }
}

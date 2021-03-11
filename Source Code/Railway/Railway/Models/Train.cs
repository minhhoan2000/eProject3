using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Railway.Models
{
    [Table("Train")]
    public class Train
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TrainID { get; set; }

        [Required]
        public string TrainName { get; set; }
        [Required]
        public string RouteFrom { get; set; }
        [Required]
        public string RouteTo { get; set; }
        [Required]
        public string RoutFrom { get; set; }
        [Required]
        public string TotalCom { get; set; }
        [Required]
        public int oneAC { get; set; }
        [Required]
        public int twoAC { get; set; }
        [Required]
        public int threeAC { get; set; }
        [Required]
        public int Sleeper { get; set; }
        [Required]
        public string StationID { get; set; }
        public Station Stations{get;set;}
       
    }

}

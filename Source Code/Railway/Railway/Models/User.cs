using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Railway.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string NameAccount { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Role { get; set; }
       
    }
}

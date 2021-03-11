using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections;
using RaiwaySysterm.Models;

namespace RaiwaySysterm.Models
{
    
    public class UserDetail
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        //
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(49, MinimumLength = 1,ErrorMessage ="Full name must be from 1 to 49 character.")]
        public string FullName { get; set; }
        //
        [Required(ErrorMessage = "Account name is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Account name must be from 5 to 20 character.")]
        public string NameAccount { get; set; }
        //
        [Required(ErrorMessage = "password is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "password must be from 5 to 20 character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //
        [StringLength(2, MinimumLength =1,ErrorMessage ="age must be from 1 to 2 number")]
        public int Age { get; set; }
        //
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        public bool Role { get; set; }
       
    }
}

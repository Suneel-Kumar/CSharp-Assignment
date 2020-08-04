using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Authorize.Models
{
    [Table("tbl_Register")]
    public class Register
    {
        [Key]
        public int userId { get; set; }

        
        [Required]
        [StringLength(30, ErrorMessage = "Email Should not be more than 30 Character")]
        [RegularExpression(@"^([\w\.\-]+@([\w\-]+)((\.(\w){2, 3})+)$", ErrorMessage = "Please Enter Valid Email Address ")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Length should not be greater than 20 Characters")]
        public string Password { get; set; }
    }
}
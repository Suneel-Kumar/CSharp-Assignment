using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Info
    {
        [Key]
        public int Id { get; set; }

        [Display(Name =" User Name")]
        [Required(ErrorMessage = " Bhai Naam???")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Bhai Desc???")]
        public string Description { get; set; }

        [Required(ErrorMessage = " Bhai Type???")]
        public string Type { get; set; }

        public int Status { get; set; }
    }
}
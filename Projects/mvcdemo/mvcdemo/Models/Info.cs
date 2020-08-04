using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class Info
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = " Bhai Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Bhai Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = " Status")]
        public int Status { get; set; }
        [Required(ErrorMessage = " Type")]
        public string Type { get; set; }
        

    }
}
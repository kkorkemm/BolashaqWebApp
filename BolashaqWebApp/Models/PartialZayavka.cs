using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BolashaqWebApp.Models
{
    public partial class Zayavka
    {
        [Required]
        public string CardNumber { get; set; }

        [Required]
        public int CVC { get; set; }

        [Required]
        public int Month { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
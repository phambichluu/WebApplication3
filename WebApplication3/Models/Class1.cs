using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [Table("Class1s")]
    public class Class1
    {
        [Key]
        public string CCCD { get; set; }
        public string Sdt { get; set; }

    }
}
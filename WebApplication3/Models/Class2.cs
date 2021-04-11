using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [Table("Class2s")]
    public class Class2:Class1
    {
        public string HoVaTen { get; set; }
        public string DiaChi { get; set; }
        public string TruongHoc { get; set; }
        public string GioiTinh { get; set; }

    }
}
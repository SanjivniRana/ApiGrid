using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiGrid.Models
{
    public class StudentDetail
    {
        [Key]
        public int Id { get; set; }
        public int PhoneNo { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
    }
}
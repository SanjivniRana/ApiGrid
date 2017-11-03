using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiGrid.Models
{
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public int RollNo { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }
        public StudentDetail StudentDetail { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiGrid.Models
{
    public class StudentViewModel
    {
        [Key]
        public int Id { get; set; }
        public Student student { get; set; }
        public StudentDetail studentdetail { get; set; }

    }
}
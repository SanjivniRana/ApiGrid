using ApiGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGrid.Dto
{
    public class StudentDto
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public int RollNo { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }
        public StudentDetailDto StudentDetail { get; set; }


    }
}
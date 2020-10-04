using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace CURD.Application.Shared
{
    public class Student
    {
        public string StudentId { get; set; }
        [Required]
        public string FirstName { get;set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Department { get; set; }
    }
}

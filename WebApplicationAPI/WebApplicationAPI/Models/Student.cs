using System;
using System.Collections.Generic;

namespace WebApplicationAPI.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string RollNo { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}

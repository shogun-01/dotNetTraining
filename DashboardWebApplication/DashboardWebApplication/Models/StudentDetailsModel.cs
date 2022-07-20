using System.ComponentModel.DataAnnotations;

namespace DashboardWebApplication.Models
{
    public class StudentDetailsModel
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RollNo { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
    }
}

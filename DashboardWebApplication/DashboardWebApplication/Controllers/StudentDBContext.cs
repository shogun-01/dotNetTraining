using Microsoft.EntityFrameworkCore;
namespace DashboardWebApplication.Models
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }

        public DbSet<StudentDetailsModel> Students { get; set; }
    }
}

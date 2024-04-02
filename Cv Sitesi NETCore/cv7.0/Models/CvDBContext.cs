
using Microsoft.EntityFrameworkCore;

namespace cv7._0.Models
{
    public class CvDBContext:DbContext
    {
        public CvDBContext(DbContextOptions<CvDBContext> options) : base(options) { }

        public DbSet<CV> CVs { get; set; }
    }
}

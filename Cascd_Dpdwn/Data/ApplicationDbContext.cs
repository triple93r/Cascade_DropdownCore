using Cascd_Dpdwn.Models;
using Microsoft.EntityFrameworkCore;

namespace Cascd_Dpdwn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<tbl_Territory> tbl_Territory { get; set; }
        public virtual DbSet<tbl_Country> tbl_Country { get; set; }
        public virtual DbSet<tbl_Stt> tbl_Stt { get; set; }

    }
}

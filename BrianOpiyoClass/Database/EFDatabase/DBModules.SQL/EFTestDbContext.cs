using Microsoft.EntityFrameworkCore;

namespace DBModules.SQL
{
    public class EFTestDbContext : DbContext
    {
        public EFTestDbContext(DbContextOptions opt): base(opt)
        {

        }
    }
}
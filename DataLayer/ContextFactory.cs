using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=myappdb;Username=admin;Password=admin123");
            return new DBContext(optionsBuilder.Options);
        }
    }
}

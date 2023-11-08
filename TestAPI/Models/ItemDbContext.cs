using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TestAPI.Models
{
    public class ItemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(@"Server=tcp:sweden.database.windows.net,1433;Initial Catalog=Table_1;Database=test_1;User ID=test_db_gæs;Password=12ahkk##;Trusted_Connection=False;Encrypt=True");
            options.UseSqlServer(@"Server = tcp:sweden.database.windows.net, 1433; Initial Catalog = test_1; Persist Security Info = False; User ID = test_db_gæs; Password = 12ahkk##; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");

        }

        public ItemDbContext()
        {
        }

        public DbSet<Test> Table_1 { get; set; }
    }
}

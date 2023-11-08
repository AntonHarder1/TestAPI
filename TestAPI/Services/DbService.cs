using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Services
{
    public class DbService
    {
        public async Task<List<Test>> GetTests()
        {
            using (var context = new ItemDbContext())
            {
                return await context.Table_1.ToListAsync();
            }
        }

        public async Task SaveTests(List<Test> tests)
        {
            using (var context = new ItemDbContext())
            {
                foreach (Test test in tests)
                {
                    context.Table_1.Add(test);
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
        }

        public async Task AddTest(Test test)
        {
            using (var context = new ItemDbContext())
            {
                context.Add(test);
                context.SaveChanges();
            }
        }
    }
}

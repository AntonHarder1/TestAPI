using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Services;

namespace TestAPI.Manager
{
    public class TestManagerDb : ITestManager
    {
        private ItemDbContext _context;

        public TestManagerDb(ItemDbContext context)
        {
            _context = context;
        }

        public DbService DbService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Test> TestList { get; set; }

        //public List<Test> GetAllTests()
        //{
        //    return _context.GetTest
        //}

       
        public Test Add(Test newTest)
        {
            _context.Add(newTest);
            _context.SaveChanges();
            return newTest;
        }

        public  List<Test> GetAll()
        {
            using (var context = _context)
            {
                Console.WriteLine("Where it dies");
                return context.Table_1.ToList();
            }
        }
    }
}

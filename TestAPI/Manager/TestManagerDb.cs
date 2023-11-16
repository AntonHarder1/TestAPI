using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Services;

namespace TestAPI.Manager
{
    public class TestManagerDb : ITestManagerDb
    {
        private ItemDbContext _context;
        public DateTime dt { get; set; }

        public TestManagerDb(ItemDbContext context)
        {
            _context = context;
        }

        public DbService DbService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Test> TestList { get; set; }
   
        public Test Add(Test newTest)
        {
            _context.Add(newTest);
            _context.SaveChanges();

            return newTest;

        }

        /// <summary> Test
        /// Test
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Test GetByID(int id)
        {
            var newTest = _context.Cardsale.Find(id);
            return newTest;
        }

        public DateTime Get()
        {
            var newTest = _context.Cardsale.OrderBy(e => e.ServerTimestamp).LastOrDefault();
            if (newTest != null)
                return newTest.TerminalTimestamp;
            return DateTime.MinValue;
            //return new DateTime dt = (1,1,1,0,0,0,0);
        }
        public List<Test> GetAll()
        {
            try
            {


                using (var context = _context)
                {
                    return context.Cardsale.ToList();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}

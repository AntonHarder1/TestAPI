using TestAPI.Models;
using TestAPI.Services;
using TestAPI.MockTests;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TestAPI.Manager
{
    public class TestManager : ITestManager
    {
        public DbService DbService { get; set; }
        public List<Test> TestList;

        public TestManager(DbService dbService)
        {
            DbService = dbService;
            //TestList = MockTest.GetAllTests();
            foreach (Test test in TestList)
            {
                dbService.AddTest(test);
            }
            //TestList = dbService.GetTests().Result;
        }
     
        public List<Test> GetAll()
        {
            //TestList = MockTest.GetAllTests();
            //TestList = DbService.GetTests().Result.ToList();

            return TestList;
        }

        public Test Add(Test newTest)
        {
            TestList.Add(newTest);
            DbService.AddTest(newTest);
            return newTest;
        }

    }
}

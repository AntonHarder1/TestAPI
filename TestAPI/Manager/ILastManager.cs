using TestAPI.Models;
using TestAPI.Services;

namespace TestAPI.Manager
{
    public interface ITestManager
    {
        DbService DbService { get; set; }

        Test Add(Test newTest);
        List<Test> GetAll();
        //List<Test> GetAllTests();
    }
}
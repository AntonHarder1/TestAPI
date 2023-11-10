using TestAPI.Models;
using TestAPI.Services;

namespace TestAPI.Manager
{
    public interface ITestManagerDb
    {
        DbService DbService { get; set; }

        Test Add(Test newTest);
        List<Test> GetAll();
        DateTime Get();
    }
}
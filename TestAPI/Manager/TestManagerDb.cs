﻿using Microsoft.EntityFrameworkCore;
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

        public DateTime Get()
        {
            var newTest = _context.Table_1.OrderBy(e => e.Dato).LastOrDefault();
            if (newTest != null)
                return newTest.Dato;
            return DateTime.MinValue;
            //return new DateTime dt = (1,1,1,0,0,0,0);
        }
        public List<Test> GetAll()
        {
            using (var context = _context)
            {
                return context.Table_1.ToList();
            }
        }
    }
}

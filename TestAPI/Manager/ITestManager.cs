﻿using TestAPI.Models;
using TestAPI.Services;

namespace TestAPI.Manager
{
    public interface ILastManager
    {
        DbService DbService { get; set; }

        Last Add(Last newTest);
        List<Last> GetAll();
        //List<Test> GetAllTests();
    }
}
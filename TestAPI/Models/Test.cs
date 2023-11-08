using System.ComponentModel.DataAnnotations;
using System;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    public class Test 
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public double Number { get; set; }
        [Required]
        public DateTime Dato { get; set; }

        public Test(int id, string text, int number, DateTime dato)
        {
            Id = id;
            Text = text;
            Number = number;
            Dato = dato;
        }

        public Test()
        {

        }
    }
}

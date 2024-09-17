using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Farm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<animalType> animalTypes {get; set;}
    }
}
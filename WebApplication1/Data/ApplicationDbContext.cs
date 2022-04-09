using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InAndOut.Models;

namespace InAndOut.Data
{
    public class ApplicationDbContext :DbContext
    {
                public ApplicationDbContext(DbContextOption<ApplicationDbContext> options) : base()
        {
        }

        public DbSet<Item>  Items { get; set; }
        
    }
}

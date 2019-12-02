using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebWeek4.Models;

namespace WebWeek4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebWeek4.Models.Song> Songs { get; set; }
        public DbSet<WebWeek4.Models.Customer> Customer { get; set; }
 
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DT102GProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DT102GProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // tables
        public DbSet<Course> Course { get; set; }
        public DbSet<FAQ> FAQ { get; set; }
    }
}

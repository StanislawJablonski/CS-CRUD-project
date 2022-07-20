using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUD_Project.Models;

namespace CRUD_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUD_Project.Models.Address> Address { get; set; }
        public DbSet<CRUD_Project.Models.Company> Company { get; set; }
        public DbSet<CRUD_Project.Models.Employee> Employee { get; set; }
        public DbSet<CRUD_Project.Models.Car> Car { get; set; }


    }
}
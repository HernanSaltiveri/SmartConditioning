using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Admin.Models;

namespace Admin.Data
{
    public class SmartConditioningDbContext : IdentityDbContext
    {
        public SmartConditioningDbContext(DbContextOptions<SmartConditioningDbContext> options)
            : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
    }
}

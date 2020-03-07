using System;
using System.Collections.Generic;
using System.Text;
using InversionesII.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InversionesII.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Inversion> Inversions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

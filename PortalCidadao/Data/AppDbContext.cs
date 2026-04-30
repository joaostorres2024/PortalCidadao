using Microsoft.EntityFrameworkCore;
using PortalCidadao.Models;
using System.Collections.Generic;

namespace PortalCidadao.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
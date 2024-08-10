using FatInterface.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FatInterface.Infra
{
    public class FatInterfaceContext : DbContext
    {
        public FatInterfaceContext(DbContextOptions<FatInterfaceContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}

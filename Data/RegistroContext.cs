using busco.Models;
using Microsoft.EntityFrameworkCore;

namespace busco.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
}
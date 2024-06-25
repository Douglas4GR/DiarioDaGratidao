using Microsoft.EntityFrameworkCore;
using DiarioDaGratidao.Models;

namespace DiarioDaGratidao.Data
{
    public class BlocoDeNotasContext : DbContext
    {
        public BlocoDeNotasContext(DbContextOptions<BlocoDeNotasContext> options) : base(options) { }

        public DbSet<Nota> Notas { get; set; }
    }
}

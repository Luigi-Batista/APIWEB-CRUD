using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {

        }

        // Mapeamento das entidade da base de dados
        public DbSet<Produto> Produto {get ; set;}
        public DbSet<Cliente> Cliente { get; set; }
    }       
}

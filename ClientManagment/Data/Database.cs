using ClientManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagment.Data
{
    public class ClientDbContext : DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clientes { get; set; }
    }
}

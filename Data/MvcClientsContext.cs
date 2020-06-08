using Microsoft.EntityFrameworkCore;

namespace MvcClients.Data
{
    public class MvcClientsContext : DbContext
    {
        public MvcClientsContext (DbContextOptions<MvcClientsContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Client> Client { get; set; }
    }
}

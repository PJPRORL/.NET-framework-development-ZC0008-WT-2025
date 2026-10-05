
using Microsoft.EntityFrameworkCore;

namespace TandartsPraktijkAPI.Data
{
    public class APIDbContext : IdentityDbContext<Gebruiker>
    {
        public APIDbContext(DbContextOptions<APIDbContext>
            options) : base(options) { }

    }
}

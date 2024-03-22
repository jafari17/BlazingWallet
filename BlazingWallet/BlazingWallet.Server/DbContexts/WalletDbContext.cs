using Microsoft.EntityFrameworkCore;

namespace BlazingWallet.Server.DbContexts
{
    public class WalletDbContext : DbContext
    {
        public WalletDbContext
    (DbContextOptions<WalletDbContext> options)
    : base(options)
        {

        }

        //ADD Entities





    }
}

using ChatAppServer.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAppServer.WebAPI.Context
{
    public sealed class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
    }
}

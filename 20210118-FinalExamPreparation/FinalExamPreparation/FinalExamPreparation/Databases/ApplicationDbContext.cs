
using FinalExamPreparation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalExamPreparation.Databases
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Info> Infos { set; get; }
        public DbSet<UserAccount> UsersAccounts { set; get; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

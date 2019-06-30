using ByYsmn.Core.Companies;
using ByYsmn.Core.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ByYsmn.EntityFramework.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Sqlite geçiş yaparken eklenecek. 
        // Şimdi ApplicationDbFactoryde DatabaseConnection yazan yere SQLiteConnection yazılacak. 
        // Startup da değiştirilecek. Sonra Migration silinecek.

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        // DbSetler buraya eklenecek. (Veritabanı modelleri)

        public DbSet<Company> Companies { get; set; }

    }
}

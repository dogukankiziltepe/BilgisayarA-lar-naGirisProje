using System;
using BilgisayarAglarinaGirisProje.Entity;
using Microsoft.EntityFrameworkCore;

namespace BilgisayarAglarinaGirisProje.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:projectbilgisayaraglari.database.windows.net,1433;Database=ProjectDB;User Id=yonetici;Password = 123456789Aa!");
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Repository : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Parking> Parking { get; set; }

        public Repository() : base()
        {
            if(Database.EnsureCreated())
            {
                User u = new User("Administrator", "adm@mail.com", Convert.ToDateTime("2000-00-00"), "adm123", true);
                Repository context = new Repository();
                context.Users.Add(u);
                context.SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=parkinglot;Trusted_Connection=True;Encrypt=false;");
        }
    }
}

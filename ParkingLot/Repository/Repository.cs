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
                User u = new User("Administrator", "Wang", "adm@mail.com", Convert.ToDateTime("2000/01/01"), "adm12345", true, true);
                UserRepository.Save(u);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=parkinglot;Trusted_Connection=True;Encrypt=false;");
        }
    }
}

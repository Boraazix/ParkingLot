using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class UserRepository
    {
        public static void Save(User user)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (user.UserId == 0)
                    {
                        dbContext.Users.Add(user);
                    }
                    else
                    {
                        dbContext.Entry(user).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}

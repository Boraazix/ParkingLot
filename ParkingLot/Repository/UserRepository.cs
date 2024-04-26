using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
                        User someone = dbContext.Users.Where(u => u.Email == user.Email).FirstOrDefault<User>();
                        if (someone == null)
                        {
                            dbContext.Users.Add(user);
                        }
                        else
                        {
                            throw new DuplicateNameException("This Email is already registered!");
                        }
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
        public static void Remove(User user)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Users.Attach(user);
                    dbContext.Users.Remove(user);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool ValidateUser(string email, string password)
        {
            try
            {
                User user;
                using (Repository dbContext = new Repository())
                {
                    user = dbContext.Users.Where(u => u.Email == email).FirstOrDefault<User>();
                }
                if (user != null)
                {
                    if (!user.Active)
                    {
                        throw new AccessViolationException("This User is inactive!");
                    }

                    password = User.ComputeSHA256(password, User.SALT);

                    if (password == user.Password)
                    {
                        FormMain.UserLogged = user;
                        return true;
                    }
                    else
                    {
                        throw new UnauthorizedAccessException("This password is incorrect, please try again");
                    }
                }
                else
                {
                    throw new InvalidDataException("This email is incorrect, please try again");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<User> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users.OrderBy(u => u.FirstName).ThenBy(u => u.LastName).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

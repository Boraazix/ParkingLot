using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public class ParkingRepository
    {
        public static void Save(Parking parking)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(parking.Responsible).State = EntityState.Unchanged;
                    if (parking.ParkingId == 0)
                    {
                        Parking someone = dbContext.Parking.Where(p => p.LicensePlate == parking.LicensePlate && !p.Paid).FirstOrDefault<Parking>();
                        if (someone == null)
                        {
                            dbContext.Parking.Add(parking);
                        }
                        else
                        {
                            throw new DuplicateNameException("This car already has a active parking!\nRelease or delete it first.");
                        }
                    }
                    else
                    {
                        dbContext.Entry(parking).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Remove(Parking parking)
        {
            try
            {
                using (Repository dbContext = new Repository()) 
                {
                    dbContext.Parking.Attach(parking);
                    dbContext.Parking.Remove(parking);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Parking> FindAllWResponsible()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Parking.Include("Responsible").OrderByDescending(p => p.Entry).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Parking> FindAllOpenWResponsible()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Parking.Include("Responsible").Where(p => !p.Paid).OrderByDescending(p => p.Entry).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

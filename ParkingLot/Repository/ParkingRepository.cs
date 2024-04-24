using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    if (parking.ParkingId == 0)
                    {
                        dbContext.Parking.Add(parking);
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
    }
}

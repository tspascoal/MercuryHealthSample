#region Namespaces
using MercuryHealth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
#endregion

namespace MercuryHealth.Web.Models
{

    public class FoodLogEntrySqlRepository : IFoodLogEntryRepository
    {
        
        ApplicationDbContext db = new ApplicationDbContext();

        public FoodLogEntry Get(int? id)
        {
            FoodLogEntry entry = db.FoodLogEntries.Find(id);

            return entry;
        }

        public IQueryable<FoodLogEntry> GetAll()
        {
            return db.FoodLogEntries;
        }

        public void Create(FoodLogEntry newFoodLogEntry)
        {
            try
            {
                var duplicateFoodLogEntry = db.FoodLogEntries.FirstOrDefault(
                    entry => 
                    (entry.Description == newFoodLogEntry.Description) && 
                    (entry.MealTime == newFoodLogEntry.MealTime));

                if (duplicateFoodLogEntry != null)
                {

                    Trace.TraceInformation("Duplicate Entry " + duplicateFoodLogEntry.Description);

                    throw new ArgumentException("You cannot add two identical food log entries for the same day. Change the quantity.");
                }

                db.FoodLogEntries.Add(newFoodLogEntry);
                db.SaveChanges();

            }
            catch (Exception e)
            {

                LogException(e);

            }
        }

        public void Update(FoodLogEntry updatedFoodLogEntry)
        {
            db.Entry(updatedFoodLogEntry).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                FoodLogEntry foodLogEntry = db.FoodLogEntries.Find(id);
                db.FoodLogEntries.Remove(foodLogEntry);
                db.SaveChanges();
            }
            catch(Exception)
            {
                // TODO: Catch any DB concurrency exceptions
            }
        }
        
        private void LogException(Exception e)
        {
            // Log exception to rolling log file

            // TODO: Add log logic here to capture duplicate entries
       }

    }

}
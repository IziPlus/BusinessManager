using BusinessManager.DataLeyer;
using BusinessManager.DomainClasses;
using BusinessManager.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Services.Services
{
    public class FrooshandeRipository : IFrooshande
    {
        private BMDBContext _db;
        public FrooshandeRipository(BMDBContext db)
        {
            _db = db;
        }
        public async void DeleteFrooshandeAsync(int frooshandeId)
        {
            var Frooshande = await GetFrooshandeByIdAsync(frooshandeId);
            DeleteFrooshande(Frooshande);
        }

        public void DeleteFrooshande(Frooshande frooshande)
        {
            _db.Entry(frooshande).State = EntityState.Deleted;
        }

        public Task<List<Frooshande>> GetAllFrooshandesAsync()
        {
            return _db.Frooshandes.ToListAsync();
        }

        public Task<Frooshande> GetFrooshandeByIdAsync(int frooshandeId)
        {
            return _db.Frooshandes.FindAsync(frooshandeId);
        }

        public void InsertFrooshande(Frooshande frooshande)
        {
            _db.Entry(frooshande).State = EntityState.Added;
        }

        public async void saveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void updateFrooshande(Frooshande frooshande)
        {
            _db.Entry(frooshande).State = EntityState.Modified;

        }
    }
}

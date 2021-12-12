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
    public class HesabFrooshandeRipository : IHesabFrooshande
    {
        private BMDBContext _db;
        public HesabFrooshandeRipository(BMDBContext db)
        {
            _db = db;
        }
        public async void DeleteHesabFrooshandeAsync(int hesabFrooshandeId)
        {
            var HesabFrooshande =await GetHesabFrooshandeByIdAsync(hesabFrooshandeId);
            DeleteHesabFrooshande(HesabFrooshande);
        }

        public void DeleteHesabFrooshande(HesabFrooshande hesabFrooshande)
        {
            _db.Entry(hesabFrooshande).State = EntityState.Deleted;
        }

        public async Task<IEnumerable<HesabFrooshande>> GetHesabFrooshandeByFrooshandeIdAsync(int FrooshandeId)
        {
            throw new NotImplementedException();
        }

        public async Task<HesabFrooshande> GetHesabFrooshandeByIdAsync(int hesabFrooshandeId)
        {
            return await _db.HesabFrooshandes.FindAsync(hesabFrooshandeId);
        }

        public void InsertHesabFrooshande(HesabFrooshande hesabFrooshande)
        {
            _db.Entry(hesabFrooshande).State = EntityState.Added;
        }

        public async void saveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void updateHesabFrooshande(HesabFrooshande hesabFrooshande)
        {
            _db.Entry(hesabFrooshande).State = EntityState.Modified;
        }
    }
}

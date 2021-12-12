using BusinessManager.DomainClasses;
using BusinessManager.DataLeyer;
using BusinessManager.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BusinessManager.Services.Services
{
    public class HesabMoshtariRepository : IHesabMoshtari
    {
        private BMDBContext _db;
        public HesabMoshtariRepository(BMDBContext db)
        {
            _db = db;
        }
        public async void DeleteHesabMoshtariAsync(int hesabMoshtariId)
        {
            var HesabMoshtari = await GetHesabMoshtariByIdAsync(hesabMoshtariId);
            DeleteHesabMoshtari(HesabMoshtari);
        }

        public void DeleteHesabMoshtari(HesabMoshtari hesabMoshtari)
        {
            _db.Entry(hesabMoshtari).State = EntityState.Deleted;
        }

        public async Task<HesabMoshtari> GetHesabMoshtariByIdAsync(int hesabMoshtariId)
        {
            return await _db.hesabMoshtaris.FindAsync(hesabMoshtariId);
        }

        public async Task<IEnumerable<HesabMoshtari>>  GetHesabMoshtariByMoshtariIdAsync(int moshtariId)
        {
            return await _db.hesabMoshtaris.Where(c => c.MoshtariId == moshtariId)
                .OrderByDescending(c=>c.Id).ToListAsync();
        }

        public void InsertHesabMoshtari(HesabMoshtari hesabMoshtari)
        {
            _db.Entry(hesabMoshtari).State = EntityState.Added;
        }

        public void Save()
        {
            _db.SaveChangesAsync();
        }

        public void updateHesabMoshtari(HesabMoshtari hesabMoshtari)
        {
            _db.Entry(hesabMoshtari).State = EntityState.Modified;
        }
    }
}

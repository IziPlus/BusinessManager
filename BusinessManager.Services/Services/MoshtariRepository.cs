using BusinessManager.DomainClasses;
using BusinessManager.DataLeyer;
using BusinessManager.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BusinessManager.Services.Services
{
    public class MoshtariRepository : IMoshtari
    {

        private BMDBContext _db;
        public MoshtariRepository(BMDBContext db)
        {
            _db = db;
        }
        public async void DeleteMoshtariAsync(int moshtariId)
        {
            var Moshtari =await GetMoshtariByIdAsync(moshtariId);
            DeleteMoshtari(Moshtari);
        }

        public void DeleteMoshtari(Moshtari moshtari)
        {
            _db.Entry(moshtari).State = EntityState.Deleted;
        }

        public Task<List<Moshtari>> GetAllMoshtarisAsync()
        {
            return _db.Moshtaris.OrderBy(c=>c.Id).Take(30).ToListAsync();
        }

        public Task<List<Moshtari>> GetAllMoshtarisAsync(string name,string family,int radif)
        {
            var query = _db.Moshtaris.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(c => c.Nam.Contains(name));
            }
            if (!string.IsNullOrEmpty(family))
            {
                query = query.Where(c => c.Family.Contains(family));
            }
            if (radif>0)
            {
                query = query.Where(c => c.Radif==radif);
            }

            return query.OrderBy(c => c.Id).Take(30).ToListAsync();
        }

        public Task<Moshtari> GetMoshtariByIdAsync(int moshtariId)
        {
            return _db.Moshtaris.FindAsync(moshtariId);
        }

        public void InsertMoshtari(Moshtari moshtari)
        {
            _db.Moshtaris.Add(moshtari);
        }

        public void save()
        {
           _db.SaveChanges();
        }

        public void updateMoshtari(Moshtari moshtari)
        {
            _db.Entry(moshtari).State = EntityState.Modified;
        }
    }
}

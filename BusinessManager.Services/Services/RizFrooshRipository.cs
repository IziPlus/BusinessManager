using BusinessManager.DomainClasses;
using BusinessManager.DataLeyer;
using BusinessManager.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessManager.Services.Services
{
    public class RizFrooshRipository : IRizFroosh
    {
        private BMDBContext _db;
        public RizFrooshRipository(BMDBContext db)
        {
            _db = db;
        }
        public async void DeleteRizFrooshAsync(int RizFrooshId)
        {
            var RizFroosh = await GetRizFrooshByIdAsync(RizFrooshId);
            DeleteRizFroosh(RizFroosh);
        }

        public void DeleteRizFroosh(RizFroosh RizFroosh)
        {
            _db.Entry(RizFroosh).State = EntityState.Deleted;
        }

        public Task<IEnumerable<RizFroosh>>  GetAllRizFrooshsByHesabMoshtariIdAsync(int hesabMoshtariId)
        {
            throw new NotImplementedException();
        }

        public Task<RizFroosh> GetRizFrooshByIdAsync(int RizFrooshId)
        {
            return _db.RizFrooshs.FindAsync(RizFrooshId);
        }

        public void InsertRizFroosh(RizFroosh RizFroosh)
        {
            _db.Entry(RizFroosh).State = EntityState.Added;
        }

        public void saveAsync()
        {
            _db.SaveChangesAsync();
        }

        public void updateRizFroosh(RizFroosh RizFroosh)
        {
            _db.Entry(RizFroosh).State = EntityState.Modified;
        }
    }
}

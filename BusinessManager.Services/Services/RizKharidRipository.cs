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
    public class RizKharidRipository : IRizKharid
    {
        private BMDBContext _db;
        public RizKharidRipository(BMDBContext db)
        {
            _db = db;
        }

        public async void DeleteRizKharid(int RizKharidId)
        {
            var RizKharid = await GetRizKharidByIdAsync(RizKharidId);
            DeleteRizKharid(RizKharid);

        }

        public void DeleteRizKharid(RizKharid RizKharid)
        {
            _db.Entry(RizKharid).State = EntityState.Deleted;
        }

        public Task<IEnumerable<RizKharid>> GetAllRizKharidsByHesabFrooshandeIdAsync(int hesabFrooshandeId)
        {
            throw new NotImplementedException();
        }

        public Task<RizKharid> GetRizKharidByIdAsync(int RizKharidId)
        {
            return _db.RizKharids.FindAsync(RizKharidId);
        }

        public void InsertRizKharid(RizKharid RizKharid)
        {
            _db.Entry(RizKharid).State = EntityState.Added;

        }

        public void saveAsync()
        {
            _db.SaveChangesAsync();
        }

        public void updateRizKharid(RizKharid RizKharid)
        {
            _db.Entry(RizKharid).State = EntityState.Modified;
        }
    }
}

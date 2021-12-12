using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.DomainClasses;

namespace BusinessManager.Services.Repositories
{
    public interface IRizKharid
    {
        Task<IEnumerable<RizKharid>> GetAllRizKharidsByHesabFrooshandeIdAsync(int hesabFrooshandeId);

        Task<RizKharid> GetRizKharidByIdAsync(int RizKharidId);

        void InsertRizKharid(RizKharid RizKharid);

        void updateRizKharid(RizKharid RizKharid);

        void DeleteRizKharid(int RizKharidId);

        void DeleteRizKharid(RizKharid RizKharid);

        void saveAsync();
    }
}

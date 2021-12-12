using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.DomainClasses;

namespace BusinessManager.Services.Repositories
{
    public interface IRizFroosh
    {
        Task<IEnumerable<RizFroosh>> GetAllRizFrooshsByHesabMoshtariIdAsync(int hesabMoshtariId);

        Task<RizFroosh> GetRizFrooshByIdAsync(int RizFrooshId);

        void InsertRizFroosh(RizFroosh RizFroosh);

        void updateRizFroosh(RizFroosh RizFroosh);

        void DeleteRizFrooshAsync(int RizFrooshId);

        void DeleteRizFroosh(RizFroosh RizFroosh);

        void saveAsync();
    }
}

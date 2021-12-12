using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.DomainClasses;

namespace BusinessManager.Services.Repositories
{
    public interface IHesabFrooshande
    {
        Task<HesabFrooshande> GetHesabFrooshandeByIdAsync(int hesabFrooshandeId);

        Task<IEnumerable<HesabFrooshande>> GetHesabFrooshandeByFrooshandeIdAsync(int FrooshandeId);

        void InsertHesabFrooshande(HesabFrooshande hesabFrooshande);

        void updateHesabFrooshande(HesabFrooshande hesabFrooshande);

        void DeleteHesabFrooshandeAsync(int hesabFrooshandeId);

        void DeleteHesabFrooshande(HesabFrooshande hesabFrooshande);

        void saveAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.DomainClasses;

namespace BusinessManager.Services.Repositories
{
    public interface IHesabMoshtari
    {
        Task<IEnumerable<HesabMoshtari>> GetHesabMoshtariByMoshtariIdAsync(int moshtariId);

        Task<HesabMoshtari> GetHesabMoshtariByIdAsync(int hesabMoshtariId);

        void InsertHesabMoshtari(HesabMoshtari hesabMoshtari);

        void updateHesabMoshtari(HesabMoshtari hesabMoshtari);

        void DeleteHesabMoshtariAsync(int hesabMoshtariId);

        void DeleteHesabMoshtari(HesabMoshtari hesabMoshtari);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.DomainClasses;

namespace BusinessManager.Services.Repositories
{
    public interface IMoshtari
    {
        Task<List<Moshtari>> GetAllMoshtarisAsync();
        Task<List<Moshtari>> GetAllMoshtarisAsync(string name, string family, int radif);

        Task<Moshtari> GetMoshtariByIdAsync(int moshtariId);

        void InsertMoshtari(Moshtari moshtari);

        void updateMoshtari(Moshtari moshtari);

        void DeleteMoshtariAsync(int moshtariId);

        void DeleteMoshtari(Moshtari moshtari);

        void save();
    }
}

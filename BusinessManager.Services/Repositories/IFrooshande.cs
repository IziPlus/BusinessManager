using BusinessManager.DomainClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Services.Repositories
{
    public interface IFrooshande
    {
        Task<List<Frooshande>> GetAllFrooshandesAsync();

        Task<Frooshande> GetFrooshandeByIdAsync(int frooshandeId);

        void InsertFrooshande(Frooshande frooshande);

        void updateFrooshande(Frooshande frooshande);

        void DeleteFrooshandeAsync(int frooshandeId);

        void DeleteFrooshande(Frooshande frooshande);

        void saveAsync();
    }
}

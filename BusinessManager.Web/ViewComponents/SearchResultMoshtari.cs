using BusinessManager.Services.Repositories;
using BusinessManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Web.ViewComponents
{
    public class SearchResultMoshtari:ViewComponent
    {
        private readonly IMoshtari _MoshtariRepository;

        public SearchResultMoshtari(IMoshtari MoshtariService)
        {
            _MoshtariRepository = MoshtariService;
        }

        public async Task<IViewComponentResult> InvokeAsync(AddMoshtariViewModel ViewModel)
        {
            var model = await _MoshtariRepository.GetAllMoshtarisAsync(ViewModel.Nam, ViewModel.Family, ViewModel.Radif);

            return await Task.FromResult((IViewComponentResult) View("SearchResultMoshtari", model));
        }
    }
}

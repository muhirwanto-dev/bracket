using System.Net.Http;
using System.Net.Http.Json;
using Blazing.Mvvm.ComponentModel;
using Bracket.Contract.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using MudBlazor;

namespace Bracket.Wasm.ViewModel
{
    public partial class HomeViewModel : ViewModelBase
    {
        private readonly HttpClient _httpClient;
        private readonly IDialogService _dialogService;

        public HomeViewModel(HttpClient httpClient, IDialogService dialogService)
        {
            _httpClient = httpClient;
            _dialogService = dialogService;
        }

        public override async Task Loaded()
        {
            try
            {
                var profile = await _httpClient.GetFromJsonAsync<ProfileEntity>("data/profile.json");
            }
            catch (Exception ex)
            {
                await _dialogService.ShowMessageBox("Error", ex.ToString());
            }
        }
    }
}

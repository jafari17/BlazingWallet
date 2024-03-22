using BlazingWallet.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace BlazingWallet.Pages
{
    public partial class TickerPage
    {
        //[Inject] public HttpClient _Http { get; set; }

        public DeribitTickerDto[]? listNewsCard;

        public string name;

        async Task OnSubmit()
        {
            listNewsCard = await _Http.GetFromJsonAsync<DeribitTickerDto[]>($"https://localhost:7111/PublicApiDeribit/{name}");

            var ss = listNewsCard;
        }

    }
}
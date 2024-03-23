using BlazingWallet.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazingWallet.Server.Controllers
{
    public class PrivateWalletDeribitController : Controller
    {
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<DeribitTickerDto>>> GetTicker()
        {

            List<DeribitTickerDto> deribitTickerList = new List<DeribitTickerDto>();

            HttpClient _http = new HttpClient();

            var requestUri2 = $"";
            var response2 = await _http.GetStringAsync(requestUri2);


            dynamic data = JsonConvert.DeserializeObject(response2);


            DeribitTickerDto dt = new DeribitTickerDto();

            dt.Delta = data.result.greeks.delta;
            dt.InstrumentName = data.result.instrument_name;
            dt.MarkPrice = data.result.mark_price;

            deribitTickerList.Add(dt);

            return deribitTickerList;

        }
    }
}

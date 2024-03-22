using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using BlazingWallet.Shared.Models;


namespace BlazingWallet.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicApiDeribit
    {
        //private readonly HttpClient _http;

        //public PublicApiDeribit(HttpClient Http)
        //{
        //    _http = Http;
        //}


        [HttpGet("{name}")]
        public async Task<ActionResult<IEnumerable<DeribitTickerDto>>> GetTicker(string name)
        {

            List<DeribitTickerDto> deribitTickerList = new List<DeribitTickerDto>();

            HttpClient _http = new HttpClient();

            var requestUri2 = $"https://www.deribit.com/api/v2/public/ticker?instrument_name={name}";
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

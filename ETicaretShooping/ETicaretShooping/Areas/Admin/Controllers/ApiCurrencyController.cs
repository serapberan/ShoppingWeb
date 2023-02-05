using ETicaretShooping.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace ETicaretShooping.Areas.Admin.Controllers   //Kur bilgileri
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiCurrencyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // List<CurrencyApiViewModel> currencyApiViewModels = new List<CurrencyApiViewModel>();
            //...............................................................
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=tr&currency=AED"),
                Headers =
            {
                { "X-RapidAPI-Key", "5cc393ee48mshf3e184142efe1acp14b229jsn397efc0cd121" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
            };
            using (var response = await client.SendAsync(request))     //Deserilaze --> Listeleme veri getirme --> Json - Model 
            {                                                          //Serilaze --> ekleme silme --> Model json 
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //currencyApiViewModels = JsonConvert.DeserializeObject<List<CurrencyApiViewModel>>(body);  --> Böyle değil Çünkü veriler direk Json altında değil 
                var currencyApiViewModels = JsonConvert.DeserializeObject<CurrencyApiViewModel>(body);
                return View(currencyApiViewModels.exchange_rates);
            }

        }

    //    [HttpGet]
    //    public async Task<IActionResult> GetFilterCurrency()
    //    {
    //        return View();
    //    }

    //        [HttpPost]
    //    public async Task<IActionResult> GetFilterCurrency(string x)
    //    {
    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency={x}"),
    //            Headers =
    //{
    //    { "X-RapidAPI-Key", "5cc393ee48mshf3e184142efe1acp14b229jsn397efc0cd121" },
    //    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //            return View(body);
    //        }
    //    }
    }
}

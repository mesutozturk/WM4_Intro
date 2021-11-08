using System;
using System.Collections.Generic;
using System.Net;
using MyCoin.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MyCoin.Services
{
    public class SymbolTickerService : IBinanceReq<BinanceReq24HTicker>
    {
        public string BaseUrl { get; } = "https://api.binance.com/api/v3/ticker/24hr";
        public BinanceReq24HTicker Result(string param)
        {
            HttpClient client = new HttpClient();
            //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, BaseUrl);
            //https://stackoverflow.com/questions/56823997/add-parameters-to-httpclient
            try
            {
                var query = $"{BaseUrl}?symbol={param}";

                HttpResponseMessage resp = client.GetAsync(query).Result;
                if (resp.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"İstak başarısız: {resp.StatusCode}");

                BinanceReq24HTicker resulTicker =
                    JsonConvert.DeserializeObject<BinanceReq24HTicker>(resp.Content.ReadAsStringAsync().Result);

                return resulTicker;
            }
            catch
            {
                throw;
            }
        }
    }
}

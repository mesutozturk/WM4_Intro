using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MyCoin.Models;
using Newtonsoft.Json;

namespace MyCoin.Services
{
    public class ExchangeInfoService : IBinanceReq<BinanceReqExchangeBody>
    {
        public string BaseUrl { get; } = "https://api.binance.com/api/v3/exchangeInfo";
        public BinanceReqExchangeBody Result(string param = null)
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage result= client.GetAsync(new Uri(BaseUrl)).Result;
                if (result.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"İstek başarısız: {result.StatusCode}");

                BinanceReqExchangeBody body =
                    JsonConvert.DeserializeObject<BinanceReqExchangeBody>(result.Content.ReadAsStringAsync().Result);
                return body;
            }
            catch
            {
                throw;
            }
        }
    }
}
using System.Collections.Generic;

namespace MyCoin.Models
{
    public class BinanceReqExchangeBody
    {
        public string Timezone { get; set; }
        public long ServerTime { get; set; }
        public Ratelimit[] RateLimits { get; set; }
        public object[] ExchangeFilters { get; set; }
        public List<Symbol> Symbols { get; set; } = new List<Symbol>();
    }
}

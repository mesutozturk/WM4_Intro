namespace MyCoin.Models
{
    public class BinanceReq24HTicker
    {
        public string Symbol { get; set; }
        public double PriceChange { get; set; }
        public double PriceChangePercent { get; set; }
        public double WeightedAvgPrice { get; set; }
        public double PrevClosePrice { get; set; }
        public double LastPrice { get; set; }
        public double LastQty { get; set; }
        public double BidPrice { get; set; }
        public double BidQty { get; set; }
        public double AskPrice { get; set; }
        public double AskQty { get; set; }
        public double OpenPrice { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public double Volume { get; set; }
        public double QuoteVolume { get; set; }
        public long OpenTime { get; set; }
        public long CloseTime { get; set; }
        public int FirstId { get; set; }
        public int LastId { get; set; }
        public int Count { get; set; }
    }
}

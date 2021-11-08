namespace MyCoin.Models
{
    public class Filter
    {
        public string filterType { get; set; }
        public string minPrice { get; set; }
        public string maxPrice { get; set; }
        public string tickSize { get; set; }
        public string multiplierUp { get; set; }
        public string multiplierDown { get; set; }
        public int avgPriceMins { get; set; }
        public string minQty { get; set; }
        public string maxQty { get; set; }
        public string stepSize { get; set; }
        public string minNotional { get; set; }
        public bool applyToMarket { get; set; }
        public int limit { get; set; }
        public int maxNumOrders { get; set; }
        public int maxNumAlgoOrders { get; set; }
        public string maxPosition { get; set; }
    }
}

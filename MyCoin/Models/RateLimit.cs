namespace MyCoin.Models
{
    public class Ratelimit
    {
        public string RateLimitType { get; set; }
        public string Interval { get; set; }
        public int IntervalNum { get; set; }
        public int Limit { get; set; }
    }
}

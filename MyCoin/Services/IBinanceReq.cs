namespace MyCoin.Services
{
    public interface IBinanceReq<T> where T : class
    {
        string BaseUrl { get; }
        T Result(string param);
    }
}
using MyCoin.Models;

namespace MyCoin.Services
{
    public interface IBinanceReq<T> where T : BinanceBase, new()
    {
        string BaseUrl { get; }
        T Result(string param);
    }
}
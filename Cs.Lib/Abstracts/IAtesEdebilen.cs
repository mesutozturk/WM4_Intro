using System.IO;

namespace Cs.Lib.Abstracts
{
    public interface IAtesEdebilen
    {
        int AtesEt();
        Stream AtisSesi { get; }
        Stream BitikFisekSesi { get; }
    }
}

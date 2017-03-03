using System.Collections.Generic;

namespace LottoApi.Models
{
    public interface ILottoResultRepository
    {
        IEnumerable<LottoResult> GetTodayResult();
        void Add(LottoResult item);
    }
}

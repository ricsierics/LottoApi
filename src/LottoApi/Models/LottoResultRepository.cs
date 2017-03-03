using System;
using System.Collections.Generic;
using System.Linq;

namespace LottoApi.Models
{
    public class LottoResultRepository : ILottoResultRepository
    {
        private readonly LottoResultContext _context;

        public LottoResultRepository(LottoResultContext context)
        {
            _context = context;

            Add(new LottoResult
            {
                LottoGameName = "Megalotto 6/45",
                Combination = "34-17-15-11-16-23",
                DrawDate = DateTime.ParseExact("01/03/2017", "dd/MM/yyyy", null),
                JackpotPrize = Decimal.Parse("139,823,208.00"),
                Winners = 0
            });

            Add(new LottoResult
            {
                LottoGameName = "Superlotto 6/49",
                Combination = "	14-27-32-45-03-30",
                DrawDate = DateTime.ParseExact("02/03/2017", "dd/MM/yyyy", null),
                JackpotPrize = Decimal.Parse("139,823,208.00"),
                Winners = 0
            });
        }

        public void Add(LottoResult lottoResult)
        {
            _context.LottoResults.Add(lottoResult);
            _context.SaveChanges();
        }

        public IEnumerable<LottoResult> GetTodayResult()
        {
            return _context.LottoResults.ToList();
        }
    }
}

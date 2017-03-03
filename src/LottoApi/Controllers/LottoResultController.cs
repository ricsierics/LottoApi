using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LottoApi.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LottoApi.Controllers
{
    [Route("api/[controller]")]
    public class LottoResultController : Controller
    {
        private readonly ILottoResultRepository _lottoResultRepository;

        public LottoResultController(ILottoResultRepository lottoResultRepository)
        {
            _lottoResultRepository = lottoResultRepository;
        }

        [HttpGet]
        public IEnumerable<LottoResult> GetTodayResult()
        {
            return _lottoResultRepository.GetTodayResult();
        }
    }
}
